using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hertzog_2_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Betelgeuse_Label.Visible = true;
            Meissa_Label.Visible = true;
            Mintaka_Label.Visible = true;
            Alnilam_Label.Visible = true;
            Alnitak_Label.Visible = true;
            Rigel_Label.Visible = true;
            Saiph_Label.Visible = true;
        }

        private void Betelgeuse_Label_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Betelgeuse_Label.Visible = false;
            Meissa_Label.Visible = false;
            Mintaka_Label.Visible = false;
            Alnilam_Label.Visible = false;
            Alnitak_Label.Visible = false;
            Rigel_Label.Visible = false;
            Saiph_Label.Visible = false;
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
