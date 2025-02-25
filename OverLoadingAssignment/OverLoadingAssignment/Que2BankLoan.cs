using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2.Bank Loan Interest Calculation
//Scenario: A bank offers different types of loans with varying interest rates.
//•	Overload CalculateInterest() to: 
//1.Calculate interest for a personal loan
//2.	Calculate interest for a home loan with a special discount
//3.	Calculate interest for a custom loan with extra parameters

namespace OverLoadingAssignment
{

    internal class Bank
    {
       public void CalculateInterest(double principal,double rate,int years)
        {
            double Interest = (principal * rate * years) / 100;
            Console.WriteLine($"For a principal amount of Rs. {principal} with rate {rate} % and time {years} years , final interest is Rs. {Interest}");
        }
        public void CalculateInterest(double principal, double rate, int years,double discount)
        {
            double FinalRate=rate-discount;
            if (FinalRate <0)
            {
                FinalRate = 0;
            }
            double interest = (principal * FinalRate * years) / 100;
            Console.WriteLine($"For a principal amount of Rs. {principal} with rate {rate} % and time {years} years and discount rate {discount} % , final interest is Rs. {interest}");
        }
        public void CalculateInterest(double principal, double rate, int years, double processingFee,int tenure)
        {
            double Interest=(principal*rate*years)/100;
            double TenureInterest = processingFee * (tenure / 12.0);   
            Console.WriteLine($"For a principal amount of Rs. {principal} with rate {rate} % and time {years} years and with processing fee of Rs. {processingFee} and tenure {tenure} months , final interest is Rs. {Interest+TenureInterest}");
        }
    }
}
