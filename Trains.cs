using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2
{
    public class Train
    {
        private int Train_number { get;  set; }
        
        public List<Wagon> Wagons { get;  set; }
        
        public Train(int number)
        {
            this.Train_number = number;
            Wagons = new List<Wagon>();
        }
        
        public override string ToString()
        {
            return "№" + this.Train_number;
        }

        public void reservation(WagonType type, int number)
        {
             foreach(Wagon wagons in this.Wagons)
             {
                 if (wagons.Type == type)
                 {
                     wagons.print();
                     if (!wagons.Places[number])
                     {
                         wagons.reservation(number);
                         Console.WriteLine("Место зарезервировано!");
                     }
                     else Console.WriteLine("Место не может быть зарезервировано!");
                 }
             }
        }
    }
}
