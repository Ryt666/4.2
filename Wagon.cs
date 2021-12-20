using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2
{
    public class Wagon
    {
        private int Seats { get; set; }

        public bool[] Places { get; set; }
        
        public WagonType Type { get;  set; }
        
        public Wagon(int number, int seats, WagonType type)
        {
            this.Seats = seats;
            Places = new bool[seats];
            this.Type = type;
        }

        public Wagon(Wagon W)
        {
            this.Seats = W.Seats;
            Places = W.Places;
            this.Type = W.Type;
        }

        public override string ToString()
        {
            return "Count_seats: " + this.Seats;
        }
        
        public void print()
        {
            Console.WriteLine("Свободные места: ");
            for(int i = 0; i < this.Seats; i++)
            {
                if (!this.Places[i]) Console.Write(i + 1 + " ");
            }
            Console.WriteLine();
        }
        
        public void reservation(int i)
        {
            Places[i] = true;
        }
    }
}
