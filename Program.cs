using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Flight flight = new Flight("Гродно", "Брест", FlightType.Local, new DateTime(2014, 11, 15, 15, 50, 00));

            Train train = new Train(1536);
            Wagon Wagon1 = new Wagon(12569, 50, WagonType.Compartmen);
            Wagon1.reservation(5);
            Wagon1.reservation(18);
            Wagon1.reservation(36);
            Wagon1.reservation(32);
            Wagon1.reservation(15);
            train.Wagons.Add(Wagon1);

            Wagon Wagon2 = new Wagon(79852, 30, WagonType.General);
            Wagon2.reservation(5);
            Wagon2.reservation(8);
            Wagon2.reservation(16);
            Wagon2.reservation(12);
            Wagon2.reservation(1);
            train.Wagons.Add(Wagon2);

            Wagon Wagon3 = new Wagon(32600, 45, WagonType.Second_class);
            Wagon3.reservation(11);
            Wagon3.reservation(1);
            Wagon3.reservation(18);
            Wagon3.reservation(25);
            Wagon3.reservation(36);
            Wagon3.reservation(17);
            train.Wagons.Add(Wagon3);

            Passenger passenger = new Passenger("Потапова", "Аполлинария");

            Ticket ticket = new Ticket("1234566", 25000, 2, 0.5);

            Registration registration = new Registration(flight, train, passenger, ticket);
            Console.WriteLine(registration.ToString());

            train.reservation(WagonType.Second_class, 5);
            Console.ReadKey();
        }
    }
}
