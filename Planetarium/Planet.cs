using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetariumNS
{
    public class Planet
    {
        // Exception handling error messages
        public const string OrbitInAUOutOfRangeMessage = "Orbit In AU must be greater than zero.";
        public const string OrbitalPeriodInEarthDaysOutOfRangeMessage = "Orbital Period In Earth Days must be greater than zero.";
        public const string SizeRelativeToEarthOutOfRangeMessage = "Size Relative To Earth must be greater than zero.";
        
        // For calculation of orbit ( = 360 degrees )
        private const double OneTurn = 2 * Math.PI;

        // OrbitAngle is a property used by cosine and sine to calculate position of the planet in orbit
        // OrbitAngle is incremented by RadiansPerTick each timer tick
        private double orbitAngle;
        public double OrbitAngle 
        {
            get
            {
                return orbitAngle;
            }
            set
            {
                orbitAngle = value;
                if (orbitAngle > OneTurn) { orbitAngle = 0; }
            } 
        }

        private int orbitalPeriodInEarthDays;
        public int OrbitalPeriodInEarthDays
        {
            get
            {
                return orbitalPeriodInEarthDays;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("orbitalPeriodInEarthDays", value, OrbitalPeriodInEarthDaysOutOfRangeMessage);
                }
                orbitalPeriodInEarthDays = value;                
            }
        }
        
        // Orbit in Astronomical Units; implemented as number of pixels by multiplying by the OneAU variable - see DrawOrbit() method
        private double orbitInAU;
        public double OrbitInAU
        {
            get
            {
                return orbitInAU;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("orbitInAU", value, OrbitInAUOutOfRangeMessage); 
                }
                orbitInAU = value;
            }
        }

        // Radius of planet relative to Earths radius; Implemented as number of pixels by multiplying by the BaseRadius variable - see DrawSize() method
        private double sizeRelativeToEarth;
        public double SizeRelativeToEarth
        {
            get
            {
                return sizeRelativeToEarth;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("sizeRelativeToEarth", value, SizeRelativeToEarthOutOfRangeMessage);
                }
                sizeRelativeToEarth = value;
            }
        }
                                        
        // Color to draw the planet in GUI
        public System.Drawing.Color DrawColor { get; set; }

        // Bitmap to use for display in GUI
        public string PlanetBitmap { get; set; }
        
        // Name of planet used in GUI
        public string Name { get; set; }

        // Classifcation of planet used in GUI
        public PlanetType PlanetType { get; set; }

        // Constructors
        // Please note arcAngle is an optional parameter that sets the initial position in orbit
        // Please note planetBimap is an optional parameter
        // Base class constructor, so can implement derived class "Moon"
        public Planet() { }

        public Planet(string planetName, int orbitalPeriodInEarthDays, double orbitInAU, double sizeRelativeToEarth, System.Drawing.Color planetColor, PlanetType planetType, double orbitAngle = 0, string planetBitmap = "")
        {
            Name = planetName;
            OrbitalPeriodInEarthDays = orbitalPeriodInEarthDays;
            OrbitInAU = orbitInAU;
            SizeRelativeToEarth = sizeRelativeToEarth;
            DrawColor = planetColor;
            PlanetType = planetType;
            OrbitAngle = orbitAngle;
            PlanetBitmap = planetBitmap;
        }
        
        // Methods
        // RadiansPerTick is the speed of orbit; calculated based on earth days to orbit the sun
        public double RadiansPerTick()
        {
            return OneTurn / OrbitalPeriodInEarthDays;
        }

        // Moves the planet along its orbital trajectory
        public void IncOrbitAngle()
        {
            OrbitAngle += RadiansPerTick();
        }

        // Size of circle to use as orbit, based on class property OrbitInAU
        public int DrawOrbit(int oneAUInPixels)
        {
            return (int)Math.Round(OrbitInAU * oneAUInPixels);
        }

        // Size to draw the planet, based on class property SizeRelativeToEarth
        public int DrawSize(int baseRadiusInPixels)
        {
            int size = (int)Math.Round(SizeRelativeToEarth * baseRadiusInPixels);
            return (size < 2) ? 2 : size;
       }
                
        // X coordinate along orbital trajectory
        public virtual int PosX(int x, int oneAUInPixels, int baseRadiusInPixels)
        {
            return (int)Math.Round(x + (Math.Cos(OrbitAngle) * DrawOrbit(oneAUInPixels)) - (DrawSize(baseRadiusInPixels) / 2));
        }

        // Y coordinate along orbital trajectory
        public virtual int PosY(int y, int oneAUInPixels, int baseRadiusInPixels)
        {
            return (int)Math.Round(y + (Math.Sin(OrbitAngle) * DrawOrbit(oneAUInPixels)) - (DrawSize(baseRadiusInPixels) / 2));
        }

        // Coordinates along orbital trajectory given orbital center, distance from center and size of planet
        public virtual Point DrawOrigin(Point oldOrigin, int oneAUInPixels, int baseRadiusInPixels)
        {
            Point newOrigin = new Point();
            newOrigin.X = (int)Math.Round(oldOrigin.X + (Math.Cos(OrbitAngle) * DrawOrbit(oneAUInPixels)) - (DrawSize(baseRadiusInPixels) / 2));
            newOrigin.Y = (int)Math.Round(oldOrigin.Y + (Math.Sin(OrbitAngle) * DrawOrbit(oneAUInPixels)) - (DrawSize(baseRadiusInPixels) / 2));
            return newOrigin;
        }
    }

    class Moon : Planet
    {
        // Planet the moon orbits
        public Planet SatelliteOfPlanet { get; set; }

        // Constructor
        // Enhance the base class costructor with planet to orbit "SatelliteOfPlanet"
        public Moon(string planetName, int orbitalPeriodInEarthDays, double orbitInAU, double sizeRelativeToEarth, System.Drawing.Color planetColor, PlanetType planetClass, Planet satelliteOfPlanet, double arcAngle = 0, string planetBitmap = "")
        {
            Name = planetName;
            OrbitalPeriodInEarthDays = orbitalPeriodInEarthDays;
            OrbitInAU = orbitInAU;
            SizeRelativeToEarth = sizeRelativeToEarth;
            DrawColor = planetColor;
            PlanetType = planetClass;
            OrbitAngle = arcAngle;
            PlanetBitmap = planetBitmap;
            SatelliteOfPlanet = satelliteOfPlanet;
        }

        // X coordinate along orbital trajectory
        // Pass into base class method the orbital location of planet the moon orbits and adjustment due to size of the planet the moon orbits
        public override int PosX(int x, int oneAUInPixels, int baseRadiusInPixels)
        {
            return base.PosX(SatelliteOfPlanet.PosX(x, oneAUInPixels, baseRadiusInPixels) + (SatelliteOfPlanet.DrawSize(baseRadiusInPixels) / 2), oneAUInPixels, baseRadiusInPixels);            
        }

        // Y coordinate along orbital trajectory
        // Pass into base class method the orbital location of planet the moon orbits and adjustment due to size of the planet the moon orbits
        public override int PosY(int y, int oneAUInPixels, int baseRadiusInPixels)
        {
            return base.PosY(SatelliteOfPlanet.PosY(y, oneAUInPixels, baseRadiusInPixels) + (SatelliteOfPlanet.DrawSize(baseRadiusInPixels) / 2), oneAUInPixels, baseRadiusInPixels);
        }

        public override Point DrawOrigin(Point oldOrigin, int oneAUInPixels, int baseRadiusInPixels)
        {
            Point newOrigin = new Point();
            oldOrigin.X += SatelliteOfPlanet.DrawSize(baseRadiusInPixels) / 2;
            oldOrigin.Y += SatelliteOfPlanet.DrawSize(baseRadiusInPixels) / 2;
            newOrigin = base.DrawOrigin(SatelliteOfPlanet.DrawOrigin(oldOrigin, oneAUInPixels, baseRadiusInPixels), oneAUInPixels, baseRadiusInPixels);
            return newOrigin;
        }            
    }
}
