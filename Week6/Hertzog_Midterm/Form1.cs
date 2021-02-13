using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hertzog_Midterm
{
    public partial class Form1 : Form
    {
        //some global variables to make life easier
        int? numBills;
        double? totalBudget;
        string month;
        double billTotal = 0;
        int billCount = 0;

        public Form1()
        {
            InitializeComponent();
            enterBillBtn.Enabled = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void resultGB_Enter(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            //first we need to calculate the number of bills and pull in the other entered information
            //numbills
            numBills = checkValidInt(numBillsTB.Text);
            //month
            month = monthLB.SelectedItem.ToString();
            //totalBudget
            totalBudget = checkValidDouble(totalBudgetTB.Text);

            //IF AN ERROR HAS OCCURED WITH THE USER INPUT, THESE WILL BE NULL
            if(numBills == null || totalBudget == null)
            {
                string error = "";
                if (numBills == null)
                {
                    error += "Please enter a valid number of bills.\n";
                }
                if(totalBudget == null)
                {
                    error += "Please enter a valid number for your total budget.";
                }

                //show the error
                MessageBox.Show(error);

            }
            else
            {
                //if no error, proceed
                //first we will want to disable the number of bills control to prevent any weird errors. Not exactly the most user friendly solution but it will work in this scenario
                submitBtn.Enabled = false;
                enterBillBtn.Enabled = true;
            }

        }
        

        //Function that takes a string, makes sure its a valid int and parses
        //if valid, returns an int, else returns null
        private int? checkValidInt(string text)
        {
            if (String.IsNullOrWhiteSpace(text))
            {
                return null;
            }
            else
            {
                int temp;
                if (Int32.TryParse(text, out temp))
                {
                    return temp;
                }
                else
                {
                    return null;
                }
            }
            
        }

        //Function that takes a string, makes sure its a valid double and parses
        //if valid, returns an double, else returns null
        private double? checkValidDouble(string text)
        {
            if (String.IsNullOrWhiteSpace(text))
            {
                return null;
            }
            else
            {
                double temp;
                if (double.TryParse(text, out temp))
                {
                    return temp;
                }
                else
                {
                    return null;
                }
            }
        }

        private void enterBillBtn_Click(object sender, EventArgs e)
        {
            if(billCount < numBills)
            {
                //first check if the amount entered is valid
                double? temp = checkValidDouble(billTB.Text);

                if (temp == null)
                {
                    MessageBox.Show("Please enter a valid amount.");
                }
                else
                {
                    //increment our counter to track how many bills have been entered
                    billCount++;
                    //add the amount of the running total
                    //this is using syntax to convert the nullable double to a standard double
                    billTotal += temp ?? default(double);
                }

                //resetting the text after finished
                billTB.Text = null;

                //incase of this being the last bill, we want to disable the button so user can no longer enter bills
                if(billCount == numBills)
                {
                    enterBillBtn.Enabled = false;
                    //navigate to function to display results
                    displayResult();
                }
            }
                
        }

        //function used to take all our information and populate into the correct UI place
        private void displayResult()
        {
            monthTB.Text = month;
            resultBudgetTB.Text = totalBudget.ToString();
            resultNumBillsTB.Text = numBills.ToString();
            totalSpentTB.Text = billTotal.ToString();
            if(billTotal > totalBudget)
            {
                verdictTB.Text = "Over budget";
                verdictTB.BackColor = Color.Red;
            }
            else if(billTotal < totalBudget)
            {
                verdictTB.Text = "Under Budget";
                verdictTB.BackColor = Color.Green;
            }
            else
            {
                verdictTB.Text = "Broke Even";
                verdictTB.BackColor = Color.LightGray;
            }


        }
    }
}
