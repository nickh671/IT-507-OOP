using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hertzog_4_12
{
    //Class for locations
    class Location
    {
        public string name { get; set; }
        public double fee { get; set; }

        public Location()
        {

        }

        public Location(string name, double fee)
        {
            this.name = name;
            this.fee = fee;
        }
    }
}
