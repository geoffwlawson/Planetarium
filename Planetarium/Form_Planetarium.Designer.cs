using System.Drawing;

namespace PlanetariumNS
{
    partial class Form_Planetarium
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
                      
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBox_Names = new System.Windows.Forms.CheckBox();
            this.trackBar_OneAU = new System.Windows.Forms.TrackBar();
            this.checkBox_Images = new System.Windows.Forms.CheckBox();
            this.button_Play = new System.Windows.Forms.Button();
            this.trackBar_t_Interval = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox_Background = new System.Windows.Forms.CheckBox();
            this.checkBox_Moons = new System.Windows.Forms.CheckBox();
            this.checkBox_InnerPlanets = new System.Windows.Forms.CheckBox();
            this.checkBox_OuterPlanets = new System.Windows.Forms.CheckBox();
            this.checkBox_DwarfPlanets = new System.Windows.Forms.CheckBox();
            this.checkBox_Asteroids = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_OneAU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_t_Interval)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox_Names
            // 
            this.checkBox_Names.AutoSize = true;
            this.checkBox_Names.Checked = true;
            this.checkBox_Names.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Names.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_Names.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Names.ForeColor = System.Drawing.Color.White;
            this.checkBox_Names.Location = new System.Drawing.Point(12, 12);
            this.checkBox_Names.Name = "checkBox_Names";
            this.checkBox_Names.Size = new System.Drawing.Size(59, 17);
            this.checkBox_Names.TabIndex = 0;
            this.checkBox_Names.Text = "Names";
            this.checkBox_Names.UseVisualStyleBackColor = true;
            // 
            // trackBar_OneAU
            // 
            this.trackBar_OneAU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar_OneAU.Location = new System.Drawing.Point(5, 19);
            this.trackBar_OneAU.Maximum = 200;
            this.trackBar_OneAU.Minimum = 10;
            this.trackBar_OneAU.Name = "trackBar_OneAU";
            this.trackBar_OneAU.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_OneAU.Size = new System.Drawing.Size(45, 104);
            this.trackBar_OneAU.SmallChange = 5;
            this.trackBar_OneAU.TabIndex = 1;
            this.trackBar_OneAU.TickFrequency = 5;
            this.trackBar_OneAU.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar_OneAU.Value = 25;
            this.trackBar_OneAU.Scroll += new System.EventHandler(this.trackBar_OneAU_Scroll);
            // 
            // checkBox_Images
            // 
            this.checkBox_Images.AutoSize = true;
            this.checkBox_Images.Checked = true;
            this.checkBox_Images.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Images.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_Images.ForeColor = System.Drawing.Color.White;
            this.checkBox_Images.Location = new System.Drawing.Point(12, 35);
            this.checkBox_Images.Name = "checkBox_Images";
            this.checkBox_Images.Size = new System.Drawing.Size(60, 17);
            this.checkBox_Images.TabIndex = 2;
            this.checkBox_Images.Text = "Images";
            this.checkBox_Images.UseVisualStyleBackColor = true;
            // 
            // button_Play
            // 
            this.button_Play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Play.ForeColor = System.Drawing.Color.White;
            this.button_Play.Location = new System.Drawing.Point(14, 467);
            this.button_Play.Name = "button_Play";
            this.button_Play.Size = new System.Drawing.Size(59, 23);
            this.button_Play.TabIndex = 3;
            this.button_Play.Text = "Pause";
            this.button_Play.UseVisualStyleBackColor = true;
            this.button_Play.Click += new System.EventHandler(this.button_Play_Click);
            // 
            // trackBar_t_Interval
            // 
            this.trackBar_t_Interval.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar_t_Interval.Location = new System.Drawing.Point(6, 19);
            this.trackBar_t_Interval.Maximum = 200;
            this.trackBar_t_Interval.Minimum = 10;
            this.trackBar_t_Interval.Name = "trackBar_t_Interval";
            this.trackBar_t_Interval.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_t_Interval.Size = new System.Drawing.Size(45, 104);
            this.trackBar_t_Interval.TabIndex = 4;
            this.trackBar_t_Interval.TickFrequency = 10;
            this.trackBar_t_Interval.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar_t_Interval.Value = 10;
            this.trackBar_t_Interval.Scroll += new System.EventHandler(this.trackBar_t_Interval_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trackBar_t_Interval);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(14, 329);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(59, 132);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Speed";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.trackBar_OneAU);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(14, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(58, 127);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zoom";
            // 
            // checkBox_Background
            // 
            this.checkBox_Background.AutoSize = true;
            this.checkBox_Background.Checked = true;
            this.checkBox_Background.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Background.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_Background.ForeColor = System.Drawing.Color.White;
            this.checkBox_Background.Location = new System.Drawing.Point(12, 58);
            this.checkBox_Background.Name = "checkBox_Background";
            this.checkBox_Background.Size = new System.Drawing.Size(84, 17);
            this.checkBox_Background.TabIndex = 7;
            this.checkBox_Background.Text = "Background";
            this.checkBox_Background.UseVisualStyleBackColor = true;
            this.checkBox_Background.Click += new System.EventHandler(this.checkBox_Background_Click);
            // 
            // checkBox_Moons
            // 
            this.checkBox_Moons.AutoSize = true;
            this.checkBox_Moons.Checked = true;
            this.checkBox_Moons.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Moons.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_Moons.ForeColor = System.Drawing.Color.White;
            this.checkBox_Moons.Location = new System.Drawing.Point(12, 81);
            this.checkBox_Moons.Name = "checkBox_Moons";
            this.checkBox_Moons.Size = new System.Drawing.Size(58, 17);
            this.checkBox_Moons.TabIndex = 8;
            this.checkBox_Moons.Text = "Moons";
            this.checkBox_Moons.UseVisualStyleBackColor = true;
            // 
            // checkBox_InnerPlanets
            // 
            this.checkBox_InnerPlanets.AutoSize = true;
            this.checkBox_InnerPlanets.Checked = true;
            this.checkBox_InnerPlanets.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_InnerPlanets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_InnerPlanets.ForeColor = System.Drawing.Color.White;
            this.checkBox_InnerPlanets.Location = new System.Drawing.Point(12, 104);
            this.checkBox_InnerPlanets.Name = "checkBox_InnerPlanets";
            this.checkBox_InnerPlanets.Size = new System.Drawing.Size(88, 17);
            this.checkBox_InnerPlanets.TabIndex = 9;
            this.checkBox_InnerPlanets.Text = "Inner Planets";
            this.checkBox_InnerPlanets.UseVisualStyleBackColor = true;
            // 
            // checkBox_OuterPlanets
            // 
            this.checkBox_OuterPlanets.AutoSize = true;
            this.checkBox_OuterPlanets.Checked = true;
            this.checkBox_OuterPlanets.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_OuterPlanets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_OuterPlanets.ForeColor = System.Drawing.Color.White;
            this.checkBox_OuterPlanets.Location = new System.Drawing.Point(12, 127);
            this.checkBox_OuterPlanets.Name = "checkBox_OuterPlanets";
            this.checkBox_OuterPlanets.Size = new System.Drawing.Size(90, 17);
            this.checkBox_OuterPlanets.TabIndex = 10;
            this.checkBox_OuterPlanets.Text = "Outer Planets";
            this.checkBox_OuterPlanets.UseVisualStyleBackColor = true;
            // 
            // checkBox_DwarfPlanets
            // 
            this.checkBox_DwarfPlanets.AutoSize = true;
            this.checkBox_DwarfPlanets.Checked = true;
            this.checkBox_DwarfPlanets.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_DwarfPlanets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_DwarfPlanets.ForeColor = System.Drawing.Color.White;
            this.checkBox_DwarfPlanets.Location = new System.Drawing.Point(12, 150);
            this.checkBox_DwarfPlanets.Name = "checkBox_DwarfPlanets";
            this.checkBox_DwarfPlanets.Size = new System.Drawing.Size(92, 17);
            this.checkBox_DwarfPlanets.TabIndex = 11;
            this.checkBox_DwarfPlanets.Text = "Dwarf Planets";
            this.checkBox_DwarfPlanets.UseVisualStyleBackColor = true;
            // 
            // checkBox_Asteroids
            // 
            this.checkBox_Asteroids.AutoSize = true;
            this.checkBox_Asteroids.Checked = true;
            this.checkBox_Asteroids.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Asteroids.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_Asteroids.ForeColor = System.Drawing.Color.White;
            this.checkBox_Asteroids.Location = new System.Drawing.Point(12, 173);
            this.checkBox_Asteroids.Name = "checkBox_Asteroids";
            this.checkBox_Asteroids.Size = new System.Drawing.Size(69, 17);
            this.checkBox_Asteroids.TabIndex = 12;
            this.checkBox_Asteroids.Text = "Asteroids";
            this.checkBox_Asteroids.UseVisualStyleBackColor = true;
            // 
            // Form_Planetarium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::PlanetariumNS.Properties.Resources.milky_way;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1031, 609);
            this.Controls.Add(this.checkBox_Asteroids);
            this.Controls.Add(this.checkBox_DwarfPlanets);
            this.Controls.Add(this.checkBox_OuterPlanets);
            this.Controls.Add(this.checkBox_InnerPlanets);
            this.Controls.Add(this.checkBox_Moons);
            this.Controls.Add(this.checkBox_Background);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Play);
            this.Controls.Add(this.checkBox_Images);
            this.Controls.Add(this.checkBox_Names);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.MinimizeBox = false;
            this.Name = "Form_Planetarium";
            this.ShowIcon = false;
            this.Text = "Planetarium";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_OneAU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_t_Interval)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_Names;
        private System.Windows.Forms.TrackBar trackBar_OneAU;
        private System.Windows.Forms.CheckBox checkBox_Images;
        private System.Windows.Forms.Button button_Play;
        private System.Windows.Forms.TrackBar trackBar_t_Interval;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox_Background;
        private System.Windows.Forms.CheckBox checkBox_Moons;
        private System.Windows.Forms.CheckBox checkBox_InnerPlanets;
        private System.Windows.Forms.CheckBox checkBox_OuterPlanets;
        private System.Windows.Forms.CheckBox checkBox_DwarfPlanets;
        private System.Windows.Forms.CheckBox checkBox_Asteroids;


    }
}

