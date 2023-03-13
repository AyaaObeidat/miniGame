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
    public partial class History : Form
    {
        public History()
        { InitializeComponent();}

        private void Form6_Load(object sender, EventArgs e)
        {  MessageBox.Show("Please enter your Game ID:"); }

        private void button3_Click(object sender, EventArgs e)
        {
            StartPage f1 = new StartPage();
            this.Hide();
            f1.Show();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            gameInfo();
        }
        string player1, player2;

        private void button2_Click(object sender, EventArgs e)
        {
            NewGame f1 = new NewGame();
            this.Hide();
            f1.Show();
        }

        private void gameInfo()
        {
            int gameID=int.Parse(textBox1.Text);
            foreach(var gID in StartPage.games)
            {
                if(gID.GameID==gameID)
                {
                   foreach(var pID in StartPage.user)
                    {
                        if(StartPage.CurrentGame.FirstPlayerID==pID.ID)
                        {
                            label4.Text = pID._Name;
                            player1= pID._Name;
                        }
                        if(StartPage.CurrentGame.SecondPlayerID == pID.ID)
                        {
                            label4.Text +=$", {pID._Name}";
                            player2 = pID._Name;

                        }
                    }

                    label5.Text = StartPage.CurrentGame.date.ToString();
                    label6.Text = $"{StartPage.CurrentGame.Score1.ToString()} VS {StartPage.CurrentGame.Score2.ToString()}";
                    if(StartPage.CurrentGame.Score1> StartPage.CurrentGame.Score2)
                    { label11.Text = player1;}
                    else
                    { label11.Text = player2;}

                    label7.Text=StartPage.CurrentGame.Duration.ToString();
             }
            else
                {
                    MessageBox.Show("the game ID does not exist");
                }
            }
        }
    }
}
