﻿namespace mini
{
    partial class Level1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.progressBar2);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Location = new System.Drawing.Point(61, 112);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 400);
            this.panel2.TabIndex = 4;
           // this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(615, 206);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 26);
            this.pictureBox6.TabIndex = 12;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(141, 210);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(27, 22);
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::mini.Properties.Resources.g1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(64, 171);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 94);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::mini.Properties.Resources.g11;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(622, 171);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(96, 94);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // progressBar2
            // 
            this.progressBar2.BackColor = System.Drawing.Color.Green;
            this.progressBar2.Location = new System.Drawing.Point(488, 11);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(257, 23);
            this.progressBar2.TabIndex = 6;
            this.progressBar2.Value = 100;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Green;
            this.progressBar1.Location = new System.Drawing.Point(20, 11);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(257, 23);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Value = 100;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 30;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 9);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.label1.Size = new System.Drawing.Size(146, 48);
            this.label1.TabIndex = 8;
            this.label1.Text = "Level : 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(209, 73);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.label3.Size = new System.Drawing.Size(146, 37);
            this.label3.TabIndex = 10;
            this.label3.Text = "Score 1: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(699, 73);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.label4.Size = new System.Drawing.Size(146, 37);
            this.label4.TabIndex = 12;
            this.label4.Text = "Score 2: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(547, 73);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.label5.Size = new System.Drawing.Size(146, 37);
            this.label5.TabIndex = 11;
            this.label5.Text = "Shooter 2: ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(387, 9);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.label6.Size = new System.Drawing.Size(248, 48);
            this.label6.TabIndex = 13;
            this.label6.Text = "Time Left (Seconds): ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(588, 9);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.label7.Size = new System.Drawing.Size(87, 48);
            this.label7.TabIndex = 14;
            this.label7.Text = "0";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Silver;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(99, 525);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.label8.Size = new System.Drawing.Size(92, 37);
            this.label8.TabIndex = 15;
            this.label8.Text = "END";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 73);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.label2.Size = new System.Drawing.Size(146, 37);
            this.label2.TabIndex = 16;
            this.label2.Text = "Shooter 1: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Silver;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(391, 73);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.label9.Size = new System.Drawing.Size(97, 37);
            this.label9.TabIndex = 17;
            this.label9.Text = "Game ID:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Level1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::mini.Properties.Resources.doodle_army_2_mini_militia_banner;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(930, 573);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Level1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Level1";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form7_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form7_KeyUp);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label9;
    }
}