using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2
{
    public class Flight
    {
        private string Initial_station { get;  set; }
        
        private string Terminus { get; set; }
        
        public FlightType Type { get; set; }
        
        private DateTime Time { get; set; }
        
        public Flight(string initial_station, string terminus, FlightType type, DateTime time)
        {
            this.Initial_station = initial_station;
            this.Terminus = terminus;
            this.Type = type;
            this.Time = time;
        }

        public override string ToString()
        {
            return this.Initial_station + " - " + this.Terminus + ": " + this.Time.ToString();
        }
    }
}
