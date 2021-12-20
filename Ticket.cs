using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2
{
    public class Ticket
    {
        private string Ticket_number { get; set; }

        private int Price { get; set; }
        
        private int Count { get; set; }
        
        private double Sale { get; set; }
        
        public Ticket(string number, int price, int count, double sale)
        {
            this.Ticket_number = number;
            this.Price = price;
            this.Count = count;
            this.Sale = sale;
        }
        
        public override string ToString()
        {
            return "№" + Ticket_number + " - " + Cost();
        }
        
        public double Cost()
        {
            return Price * Count * Sale;
        }
    }
}
