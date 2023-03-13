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
    public partial class Statistics : Form
    {
        public int minScore;
        public int maxScore;
        public Statistics()
        { InitializeComponent(); }

        private void Form4_Load(object sender, EventArgs e)
        {
            setNumOfProfiles();
            setNumOfGames();
            setHighestScore();
            setLowestScore();
            setMaxDuration();
            setMinDuration();
            setTotalDuration();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StartPage SP = new StartPage(); this.Hide(); SP.Show();
        }
        public void setNumOfProfiles()
        {
            var q1 = from profile in StartPage.user
                     select profile;
            label4.Text = $"{q1.Count()}";
        }
        public void setNumOfGames()
        {
            var q2 = from game in StartPage.games
                     select game;
            label6.Text = $"{q2.Count()}";
        }

       public void  setHighestScore()
        {
            var highestFirstScore = StartPage.games.OrderByDescending(g => g.Score1).First().Score1;
            var highestSecondScore = StartPage.games.OrderByDescending(g => g.Score2).First().Score2;
            var highestScore = highestFirstScore >= highestSecondScore ? highestFirstScore : highestSecondScore;
            label8.Text = highestScore.ToString();
        }

        public void setLowestScore()
        {
            var lowestFirstScore = StartPage.games.OrderBy(g => g.Score1).First().Score1;
            var lowestSecondScore = StartPage.games.OrderBy(g => g.Score2).First().Score2;
            var lowestScore = lowestFirstScore <= lowestSecondScore ? lowestFirstScore : lowestSecondScore;
            label9.Text = lowestScore.ToString();
        }
        public void setMaxDuration()
        {
            var duration = StartPage.games.OrderByDescending(g => g.Duration).First().Duration;
            label15.Text = duration.ToString();
        }
        public void setMinDuration()
        {
            var duration = StartPage.games.OrderBy(g => g.Duration).First().Duration;
            label10.Text = duration.ToString();
        }
        public void setTotalDuration()
        {
            var total = StartPage.games.Sum(g => g.Duration);
            label17.Text = total.ToString();
        }

    }
}
