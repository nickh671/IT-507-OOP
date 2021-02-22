using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hertzog_7_7
{
    public partial class Form1 : Form
    {
        //list for the numbers from file and then the changes between years
        List<int> nums = new List<int>();
        List<int> change = new List<int>();

        public Form1()
        {
            InitializeComponent();
            readFile();
            calculateChanges();
        }

        private void avgTB_TextChanged(object sender, EventArgs e)
        {

        }

        //function to calculate the population change between years
        private void calculateChanges()
        {
            //this is something i have been trying to puzzle out
            //unsure if i should add 0 to account for 1950 or not
            //because would the value for 1950 - the value for 1951 count as 1951 or 1950?
            //I have it set up so that value would be for 1951 and 1950 is defaulted to 0
            change.Add(0);

            //looping through each number in the list
            //adding the current index - next index to the change list (using absolute value because we dont care about positive of negative, just the change)
            for(int i = 1; i < (nums.Count - 1); i++)
            {
                change.Add(Math.Abs((nums[i] - nums[i + 1])));
            }

            //three variables used to display data
            int average = calcAvg(change);
            int max = calcMost(change);
            int least = calcLeast(change);

            //data
            display(average, max, least);
        }

        //display function to populate the textboxes in the ui
        private void display(double avg, int most, int least)
        {
            avgTB.Text = avg.ToString();
            greatestTB.Text = most.ToString();
            leastTB.Text = least.ToString();
        }

        //function used to calculate the average across a given list
        //in our case the change list is passed in and the average is returned
        //using integers because there cant be a fraction of a person
        private int calcAvg(List<int> nums)
        {
            //reasoning for count - 1 is to factor in that 0 we added at the start
            //we dont want to keep that 0 in this calculation and have it be throwing off our numbers
            return nums.Sum()/(nums.Count() - 1);
        } 

        //list is passed in
        //finds the year with the least amount of change within a given list
        //returns the index of that value and adds 1950 to it to calculate the year of the change
        private int calcLeast(List<int> nums)
        {

            //in this scenario, I am defaulting to the second value at the first index
            //normally you would want to default to index 0, however, our index 0's value is 0 to account for the year 1950
            //we want to ignore that year so we will be starting at index 1 here.
            int least = nums[1];
            int index = 1;

            //loop through given list
            for(int i = 1; i < nums.Count; i++)
            {
                //if current is less than the least, set least to current
                if(nums[i] < least)
                {
                    least = nums[i];
                    index = i;
                }
            }

            return index + 1950;
        }

        //list is passed in
        //finds the year with the most amount of change within a given list
        //returns the index of that value and adds 1950 to it to calculate the year of the change
        private int calcMost(List<int> nums)
        {
            int max = nums[0];
            int index = 0;
            //loop through list
            for (int i = 1; i < nums.Count; i++)
            {
                //if current is more than max, reset max to current
                if (nums[i] > max)
                {
                    max = nums[i];
                    index = i;
                }
            }

            return index + 1950;
        }


        //function used to read in our txt file
        //hard coded solution because of file path being stored as string
        private void readFile()
        {
            //opening file with given file path and reading those lines into an array of strings
            string fpath = "..\\..\\..\\USPopulation.txt";
            String[] lines = System.IO.File.ReadAllLines(fpath);
            //converting the string array to an integer array
            foreach(String line in lines)
            {
                nums.Add(Int32.Parse(line));
            }

        }
    }
}
