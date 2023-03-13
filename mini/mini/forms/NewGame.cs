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
    public partial class NewGame : Form
    {
        public NewGame()
        {
            InitializeComponent();
            foreach (var item1 in StartPage.user)
            {
                LB1.Items.Add(item1._Name);
                LB2.Items.Add(item1._Name);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            StartPage SP = new StartPage(); this.Hide(); SP.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(LB1.SelectedItem==null) { MessageBox.Show("Please Selsect Shooter1_Name"); }  
            else if(LB2.SelectedItem == null) { MessageBox.Show("Please Selsect Shooter2_Name"); }
            else if (LB1.SelectedItem == (LB2.SelectedItem))
                { MessageBox.Show("Please select different Player"); }
         


            else
            {
                Level1 level_1 = new Level1();
                StartPage.CurrentGame = new Game();
                StartPage.CurrentGame.GameID = StartPage.games.Count()+1;
                StartPage.CurrentGame.date = DateTime.Today;
          //          StartPage.game = new Game();

                foreach (var item in StartPage.user)
                {


                    //player1
                    if(LB1.SelectedItem.Equals(item._Name))
                    {
                        StartPage.CurrentGame.FirstPlayerID = item.ID;
                        if(item._FavC=="Red") { level_1.pictureBox1.BackgroundImage = Properties.Resources.r1; }
                        else if (item._FavC == "Yellow") { level_1.pictureBox1.BackgroundImage = Properties.Resources.y1; }
                        else { level_1.pictureBox1.BackgroundImage = Properties.Resources.b1; };
                    }


                    //player2
                    if (LB2.SelectedItem.Equals(item._Name))
                    {
                        StartPage.CurrentGame.SecondPlayerID = item.ID;
                        if (item._FavC == "Red") { level_1.pictureBox2.BackgroundImage = Properties.Resources.rl1; }
                        else if (item._FavC == "Yellow") { level_1.pictureBox2.BackgroundImage = Properties.Resources.yl1; }
                        else { level_1.pictureBox2.BackgroundImage = Properties.Resources.bl1; };
                    }
                }
                StartPage.games.Add(StartPage.CurrentGame);
                level_1.label2.Text += LB1.SelectedItem.ToString();
                level_1.label5.Text += LB2.SelectedItem.ToString();
                level_1.Show();
                this.Hide();
            }
        }
    }
}
