using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hertzog_4_12
{
    public partial class Form1 : Form
    {
        //global lists to hold all the info about workshops and locations
        private List<Workshop> workshops = new List<Workshop>();
        private List<Location> locations = new List<Location>();


        public Form1()
        {
            BuildLocations();
            BuildWorkshops();
            InitializeComponent();
        }

        //building the workshops list
        private void BuildWorkshops()
        {
            List<string> names = new List<string> { "Handling Stress", "Time Management", "Supervision Skills", "Negotiation", "How to Interview" };
            List<int> days = new List<int> { 3, 3, 3, 5, 1 };
            List<double> fees = new List<double> { 1000, 800, 1500, 1300, 500 };

            for(int i = 0; i < names.Count; i++)
            {
                workshops.Add(new Workshop(names[i], days[i], fees[i]));
            }
        }

        //building the locations list
        private void BuildLocations()
        {
            List<string> names = new List<string> { "Austin", "Colorado", "Dallas", "Orlando", "Phoenix", "Raleigh" };
            List<double> fees = new List<double> { 150, 225, 175, 300, 175, 150 }; 

            for (int i = 0; i < names.Count; i++)
            {
                locations.Add(new Location(names[i], fees[i]));
            }
        }

        //onclick function for the button
        private void S_Click(object sender, EventArgs e)
        {
            string locName = locationListBox.SelectedItem.ToString();
            string workName = workshopListBox.SelectedItem.ToString();
            calculate(locName, workName);
        }

        //function to calculate
        private void calculate(string locName, string workName)
        {
            //variables to hold our workshop and location we are attending
            Workshop ws = new Workshop();
            Location loc = new Location();

            //loop to find the right workshop from the list and save to ws
            for (int i = 0; i < workshops.Count; i++)
            {
                if(workshops[i].name == workName)
                {
                    ws = workshops[i];
                }
            }

            //loop to find the right location from the list and save to loc
            for (int i = 0; i < locations.Count; i++)
            {
                if(locations[i].name == locName)
                {
                    loc = locations[i];
                }
            }

            //do our calculations
            double registration = ws.fee;
            double lodging = loc.fee * ws.days;
            double total = registration + lodging;

            //build a string and show it in a message box
            string result = "Registration: $" + registration.ToString() + "\nLodging: $" + lodging.ToString() + "\nTotal: $" + total.ToString();
            MessageBox.Show(result);
        }
    }
}
