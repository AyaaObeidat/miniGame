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
    public partial class Level2 : Form
    {
        bool isgameOver;
        int time2 = 0, speedUser = 10, enemySpeed1 = 15, enemySpeed2 = 5, playerHeath1 = 100, playerHeath2 = 100;
        int score1 = 0, score2 = 0;
        int bulletSpeed1, bulletSpeed2;
        Random rand = new Random();
        Move move = new Move();
        bullet Bullet = new bullet();
        public Level2(int s1 , int s2)
        {
            score1 = s1;
            score2 = s2;
            StartPage.game.Score2 = score2;
            StartPage.game.Score1 = score1;
            InitializeComponent();
            restGame();
        }
        public Level2() { }
        private void gameOver()
        { isgameOver = true; GameTimer.Stop();}


        private void restGame()
        {
;
//            label1.Text += level.ToString();
            GameTimer.Start();
            enemySpeed1 = 6;
            bulletSpeed1 = 0;
            bulletSpeed2 = 0;
            bullet.ShootBullet1 = false;
            bullet.ShootBullet2 = false;

        }
        private void game_Over()
        {
            isgameOver = true;
            GameTimer.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
            MessageBox.Show("End Game.");
            StartPage start_page = new StartPage();
            this.Hide();
            start_page.Show();
        }
        private void removeBullet(PictureBox bullet)
        {
            this.Controls.Remove(bullet);
            bullet.Dispose();
        }

        private void Form8_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) { move.up1 = false; }
            if (e.KeyCode == Keys.S) { move.down1 = false; }
            if (e.KeyCode == Keys.Up) { move.up2 = false; }
            if (e.KeyCode == Keys.Down) { move.down2 = false;  }
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
            var game = StartPage.games[gameID -1];
            if (pictureBox5.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                if (progressBar2.Value <= 0)
                {
                    game.Level2Duration = seconds;
                    game.Duration = game.Level1Duration + game.Level2Duration;
                    game_Over();
                }
                else
                {
                    label3.Text = "Score1: ";
                    
                    StartPage.game.Score1 += 1;
                    game.Score1 = StartPage.game.Score1;
                    label3.Text += StartPage.game.Score1;

                    pictureBox5.Top = 1000;
                    progressBar2.Value -= 20;
                    bullet.ShootBullet1 = false;

                }
            }
            if (pictureBox6.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                if (progressBar1.Value <= 0)
                {
                    game.Level2Duration = seconds;
                    game.Duration = game.Level1Duration + game.Level2Duration;
                    game_Over();
                }
                else
                {
                    label4.Text = "Score2: ";
                    StartPage.game.Score2 += 1;
                    game.Score2 = StartPage.game.Score2;
                    label4.Text += StartPage.game.Score2;
                    pictureBox6.Top = -500;
                    progressBar1.Value -= 20;
                    bullet.ShootBullet2 = false;

                }
            }
            if (pictureBox5.Bounds.IntersectsWith(pictureBox3.Bounds))
            {
                pictureBox5.Top = 1000;
                bulletSpeed1 = 5;
                bullet.ShootBullet1 = false;
                pictureBox3.Visible = false;

            }
            if (pictureBox5.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                pictureBox5.Top = 1000;
                bulletSpeed1 = 60;
                bullet.ShootBullet1 = false;
                pictureBox4.Visible = false;

            }
            if (pictureBox6.Bounds.IntersectsWith(pictureBox3.Bounds))
            {
                pictureBox6.Top = 1000;
                bulletSpeed2 = 5;
                bullet.ShootBullet2 = false;
                pictureBox3.Visible = false;

            }
            if (pictureBox6.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                pictureBox6.Top = 1000;
                bulletSpeed2 = 60;
                bullet.ShootBullet2 = false;
                pictureBox4.Visible = false;
            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox4.Top += enemySpeed1;
            if (pictureBox4.Top > 362 || pictureBox4.Visible ==false)
            {
                pictureBox4.Top = 45;
                pictureBox4.Visible = true;
                pictureBox4.Left = rand.Next(230, 427);
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {

            pictureBox3.Top += enemySpeed2;
            if (pictureBox3.Top > 362 || pictureBox3.Visible==false)
            {
                pictureBox3.Top = 45;
                pictureBox3.Visible = true;
                pictureBox3.Left = rand.Next(230, 427);
            }
        }

        private void Form8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) { move.up1 = true;  }
            if (e.KeyCode == Keys.S) { move.down1 = true; }
            if (e.KeyCode == Keys.Up) { move.up2 = true; }
            if (e.KeyCode == Keys.Down) { move.down2 = true; }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            GameTimer.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
            MessageBox.Show("End Game.");
            StartPage f6 = new StartPage();
            this.Hide();
            f6.Show();
        }

        
        int seconds;
        private void Form8_Load_1(object sender, EventArgs e)
        {
            seconds = Convert.ToInt32(label7.Text);
            timer2.Start();
            if(seconds > 120)
            {
                GameTimer.Stop();
                timer2.Stop();
                timer3.Stop();
                timer4.Stop();
                MessageBox.Show("End Game.");
                History history_Obj= new History();
                this.Hide();
                history_Obj.Show();
            }
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {

            label7.Text = seconds++.ToString();
            label7.ForeColor = Color.Red;
            if (seconds > 120)
            {
                gameOver();
            }
        }

        private void GameTimer_Tick_1(object sender, EventArgs e)
        {
            if (move.up1 == true && pictureBox1.Top > 45)
            { pictureBox1.Top -= speedUser;}

            if (move.down1 == true && pictureBox1.Top < 289)
            { pictureBox1.Top += speedUser; }
           

            if (move.up2 == true && pictureBox2.Top > 45)
            { pictureBox2.Top -= speedUser;}

            if (move.down2 == true && pictureBox2.Top < 289)
            { pictureBox2.Top += speedUser; }
           
            pictureBox5.Left += bulletSpeed1;

            if (bullet.ShootBullet1 == true)
            {
                bulletSpeed1 = 10;
                pictureBox5.Left += bulletSpeed1;
            }

            else
            { pictureBox5.Left = -300; bulletSpeed1 = 0; }


            if (bullet.ShootBullet2 == true)
            {
                bulletSpeed2 = 10;
                pictureBox6.Left -= bulletSpeed2;
            }

            else
            { pictureBox6.Left = 850; bulletSpeed2 = 0;}
           
            if (pictureBox5.Left > 755)
            { bullet.ShootBullet1 = false; }

            if (pictureBox6.Left < 0)
            { bullet.ShootBullet2 = false; }
        }
    }
}
