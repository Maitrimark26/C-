using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoadingAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Que1
            //Console.WriteLine("Welcome to ticket booking system");
            //Que1BookTickets que1BookTickets = new Que1BookTickets();
            //Console.WriteLine("Enter name and destination");
            //string name=Console.ReadLine();
            //string destination = Console.ReadLine();
            //que1BookTickets.BookTicket(name, destination);
            //Console.WriteLine("Enter name and destination and type (Economy/business)");
            //string name1 = Console.ReadLine();
            //string destination1 = Console.ReadLine();
            //string type = Console.ReadLine();
            //que1BookTickets.BookTicket(name1, destination1,type);
            //Console.WriteLine("For multiple booking enter the names of passengers you want to book tickets with");
            //string[] passengers = Console.ReadLine().Split(',');
            //Console.WriteLine("Enter destination where you want to go");
            //string destination2 = Console.ReadLine();
            //que1BookTickets.BookTicket(passengers,destination2);

            //Que2

            //Bank bank = new Bank();
            //Console.WriteLine("Bank Loan Interest Calculation");

            //// 1. Personal Loan
            //Console.WriteLine("\n1.Personal Loan Calculation");
            //Console.Write("Enter Principal Amount: Rs");
            //double principal = Double.Parse(Console.ReadLine());

            //Console.Write("Enter Interest Rate (%): ");
            //double rate = Double.Parse(Console.ReadLine());

            //Console.Write("Enter Duration (Years): ");
            //int years = int.Parse(Console.ReadLine());

            //bank.CalculateInterest(principal, rate, years);


            //Console.WriteLine("\n2.Home Loan Calculation with Discount");
            //Console.Write("Enter Discount Rate (%): ");
            //double discountRate = Double.Parse(Console.ReadLine());

            //bank.CalculateInterest(principal, rate, years, discountRate);

            //// 3. Custom Loan with Extra Parameters
            //Console.WriteLine("\n3. Custom Loan Calculation with Extra Parameters");
            //Console.Write("Enter Processing Fee (₹): ");
            //double processingFee = Double.Parse(Console.ReadLine());

            //Console.Write("Enter Tenure (Months): ");
            //int tenureInMonths = int.Parse(Console.ReadLine());

            //bank.CalculateInterest(principal, rate, years, processingFee, tenureInMonths);

            //Console.WriteLine("Fare ride calculations");
            //while (true)
            //{
            //    Console.WriteLine("Enter\n 1 for regular ride\n 2 for premium ride\n 3 for sharing ride\n 4 for exit");

            //    int inp = int.Parse(Console.ReadLine());
            //    if (inp == 4) break;
            //    if (inp == 1)
            //    {
            //        Ride r1 = new Ride();
            //        Console.WriteLine("Enter Distance (km)");
            //        double distance = Double.Parse(Console.ReadLine());
            //        Console.WriteLine("Enter rate");
            //        double rate = Double.Parse(Console.ReadLine());
            //        r1.CalculateFare(distance, rate);

            //    }
            //    else if (inp == 2)
            //    {
            //        Ride r2 = new Ride();
            //        Console.WriteLine("Enter Distance (km)");
            //        double distance = Double.Parse(Console.ReadLine());
            //        Console.WriteLine("Enter rate");
            //        double rate = Double.Parse(Console.ReadLine());
            //        Console.WriteLine("Enter multiplier");
            //        double multiplier = Double.Parse(Console.ReadLine());
            //        r2.CalculateFare(distance, rate, multiplier);

            //    }
            //    else if (inp == 3) 
            //        {
            //            Ride r3 = new Ride();
            //            Console.WriteLine("Enter Distance (km)");
            //            double distance = Double.Parse(Console.ReadLine());
            //            Console.WriteLine("Enter rate");
            //            double rate = Double.Parse(Console.ReadLine());

            //            Console.WriteLine("Enter number of people sharing ride");
            //            int people = int.Parse(Console.ReadLine());
            //            r3.CalculateFare(distance, rate, people);
            //        }
            //    else {
            //            Console.WriteLine("Invalid input");
            //        }
            //    }

            //Que4


            ChatBot chatbot = new ChatBot();
            string query = "";
            // 1. Basic Query
            Console.WriteLine("Basic Query Test:");
            Console.WriteLine("Enter query");
            query=Console.ReadLine();
            chatbot.RespondToQuery(query);

            // 2. Priority Query
            Console.WriteLine("Priority Query Test:");
            Console.WriteLine("Enter query");
            query = Console.ReadLine();
            Console.WriteLine("Enter true for urgent query and false for normal query");
            bool choice = bool.Parse(Console.ReadLine());
            chatbot.RespondToQuery(query, choice);

            // 3. Multi-language Query
            Console.WriteLine("Multi-language Query Test:");
            Console.WriteLine("Enter query");
            query = Console.ReadLine();
            Console.WriteLine("Enter language model code (en, es, fr, de)");
            string code = Console.ReadLine();
            chatbot.RespondToQuery(query, code);

        } }
    }

