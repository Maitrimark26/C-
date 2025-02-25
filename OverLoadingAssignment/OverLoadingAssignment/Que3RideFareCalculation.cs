using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OverLoadingAssignment
{
    internal class Ride
    {
        public void CalculateFare(double distance,double rate)
        {
            Console.WriteLine($"Your total fare for ride is Rs.{distance*rate}");
        }
        public void CalculateFare(double distance, double rate,double multiplier)
        {

            Console.WriteLine($"Your total fare for premium ride is Rs.{distance * rate*multiplier}");
        }
        public void CalculateFare(double distance, double rate,int passengers)
        {
            if (passengers <= 0)
            {
                Console.WriteLine("Passenger count must be greater than 0.");
                return;
            }
            Console.WriteLine($"Your total fare for ride is Rs.{(distance * rate )/passengers}");
        }
    }
}
