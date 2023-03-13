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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            foreach (var item1 in Program.user)
            {
                LB1.Items.Add(item1._Name);
                LB2.Items.Add(item1._Name);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            this.Hide();
            f5.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Program.Game++;
            if (LB1.SelectedItem.Equals(LB2.SelectedItem))
            {
                MessageBox.Show("Please select different Player");
            }
            else
            {
                Form7 f7 = new Form7();
                f7.Show();
                this.Hide();
            }
        }

    }
}
