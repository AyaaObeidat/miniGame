using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
namespace mini
{
    public partial class StartPage : Form
    {
        public static int count = 0;
        public static List<User> user = new List<User>();
        public static List<Game> games = new List<Game>();
       
        public static Game CurrentGame = null;
        public static Game game = new Game();

        WindowsMediaPlayer player = new WindowsMediaPlayer();

        public StartPage()
        {
            InitializeComponent();
            count++;
            if (count == 1)
            {player.URL = "sounGame.mp3";}
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); Statistics statistic = new Statistics(); statistic.Show();
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (user.Count() > 1)
            { this.Hide(); NewGame newGame = new NewGame(); newGame.Show(); }
            else { MessageBox.Show("You Must Insert player!!"); }
        }

        private void currentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (StartPage.user.Count() == 0) { MessageBox.Show(" You must create profile "); }
            else
            { Current current = new Current(); this.Hide(); current.Show(); }
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide(); CreatePro craete = new CreatePro(); craete.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            player.controls.play();
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History history = new History(); this.Hide(); history.Show();
        }
    } }

