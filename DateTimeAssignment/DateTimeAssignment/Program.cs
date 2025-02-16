using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DATETIME ASSIGNMENT");

            Console.WriteLine("1. Formatting DateTime\r\nProblem:\r\nWrite a program that prints the current date and time in the following formats:\r\n yyyy-MM-dd HH:mm:ss\r\n MM/dd/yyyy\r\n dddd, dd MMMM yyyy\r\nExpected Output (example):\r\n2025-02-14 15:30:00\r\n02/14/2025\r\nFriday, 14 February 2025\r\n");
            DateTime dt = DateTime.Now;
            Console.WriteLine("Solution:");
            Console.WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss"));
            Console.WriteLine(dt.ToString("MM/dd/yyyy"));
            Console.WriteLine(dt.ToString("dddd"));
            Console.WriteLine(dt.ToString("dd MMMM yyyy"));
            Console.WriteLine();


            Console.WriteLine("2. Adding and Subtracting Time\r\nProblem:\r\nWrite a program to:\r\n1. Print today’s date.\r\n2. Add 10 days to the current date and display the new date.\r\n3. Subtract 5 hours from the current time and display the result.\r\n");
            DateTime dt2 = DateTime.Now;
            Console.WriteLine("Solution:");
            Console.WriteLine("Today's date : "+dt2.ToString("MM/dd/yyyy"));
            Console.WriteLine("After 10 days date : " + dt2.AddDays(10).ToString("MM/dd/yyyy"));
            Console.WriteLine("Today's Time : " + dt2.ToString("HH:mm:ss"));
            Console.WriteLine("After 5 hours time : " + dt2.AddHours(5).ToString("HH: mm:ss"));
            Console.WriteLine();
            Console.WriteLine("3. Parsing Dates");
            Console.WriteLine("Problem:");
            Console.WriteLine("Given a string dateString = \"14-Feb-2025\", convert it into a DateTime object using DateTime.Parse().");
            Console.WriteLine("Print the parsed date.");
            Console.WriteLine("Also, use DateTime.TryParse() to ensure no errors occur if the string format is invalid.\n");

            Console.WriteLine("Solution:");
            Console.WriteLine("Enter date in format: 14-Feb-2025");
            string date = Console.ReadLine();

            try
            {
                DateTime dt3 = DateTime.Parse(date);
                Console.WriteLine("Using Normal Parse: " + dt3);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid date format using DateTime.Parse()");
            }

            Console.WriteLine("Using TryParse:");
            if (DateTime.TryParse(date, out DateTime safedt3))
            {
                Console.WriteLine("Parsed date is: " + safedt3);
            }
            else
            {
                Console.WriteLine("Invalid date format using DateTime.TryParse()");
            }

            Console.WriteLine();
        

        Console.WriteLine("4. Comparing Dates\r\nProblem:\r\nCreate two DateTime objects:\r\n date1 = 2025-02-14\r\n date2 = 2025-02-20\r\nCompare the two dates and print whether date1 is earlier, later, or the same as date2");
            DateTime dt41 = new DateTime(2025,02,14);
            DateTime dt42 = new DateTime(2025, 02, 20);
            Console.WriteLine("Solution:");
            if (dt41 < dt42)
            {
                Console.WriteLine(dt41 + " is earlier");
            }
            else if (dt41 > dt42)
            {
                Console.WriteLine(dt41 + " is later");
            }
            else
            {
                Console.WriteLine("They are equal");
            }

                Console.WriteLine();

            Console.WriteLine("5. Calculating the Difference Between Two Dates\r\nProblem:\r\nWrite a program that calculates the number of days between two dates:\r\n Start date: 2025-01-01\r\n End date: 2025-02-14\r\nPrint the difference in days.\r\n");
            DateTime dt51 = new  DateTime(2025, 01, 01);
            DateTime dt52 = new DateTime(2025,02,14);
            Console.WriteLine("Solution:");
            if (dt51 > dt52)
            {
                Console.WriteLine("Difference in days is " + (dt51 - dt52).Days);
            }
            else
            {
                Console.WriteLine("Difference in days is " + (dt52 - dt51).Days);
            }
        
            Console.WriteLine();


            Console.WriteLine("6. Extracting Date and Time Components\r\nProblem:\r\nPrint the following components of the current date and time:\r\n Year\r\n Month\r\n Day\r\n Hour\r\n Minute\r\n Second\r\n");
            DateTime dt6 = DateTime.Now;
            Console.WriteLine("Solution:");
            Console.WriteLine("Year :"+dt.Year);
            Console.WriteLine("Month :" + dt.Month);
            Console.WriteLine("Day :" + dt.Day);
            Console.WriteLine("Hour :" + dt.Hour);
            Console.WriteLine("Minutes :" + dt.Minute);
            Console.WriteLine("Seconds :" + dt.Second);
            Console.WriteLine();

            Console.WriteLine("7. Time Zones and UTC Conversion\r\nProblem:\r\n1. Print the current local date and time.\r\n2. Convert it to UTC using ToUniversalTime() and print the result.\r\n\r\n");
            DateTime dt7 = DateTime.Now;
            Console.WriteLine("Solution:");
            Console.WriteLine("Local time is " + dt7);
            Console.WriteLine("UTC time is " + dt7.ToUniversalTime());
            Console.WriteLine();

            Console.WriteLine("8. Checking Leap Year\r\nProblem:\r\nWrite a program that checks if a given year (e.g., 2024) is a leap year using DateTime.IsLeapYear().\r\n");
            Console.WriteLine("Enter year to check whether it is leap year or not");
            int yr=int.Parse(Console.ReadLine());
            Console.WriteLine(DateTime.IsLeapYear(yr));
            Console.WriteLine();

            Console.WriteLine("9. Display the First and Last Day of the Month\r\nProblem:\r\nWrite a program that takes any date as input and displays the first and last day of that month.\r\n");
            Console.WriteLine("Enter date in yyyy-MM-dd format");
            string inp = Console.ReadLine();
            if (DateTime.TryParse(inp, out DateTime dat)) {

                DateTime firstDay = new DateTime(dat.Year, dat.Month, 1);
                Console.WriteLine("First day of month "+firstDay);
                Console.WriteLine("Last day of month "+ firstDay.AddMonths(1).AddDays(-1));
            }
            else
            {
                Console.WriteLine("Invalid format");   
            }
            Console.WriteLine();

            Console.WriteLine("10. Add a Specific Time Duration\r\nProblem:\r\nWrite a program that adds a TimeSpan of 2 hours, 30 minutes to the current time and prints the\r\nresult.\r\n");
            DateTime dt10 = DateTime.Now;
            Console.WriteLine("Solution:");
            Console.WriteLine("After adding 2 hr and 30 min to current time is "+dt10.AddHours(2).AddMinutes(30));
            Console.WriteLine();


            Console.WriteLine("11. Countdown Timer\r\nProblem:\r\nGiven a future date (e.g., \"2025-12-31\"), calculate the number of days, hours, and minutes remaining\r\nuntil that date.");
            Console.WriteLine("Enter future date in yyyy-MM-dd format");

            string inputdate=Console.ReadLine();
            if (DateTime.TryParse(inputdate, out DateTime result))
            {
                DateTime currdate = DateTime.Now;
                TimeSpan remaining = result - currdate;
                Console.WriteLine("Remaining days " +remaining.Days);
                Console.WriteLine("Remaining hours " +remaining.Hours);
                Console.WriteLine("Remaining minutes " +remaining.Minutes);
            }
            else
            {
                Console.WriteLine("Invalid format");
            }
            
            Console.WriteLine();
        }

    }
}
