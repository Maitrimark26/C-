using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OverLoadingAssignment
{
    internal class Que1BookTickets
    {
        public void BookTicket(string name,string destination)
        {
            if (name == null || name.Length == 0)
            {
                Console.WriteLine("Name cannot be null.");
                return;
            }

            else if (destination == null || destination.Length == 0)
            {
                Console.WriteLine("Destination cannot be null.");
                return;
            }
            else
            {
                Console.WriteLine($"Congratulations , {name} your ticket have been successfully booked for {destination}.");
            }
        }
        public void BookTicket(string name, string destination,string type)
        {
            if (name == null || name.Length == 0)
            {
                Console.WriteLine("Name cannot be null.");
                return;
            }

            else if (destination == null || destination.Length == 0)
            {
                Console.WriteLine("Destination cannot be null.");
                return;
            }
            else if (!type.ToLower().Equals("economy") && !type.ToLower().Equals("business"))
            {
                Console.WriteLine("Type should be either 'Economy' or 'Business'.");
                return;
            }
            else
            {
                Console.WriteLine($"Congratulations , {name} your ticket have been successfully booked for {destination.ToLower()} with {type} class.");
            }
            
        }
        public void BookTicket(string[] passengers, string destination)
        {
            if (destination == null || destination.Length == 0)
            {
                Console.WriteLine("Destination cannot be null.");
                return;
            }
            foreach (string passenger in passengers)
            {
                Console.WriteLine($"Congratulations , {passenger} your ticket have been successfully booked for {destination}.");
            }
        }
    }
}
