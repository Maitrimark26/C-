using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityBill
{
    class Bill
    {
        int NoUnits = 0;
        public Bill(int Units)
        {
            NoUnits = Units;
        }
        int tot = 0;
         internal int Cost()
        {
            if (NoUnits > 0 && NoUnits <= 100)
            {
                tot=NoUnits*2;
                return tot;
            }
            else if (NoUnits >= 101 && NoUnits <= 200)
            {
                tot = 100 * 2 + (NoUnits - 100) * 4;
                return tot;
            }
            else if (NoUnits >= 201 && NoUnits <= 300)
            {
                tot = 100 * 2 + (100) * 4 + (NoUnits - 200) * 6;
                return tot;
            }
            else
            {
                tot = 100 * 2 + (100) * 4 + (100) * 6+(NoUnits-300)*12;
                return tot;
            }
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******WELCOME TO ELECTRICITY BILL******");
            Console.WriteLine("Please Enter number of units");
            int NoUniits = Convert.ToInt32(Console.ReadLine());
            Bill B = new Bill(NoUniits);
            Console.WriteLine("Your Total Bill is : "+B.Cost());

        }
    }
}
