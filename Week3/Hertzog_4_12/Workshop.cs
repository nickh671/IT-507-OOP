using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hertzog_4_12
{
    //class for workshops
    class Workshop
    {
        public string name { get; set; }
        public int days { get; set; }
        public double fee { get; set; }
        
        public Workshop()
        {

        }

        public Workshop(string name, int days, double fee)
        {
            this.name = name;
            this.days = days;
            this.fee = fee;
        }
    }
}
