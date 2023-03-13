using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mini
{
    public partial class Form7 : Form
    {
        int speedUser = 10;
        int playerHeath1 = 100;
        int playerHeath2 = 100;
        bool gameOver;
        Move move = new Move();
        public Form7()
        {
            InitializeComponent();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void endToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f1 = new Form4();
            f1.Show();
            this.Hide();
        }
        int seconds;
        private void Form7_Load(object sender, EventArgs e)
        {

            seconds = Convert.ToInt32(label7.Text);
            timer1.Start();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            label7.Text = seconds++.ToString();
            label7.ForeColor = Color.Red;
        }
        private void Form7_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.W)
            {
                move.up1 = true;
            }
            if (e.KeyCode == Keys.S)
            {
                move.down1 = true;
            }
            if (e.KeyCode == Keys.D)
            {
                move.ShootBullet1 = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                move.Shootbullet2 = true;
            }
            ////////////////////////////////////
            if (e.KeyCode == Keys.Up)
            {
                move.up2 = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                move.down2 = true;
            }
        }

        private void Form7_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                move.up1 = false;
            }
            if (e.KeyCode == Keys.S)
            {
                move.down1 = false;
            }
            ////////////////////////////////
            if (e.KeyCode == Keys.Up)
            {
                move.up2 = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                move.down2 = false;
            }
            if(e.KeyCode == Keys.D)
            {
                //ShooterBullet()
            }
            if (e.KeyCode == Keys.Right)
            {

            }

        }
        private void ShooterBullet(string dir)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (move.up1 == true && pictureBox1.Top > -2)
            {
                pictureBox1.Top -= speedUser;
            }
            if (move.down1 == true && pictureBox1.Top < 246)
            {
                pictureBox1.Top += speedUser;
            }
            //////////////////////////////////
            if (move.up2 == true && pictureBox2.Top > -2)
            {
                pictureBox2.Top -= speedUser;
            }
            if (move.down2 == true && pictureBox2.Top < 246)
            {
                pictureBox2.Top += speedUser;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if(playerHeath1>0)
            {
                progressBar1.Value = playerHeath1;
            }
            else
            {
                gameOver = true;
            }
        }
    }
}
