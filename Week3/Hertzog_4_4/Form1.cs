using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hertzog_4_4
{
    public partial class Form1 : Form
    {
        //Two global variables used to track which color is selected. not entirely necessary but I liked this method.
        string color1;
        string color2;

        public Form1()
        {
            InitializeComponent();
        }

        //once the radio button is checked, it sets the color1 var to red
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            color1 = "Red";
        }
        //function for onclick of exit button
        //this closes the window

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MixButton_Click(object sender, EventArgs e)
        {
            //Function that takes care of the background color switch logic

            //3 main if statements to account for first color button
            //each if statement has a switch case to check for the second radio button and then changes the background color accordingly
            if(color1 == "Red")
            {
                switch (color2)
                {
                    case "Red":
                        this.BackColor = Color.Red;
                        break;
                    case "Blue":
                        this.BackColor = Color.Purple;
                        break;
                    case "Yellow":
                        this.BackColor = Color.Orange;
                        break;
                }

            }
            else if (color1 == "Blue")
            {
                switch (color2)
                {
                    case "Red":
                        this.BackColor = Color.Purple;
                        break;
                    case "Blue":
                        this.BackColor = Color.Blue;
                        break;
                    case "Yellow":
                        this.BackColor = Color.Green;
                        break;
                }

            }
            else if (color1 == "Yellow")
            {
                switch (color2)
                {
                    case "Red":
                        this.BackColor = Color.Orange;
                        break;
                    case "Blue":
                        this.BackColor = Color.Green;
                        break;
                    case "Yellow":
                        this.BackColor = Color.Yellow;
                        break;
                }

            }
        }

        //once the radio button is checked, it sets the color1 var to blue
        private void BlueButton1_CheckedChanged(object sender, EventArgs e)
        {
            color1 = "Blue";
        }

        //once the radio button is checked, it sets the color1 var to yellow
        private void YellowButton1_CheckedChanged(object sender, EventArgs e)
        {
            color1 = "Yellow";
        }

        //once the radio button is checked, it sets the color1 var to red
        private void RedButton2_CheckedChanged(object sender, EventArgs e)
        {
            color2 = "Red";
        }

        //once the radio button is checked, it sets the color1 var to blue
        private void BlueButton2_CheckedChanged(object sender, EventArgs e)
        {
            color2 = "Blue";
        }

        //once the radio button is checked, it sets the color1 var to yellow
        private void YellowButton2_CheckedChanged(object sender, EventArgs e)
        {
            color2 = "Yellow";
        }
    }
}
