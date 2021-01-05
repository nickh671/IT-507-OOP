using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hertzog_2_2
{
    public partial class Hertzog_2_2 : Form
    {
        public Hertzog_2_2()
        {
            InitializeComponent();
        }

        //onclick function for picture box 1
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("One");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //onclick function for picture box 2
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Two");
        }

        //onclick function for picture box 4
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Four");
        }

        //onclick function for picture box 3
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Three");
        }

        //onclick function for picture box 5
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Five");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
