using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hertzog_3_13
{

    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            //constants
            int coverage = 115;
            int hours = 8;
            double labor = 20.00;

            //square footage
            double sqft = double.Parse(SquareFeetTextBox.Text);
            //price per gallon
            double ppg = double.Parse(CostPerGallonTextBox.Text);

            //calculations
            double gallonsNeeded = (sqft / coverage);
            double laborHours = gallonsNeeded * hours;
            double paintCost = gallonsNeeded * ppg;
            double laborCost = laborHours * labor;
            double total = laborCost + paintCost;

            //displaying everything in their appropriate textboxes
            NumGallonsTB.Text = gallonsNeeded.ToString();
            LaborHoursTB.Text = laborHours.ToString();
            PaintCostTB.Text = paintCost.ToString();
            LaborCostTB.Text = laborCost.ToString();
            TotalCostTB.Text = total.ToString();
            
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
