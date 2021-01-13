using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hertzog_5_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            //var to hold num of days entered
            int days;
            //try parse to detect if valid number is entered
            bool isNumeric = Int32.TryParse(daysTextBox.Text, out days);

            //if invalid number show error message
            if (!isNumeric)
            {
                MessageBox.Show("Please enter a valid number.");
            }
            else
            {
                //if days = 0, display 0
                if (days == 0)
                {
                    penniesTextBox.Text = "0";
                }
                else
                {
                    //else do 2 ^ (days-1)
                    penniesTextBox.Text = Math.Pow(2, days - 1).ToString();
                }
            }
        }
    }
}
