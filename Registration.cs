using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2
{
    class Registration
    {
        private Flight flight { get; set; }

        private Train train { get; set; }

        private Passenger passenger { get; set; }

        private Ticket ticket { get;  set; }

        public Registration(Flight flight, Train train, Passenger passenger, Ticket ticket)
        {
            this.flight = flight;
            this.train = train;
            this.passenger = passenger;
            this.ticket = ticket;
        }

        public override string ToString()
        {
            return flight.ToString() + "\n" + train.ToString() + "\n" + passenger.ToString() + "\n" + ticket.ToString();
        }
    }
}
