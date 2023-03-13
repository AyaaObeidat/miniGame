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
    public partial class Current : Form
    {
        public Current()
        {
            InitializeComponent();
            foreach (var item in StartPage.user)
                { LB1.Items.Add(item._Name); }
        }

        private void button3_Click(object sender, EventArgs e)//back
            { StartPage SP = new StartPage(); this.Hide(); SP.Show(); }

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in StartPage.user)
            {
                if(item._Name.Equals(StartPage.user[LB1.SelectedIndex]._Name))
                {
                    L7.Text = item._Name;
                    label8.Text = item._Age.ToString();
                    label10.Text = item._Gender;
                    label9.Text = item._FavC;
                }
            }
        }
        private void Current_Load(object sender, EventArgs e)
        {

        }
    }
}
