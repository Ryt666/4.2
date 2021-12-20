using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2
{
    public class Passenger
    {
        private string FirstName { get; set; }
        
        private string LastName { get; set; }
        
        public Passenger(string first, string last)
        {
            this.FirstName = first;
            this.LastName = last;
        }
        
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
