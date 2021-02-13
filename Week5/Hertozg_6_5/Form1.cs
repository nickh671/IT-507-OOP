using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hertozg_6_5
{
    public partial class Form1 : Form
    {
        //hourly rate for labor
        private double hourlyRate = 20.00;
        //var for sales tax percent
        private double salesTax = .06;
        //dictionary to hold the values of the prices for each possible repair
        //couldve just made separable variables for each price but I prefer the dictionary. Makes it cleaner and easier to adapt later in my opinion
        private Dictionary<string, double> prices = new Dictionary<string, double>() {
            {"Oil Change", 26.00 },
            {"Lube Job", 18.00 },
            {"Radiator Flush", 30.00 },
            {"Transmission Flush", 80.00 },
            {"Inspection", 15.00 },
            {"Muffler Replacement", 100.00 },
            {"Tire Rotation", 20.00 }
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //onclick function for exit button, calls the close function
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        //function to calculate charges from the oil and lube group checkboxes
        //if checked, the dictionary is checked with the key corresponding to the service
        //if price is found, price is added to a running total and then returned
        private double OilLubeCharges()
        {
            double total = 0;
            if (oilCheckBox.Checked)
            {
                total += prices["Oil Change"];
            }
            if (lubeCheckBox.Checked)
            {
                total += prices["Lube Job"];
            }
            return total;
        }

        //function to calculate charges from the flushes group checkboxes
        //if checked, the dictionary is checked with the key corresponding to the service
        //if price is found, price is added to a running total and then returned
        private double FlushCharges()
        {
            double total = 0;
            if (radFlushCheckBox.Checked)
            {
                total += prices["Radiator Flush"];
            }
            if (transFlushCheckBox.Checked)
            {
                total += prices["Transmission Flush"];
            }
            return total;
        }

        //function to calculate charges from the misc group checkboxes
        //if checked, the dictionary is checked with the key corresponding to the service
        //if price is found, price is added to a running total and then returned
        private double MiscCharges()
        {
            double total = 0;
            if (inspectionCheckBox.Checked)
            {
                total += prices["Inspection"];
            }
            if (mufflerCheckBox.Checked)
            {
                total += prices["Muffler Replacement"];
            }
            if (tireRotationCheckBox.Checked)
            {
                total += prices["Tire Rotation"];
            }
            return total;
        }

        //function to calculate charges from the other group checkboxes
        //if checked, the dictionary is checked with the key corresponding to the service
        //if price is found, price is added to a running total and then returned
        private double OtherCharges()
        {
            double total = 0;
            //checking to make sure that the user entered something and if they did, it is a parsable value
            if (!string.IsNullOrWhiteSpace(partsTextBox.Text) && double.TryParse(partsTextBox.Text, out _))
            {
                total += double.Parse(partsTextBox.Text);
            }
            if (!string.IsNullOrWhiteSpace(laborTextBox.Text) && double.TryParse(laborTextBox.Text, out _))
            {
                total += double.Parse(laborTextBox.Text);
            }
            return total;
        }

        //function to calculate charges from the summary group checkboxes
        //if checked/populated, the dictionary is checked with the key corresponding to the service
        //if price is found, price is added to a running total and then returned
        private double TaxCharges()
        {
            double total = 0;
            if (!string.IsNullOrWhiteSpace(partsTextBox.Text) && double.TryParse(partsTextBox.Text, out _))
            {
                total += (double.Parse(partsTextBox.Text) * salesTax);
            }
            return total;
        }

        //using all our functions we made to calculate charges, we get the total charges
        private double TotalCharges()
        {
            double total = 0;
            total += OilLubeCharges();
            total += FlushCharges();
            total += MiscCharges();
            total += OtherCharges();
            total += TaxCharges();
            return total;
        }

        //function to clear the oil and lube group checkboxes
        private void ClearOilLube()
        {
            oilCheckBox.Checked = false;
            lubeCheckBox.Checked = false;
        }

        //function to clear the flushes group checkboxes
        private void ClearFlushes()
        {
            transFlushCheckBox.Checked = false;
            radFlushCheckBox.Checked = false;
        }

        //function to clear the misc group checkboxes
        private void ClearMisc()
        {
            inspectionCheckBox.Checked = false;
            tireRotationCheckBox.Checked = false;
            mufflerCheckBox.Checked = false;
        }

        //function to clear the other group textboxes
        private void ClearOther()
        {
            laborTextBox.Text = "";
            partsTextBox.Text = "";
        }

        //function to clear the summary group textboxes
        private void ClearFees()
        {
            serviceLaborTextBox.Text = "";
            totalTextBox.Text = "";
            partsTotalTextBox.Text = "";
            taxTextBox.Text = "";
        }

        //onclick function for the clear button. this calls all the clear functions above
        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearOilLube();
            ClearFlushes();
            ClearMisc();
            ClearOther();
            ClearFees();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {

            //this is calculating the cost of JUST the parts so we can subtract it from the services and labor total
            double partsVal;
            if (!string.IsNullOrWhiteSpace(partsTextBox.Text) && double.TryParse(partsTextBox.Text, out _))
            {
                partsVal = double.Parse(partsTextBox.Text);
            }
            else
            {
                partsVal = 0;
            }

            //using our functions to display the final outputs with a string format to round the doubles to 2 decimal places
            serviceLaborTextBox.Text = String.Format("{0:0.##}", (OilLubeCharges() + FlushCharges() + MiscCharges() + OtherCharges()) - partsVal);
            partsTotalTextBox.Text = String.Format("{0:0.##}",partsVal.ToString());
            taxTextBox.Text = String.Format("{0:0.##}", TaxCharges());
            totalTextBox.Text = String.Format("{0:0.##}", TotalCharges());
             
        }

        private void serviceLaborTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
