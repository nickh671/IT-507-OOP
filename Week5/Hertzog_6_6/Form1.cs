using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hertzog_6_6
{
    public partial class Form1 : Form
    {
        //variable to hold the daily cost of a stay
        private double dailyCost = 350.00;

        public Form1()
        {
            InitializeComponent();
        }

        private void chargesGB_Enter(object sender, EventArgs e)
        {

        }

        //onclick function for the calculate button that calls the CalctotalCharges function and sets the text of the total textbox to the total value returned
        private void calcButton_Click(object sender, EventArgs e)
        {
            totalTB.Text = CalcTotalCharges().ToString();
        }

        //function to calculate the fees for the amount of days a patient stays at the hospital
        private double CalcStayCharges()
        {
            //if valid value, parse, multiple by dailyCost variable and return
            //else return a 0
            if(!string.IsNullOrWhiteSpace(daysTB.Text) && double.TryParse(daysTB.Text, out _))
            {
                return (double.Parse(daysTB.Text) * dailyCost);
            }
            else
            {
                return 0;
            }
        }

        //function to calculate the cost of all misc charges
        private double CalcMiscCharges()
        {
            //running total
            double total = 0;
            //if value is entered and is valid double, add that value to running total
            //if no valid value is entered, the value is skipped (equivalent of just adding 0)
            if (!string.IsNullOrWhiteSpace(medsTB.Text) && double.TryParse(medsTB.Text, out _))
            {
                total += double.Parse(medsTB.Text);
            }
            if (!string.IsNullOrWhiteSpace(surgicalTB.Text) && double.TryParse(surgicalTB.Text, out _))
            {
                total += double.Parse(surgicalTB.Text);
            }
            if (!string.IsNullOrWhiteSpace(labTB.Text) && double.TryParse(labTB.Text, out _))
            {
                total += double.Parse(labTB.Text);
            }
            if (!string.IsNullOrWhiteSpace(rehabTB.Text) && double.TryParse(rehabTB.Text, out _))
            {
                total += double.Parse(rehabTB.Text);
            }
            return total;

        }

        //function to calculate a total of all costs and fees
        private double CalcTotalCharges()
        {
            return CalcStayCharges() + CalcMiscCharges();
        }
    }
}
