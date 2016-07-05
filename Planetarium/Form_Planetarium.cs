using PlanetariumNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanetariumNS
{
    public partial class Form_Planetarium : Form
    {
        Timer t = new Timer();
        SolarSystem solarSystem = new SolarSystem();
        int tickInterval = 10;
        bool isPaused = false;
        
        public Form_Planetarium()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            t.Interval = tickInterval;
            t.Tick += new EventHandler(t_Tick);
            t.Start();
        }

        void t_Tick(object sender, EventArgs e)
        {
            foreach (var planet in solarSystem.Planets)
            {
                planet.IncOrbitAngle();                
            }
            this.Invalidate();
        }

        private void Form_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush myBrush;
            Font myFont;
            Bitmap myBitmap;
            Point planetOrigin;
            Size planetSize;
            Rectangle planetRect;
            RectangleF recClip = new RectangleF();            
            recClip = g.ClipBounds;
            Point solarSystemOrigin = new Point((int)Math.Round(recClip.Width / 2), (int)Math.Round(recClip.Height / 2));

            foreach (var planet in solarSystem.Planets)
            {
                myBrush = new SolidBrush(planet.DrawColor);
                myFont = new Font("Arial", 8);
                planetOrigin = planet.DrawOrigin(solarSystemOrigin, SolarSystemVariables.OneAU, SolarSystemVariables.BaseRadius);
                planetSize = new Size(planet.DrawSize(SolarSystemVariables.BaseRadius), planet.DrawSize(SolarSystemVariables.BaseRadius));
                planetRect = new Rectangle(planetOrigin, planetSize);

                if (ShouldDraw(planet))
                {
                    if (g.IsVisible(planetRect))
                    {
                        if ((checkBox_Images.Checked) && (planet.PlanetBitmap != ""))
                        {
                            myBitmap = new Bitmap(planet.PlanetBitmap);
                            g.DrawImage(myBitmap, planetRect);
                            myBitmap.Dispose();
                        }
                        else
                        {
                            g.FillEllipse(myBrush, planetRect);                        
                        }
                        if (checkBox_Names.Checked)
                        {
                            g.DrawString(planet.Name, myFont, myBrush, planetOrigin.X + planet.DrawSize(SolarSystemVariables.BaseRadius) + 5, planetOrigin.Y + planet.DrawSize(SolarSystemVariables.BaseRadius) + 5);
                        }
                    }
                    else
                    {
                        // Planet is off screen, so if its named and not a moon, then draw indicator on screen boundary
                        if ((planet.Name != "") && (PlanetType.Moon != (planet.PlanetType & PlanetType.Moon)))
                        {
                            g.FillEllipse(myBrush, new Rectangle(NewPos(planetOrigin.X, (int)recClip.Width), NewPos(planetOrigin.Y, (int)recClip.Height), 2, 2));
                            if (checkBox_Names.Checked)
                            {
                                g.DrawString(planet.Name, myFont, myBrush, NewNamePosX(NewPos(planetOrigin.X, (int)recClip.Width)), NewNamePosY(NewPos(planetOrigin.Y, (int)recClip.Height)));
                            }
                        }
                    }
                }
                
                myBrush.Dispose();
                myFont.Dispose();                
            } 
        }

        // Experimental
        private Point NewOrigin(Point oldOrigin, RectangleF screenRect)
        {
            Point newOrigin = new Point();

            if (oldOrigin.X < 0)
            {
                newOrigin.X = 0;
            }
            else if (oldOrigin.X >= screenRect.Width)
            {
                newOrigin.X = (int)screenRect.Width - 2;
            }
            else
            {
                newOrigin.X = oldOrigin.X;
            }
            if (oldOrigin.Y < 0)
            {
                newOrigin.Y = 0;
            }
            else if (oldOrigin.Y >= screenRect.Height)
            {
                newOrigin.Y = (int)screenRect.Height - 2;
            }
            else
            {
                newOrigin.Y = oldOrigin.Y;
            }

            return newOrigin;
        }

        // Calculates new coordinate for off screen planets;         
        private int NewPos(int oldPos, int posLimit)
        {
            if (oldPos <= 0) { return 0; }
            else if (oldPos >= posLimit) { return posLimit - 2;  }
            else { return oldPos; }
        }
        
        private int NewNamePosX(int x)
        {
            if (x <= 15) { return 15; }
            else { return x - 50; }
        }

        private int NewNamePosY(int y)
        {
            if (y <= 15) { return 15; }
            else { return y - 15; }
        }

        private void trackBar_OneAU_Scroll(object sender, EventArgs e)
        {
            SolarSystemVariables.OneAU = trackBar_OneAU.Value;
            SolarSystemVariables.BaseRadius = SolarSystemVariables.OneAU / 5;
        }

        private void button_Play_Click(object sender, EventArgs e)
        {
            if (isPaused)
            {
                t.Start();
                isPaused = false;
                button_Play.Text = "Pause";
            }
            else
            {
                t.Stop();
                isPaused = true;
                button_Play.Text = "Play";
            }
        }

        private void trackBar_t_Interval_Scroll(object sender, EventArgs e)
        {
            t.Interval = trackBar_t_Interval.Value;
        }

        private void checkBox_Background_Click(object sender, EventArgs e)
        {
            if (checkBox_Background.Checked)
            {
                Form_Planetarium.ActiveForm.BackgroundImage = PlanetariumNS.Properties.Resources.milky_way;
            }
            else
            {
                Form_Planetarium.ActiveForm.BackgroundImage = null;
            }
        }

        private bool ShouldDraw(Planet p)
        {
            if ((PlanetType.Moon == (p.PlanetType & PlanetType.Moon)) && !(checkBox_Moons.Checked))
            {
                return false;
            }
            else if ((PlanetType.InnerPlanet == (p.PlanetType & PlanetType.InnerPlanet)) && !(checkBox_InnerPlanets.Checked))
            {
                return false;
            }
            else if ((PlanetType.OuterPlanet == (p.PlanetType & PlanetType.OuterPlanet)) && !(checkBox_OuterPlanets.Checked))
            {
                return false;
            }
            else if ((PlanetType.DwarfPlanet == (p.PlanetType & PlanetType.DwarfPlanet)) && !(checkBox_DwarfPlanets.Checked))
            {
                return false;
            }
            else if ((PlanetType.Asteroid == (p.PlanetType & PlanetType.Asteroid)) && !(checkBox_Asteroids.Checked))
            {
                return false;
            }
            else
            {
                return true;
            }        
        }
    }
}
