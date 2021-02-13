using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hertzog_5_11
{
    public partial class Form1 : Form
    {
        //counter for guesses and int for random num
        private int guesses = 0;
        private int num;

        public Form1()
        {
            num = getRandom();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //onclick function for the guess button
        //takes user submitted number, compares it against random number and returns the response
        private void guessButton_Click(object sender, EventArgs e)
        {
            //increment guesses
            guesses++;
            guessesTB.Text = guesses.ToString();

            //parsing user input
            int userInput;
            bool isNumeric = Int32.TryParse(numberTB.Text, out userInput);

            //if user input is not a number
            if (!isNumeric)
            {
                MessageBox.Show("Please enter a valid number");
            }
            else
            {
                //if num is less than random
                if(userInput < num)
                {
                    lowLabel.Visible = true;
                    highLabel.Visible = false;
                }
                //if num is more than random
                else if (userInput > num)
                {
                    lowLabel.Visible = false;
                    highLabel.Visible = true;
                }
                //if user guessed correctly
                else
                {
                    //show success message, reset random, reset labels and reset guess counter
                    string result = "You got it!\nNumber of guesses: " + guesses.ToString();
                    MessageBox.Show(result);
                    guesses = 0;
                    guessesTB.Text = guesses.ToString();
                    lowLabel.Visible = false;
                    highLabel.Visible = false;
                    numberTB.Text = "";
                    num = getRandom();
                }
            }
        }

        //get random int between 1 and 100 (inclusive)
        private int getRandom()
        {
            Random rand = new Random();
            return rand.Next(1, 101);
        }
    }
}
