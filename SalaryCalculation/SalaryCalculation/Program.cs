using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculation
{
    abstract class AbsTax // Abstract class
    {
        public abstract double CalTax(double ctc);
    }
    class Tax : AbsTax
    {
        //it acts as a policy so no one changes it 
        public sealed override double CalTax(double ctc)
        {

            if (ctc < 400000) { return 0; }
            ctc -= 400000;
            double tax = 0;
            double[] limits = { 400000, 800000, 1200000, 1600000, 2000000, 2400000 }; // Slab limits
            double[] rates = { 0.05, 0.10, 0.15, 0.20, 0.25, 0.30 }; // Corresponding tax rates
            double prevLimit = 0;
            for (int i = 0; i < limits.Length; i++)
            {
                if (ctc > limits[i])
                {
                    // Only calculate tax for the amount within this slab
                    tax += (limits[i] - prevLimit) * rates[i];
                    prevLimit = limits[i];  // Move to next slab
                }
                else
                {
                    // If CTC is within this slab, calculate tax for the remaining amount
                    tax += (ctc - prevLimit) * rates[i];
                    break; // Exit the loop since CTC is within the current slab
                }
            }
            // If CTC exceeds the last slab limit
            if (ctc > limits[limits.Length - 1])
            {
                tax += (ctc - prevLimit) * rates[rates.Length - 1]; // Tax for the amount above the last slab
            }

            return tax;

        }
    }

    internal class Program // concrete class
    {
        static void Main(string[] args)
        {
            bool enter = true;
            while (enter)
            {
                Console.WriteLine("Enter CTC on which tax is supposed to be calculated");
                double ctc = double.Parse(Console.ReadLine());
                ctc -= 75000;
                Console.WriteLine("Your taxable income is "+ctc);
                
                //ways of object creation
             
                // Using new
                Tax person1 = new Tax();

                // Using reflection
                Tax person2 = (Tax)Activator.CreateInstance(typeof(Tax));

                //Using referencing
                Tax person3 = person1;

                //Use any oneway to calculate tax
                double tax = person2.CalTax(ctc);
                

                Console.WriteLine("Taxable Amount before rebate " + tax);
                
                if (ctc <= 1200000)
                {
                    Console.WriteLine("As your income is within 12 lakhs, your tax to be paid is 0");
                    Console.WriteLine("Taxable Amount after rebate: 0");
                    tax = 0;
                }
                else
                {
                    Console.WriteLine("As your income is above 12 lakhs, no rebate is applicable.");
                    double cess = ctc * 0.04;
                    tax += cess;
                }
                double salary = ctc - tax;
                Console.WriteLine("Your inhand salary after tax paid is " + salary);
                Console.WriteLine("Press 0 to exit or 1 to continue");
                if(int.Parse(Console.ReadLine()) == 0)
                {
                    enter = false;
                }
                
            }
            }

        }
    }

