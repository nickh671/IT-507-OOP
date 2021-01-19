using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hertzog_3_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //onclick function for the calculate property tax button
        //this wont catch if a number is entered that is invalid, say with symbols, spaces, or letters
        //You could use some kind of logic with the TryParse method to account for those as well
        private void button1_Click(object sender, EventArgs e)
        {

            //if statement to catch null or empty input values
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                //taking the current input within the text box
                double price = double.Parse(textBox1.Text);

                //finding the proper tax value
                double tax = (price / 100) * .64;

                //building a nice string to print out to the user
                string resultString = "Property tax: " + tax;

                //create message box and show the result string
                MessageBox.Show(resultString);
            }
            else
            {
                //else show error message
                MessageBox.Show("Please enter a value for the property price");
            }

            
        }
    }
}
