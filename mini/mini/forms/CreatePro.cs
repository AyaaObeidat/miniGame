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
    public partial class CreatePro : Form
    {
        public CreatePro()
        { InitializeComponent(); }

        private void button3_Click(object sender, EventArgs e)
        {
            StartPage SP = new StartPage(); this.Hide(); SP.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
           pictureBox1.BackgroundImage = Properties.Resources.b1;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.r1;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.y1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            { MessageBox.Show("Please Enter Your Name"); }

            else
            {
                var QueryProfile = StartPage.user.Where(prof => prof._Name == (textBox2.Text)).FirstOrDefault();
                if (QueryProfile == null)
                {
                    User obj = new User();
                    obj._Name = textBox2.Text;

                    if (comboBox1.Text == "")
                    { obj._Age = int.Parse(comboBox1.SelectedItem.ToString()); } //selectedItem
                    else { obj._Age = int.Parse(comboBox1.Text.ToString()); }   //Text

                    if (radioButton1.Checked) obj._Gender = radioButton1.Text;//gender
                    if (radioButton2.Checked) obj._Gender = radioButton2.Text;


                    if (radioButton3.Checked) obj._FavC = radioButton3.Text;//Color
                    if (radioButton4.Checked) obj._FavC = radioButton4.Text;
                    if (radioButton5.Checked) obj._FavC = radioButton5.Text;

                    obj.ID = StartPage.user.Count() + 1;
                    StartPage.user.Add(obj);

                    StartPage SP = new StartPage(); this.Hide(); SP.Show();
                }

                else { MessageBox.Show("The Player already exist"); }
            }
        }

        private void CreatePro_Load(object sender, EventArgs e)
        {

        }
    }
}
