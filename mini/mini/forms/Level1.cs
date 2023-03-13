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
    public partial class Level1 : Form
    {
        bool isgameOver;
        int time = 0 , speedUser = 10, playerHeath1 = 100 ,playerHeath2 = 100;
        int bulletSpeed1, bulletSpeed2;
        Move move = new Move();
        bullet Bullet = new bullet();
        public Level1()
        {
            InitializeComponent();
        }

        private void Form7_KeyDown(object sender, KeyEventArgs e)
        {
            //PLAYER1
            if (e.KeyCode == Keys.W) { move.up1 = true;}
            if (e.KeyCode == Keys.S) { move.down1 = true;}
            //PLAYER2
            if (e.KeyCode == Keys.Up) { move.up2 = true;}
            if (e.KeyCode == Keys.Down) { move.down2 = true;}
        }
        private void Form7_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) { move.up1 = false; }
            if (e.KeyCode == Keys.S) { move.down1 = false; }


            if (e.KeyCode == Keys.Up) { move.up2 = false; }
            if (e.KeyCode == Keys.Down) { move.down2 = false; }

            ///////////////////////////////////////////
            if (e.KeyCode == Keys.D && bullet.ShootBullet1 == false)
            {
                bullet.ShootBullet1 = true;
                pictureBox5.Left = pictureBox1.Top - 30;
                pictureBox5.Top = pictureBox1.Top + (pictureBox1.Width / 2);
            }



            if (e.KeyCode == Keys.Left && bullet.ShootBullet2 == false)
            {
                bullet.ShootBullet2 = true;
                pictureBox6.Left = pictureBox2.Top + 500;
                pictureBox6.Top = pictureBox2.Top + (pictureBox2.Width / 2);
            }
            var gameID = StartPage.games.Count();
            var game = StartPage.games[gameID - 1];
            if (pictureBox5.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                if (progressBar2.Value == 0)
                {
                    game.Level = 2;
                    game.Level1Duration = seconds;
                    game.Duration = game.Level1Duration + game.Level2Duration;
                    nextLevel();
                }
                else
                {
                    label3.Text = "Score1: ";
                    StartPage.game.Score1 += 1;
                    game.Score1 = StartPage.game.Score1;
                    label3.Text += StartPage.game.Score1;

                    //pictureBox5.Top = 1000;
                    progressBar2.Value -= 10;
                    bullet.ShootBullet1 = false;
                }
            }
            if (pictureBox6.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                if (progressBar1.Value == 0)
                {
                    game.Level = 2;
                    game.Level1Duration = seconds;
                    game.Duration = game.Level1Duration + game.Level2Duration;
                    nextLevel();
                }
                else
                {
                    label4.Text = "Score2: ";
                    StartPage.game.Score2 += 1;
                    game.Score2 = StartPage.game.Score2;
                    label4.Text += StartPage.game.Score2;
                    //pictureBox6.Top = -500;
                    progressBar1.Value -= 10;
                    bullet.ShootBullet2 = false;

                }
            }
        }      
        int seconds;
        private void Form7_Load(object sender, EventArgs e)
        {
            seconds = Convert.ToInt32(label7.Text);
            timer2.Start();
            label9.Text = "GameID : " + StartPage.CurrentGame.GameID.ToString();
        }


        private void label8_Click(object sender, EventArgs e)
        {
            GameTimer.Stop();
            timer2.Stop();
            MessageBox.Show("End Game.");
            StartPage Sp = new StartPage(); this.Hide(); Sp.Show();
        }
        private void GameTimer_Tick(object sender, EventArgs e)
        {  ///////////////
            if (move.up1 == true && pictureBox1.Top > 45)
            { pictureBox1.Top -= speedUser; }

            if (move.down1 == true && pictureBox1.Top < 289)
            { pictureBox1.Top += speedUser;}
           /////////////////////////
            if (move.up2 == true && pictureBox2.Top > 45)
            { pictureBox2.Top -= speedUser; }

            if (move.down2 == true && pictureBox2.Top < 289)
            { pictureBox2.Top += speedUser; }
           
            //pictureBox5.Left += bulletSpeed1;
            if (bullet.ShootBullet1 == true)
            {
                bulletSpeed1 = 20;
                pictureBox5.Left += bulletSpeed1;
            }
            else
            {
                pictureBox5.Left = -300; bulletSpeed1 = 0;
            }
            
            if (bullet.ShootBullet2 == true)
            {
                bulletSpeed2 = 20; pictureBox6.Left -= bulletSpeed2;
            }
            else
            {
                pictureBox6.Left = 850; bulletSpeed2 = 0;
            }
           
            if (pictureBox5.Left > 751)
            { bullet.ShootBullet1 = false; }

            if (pictureBox6.Left < 0)
            { bullet.ShootBullet2 = false;}
        }
        private void timer2_Tick(object sender, EventArgs e)
        {

            label7.Text = seconds++.ToString();
            label7.ForeColor = Color.Red;
            if (seconds > 120)
            {
                nextLevel();
            }
        }
        private void nextLevel()
        {
            GameTimer.Stop();
            timer2.Stop();
            MessageBox.Show("End Level.");
            Level2 level_2 = new Level2(StartPage.game.Score1,StartPage.game.Score2);
            level_2.label2.Text = label2.Text;
            level_2.label5.Text = label5.Text;
            foreach (var item in StartPage.user)
            {
                if (level_2.label2.Text.Equals("Shooter 1: "+item._Name))
                {
                    if (item._FavC == "Red") { level_2.pictureBox1.BackgroundImage = Properties.Resources.r1; }
                    else if (item._FavC == "Yellow") { level_2.pictureBox1.BackgroundImage = Properties.Resources.y1; }
                    else { level_2.pictureBox1.BackgroundImage = Properties.Resources.b1; };
                }
                if (level_2.label5.Text.Equals("Shooter 2: " + item._Name))
                {
                    if (item._FavC == "Red") { level_2.pictureBox2.BackgroundImage = Properties.Resources.rl1; }
                    else if (item._FavC == "Yellow") { level_2.pictureBox2.BackgroundImage = Properties.Resources.yl1; }
                    else { level_2.pictureBox2.BackgroundImage = Properties.Resources.bl1; };
                }
            }
            this.Hide();
            level_2.Show();
        }
     
    }
    
}


