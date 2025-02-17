using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Employee
    {
        public string Name {get; set;}
        public int EmployeeId { get;  }
        public decimal  Salary { get; private set; }
        public string Designation { get; set; }

        public Employee(string name, int employeeId, decimal salary, string designation)
        {
            Name = name;
            EmployeeId = employeeId;
            Salary = salary;
            Designation = designation;
        }
        public void UpdateSalary(decimal newSalary)
        {
            if (newSalary <= 0)
            {
                Console.WriteLine("Enter positive number");
                return;
            }
            Salary = newSalary;
            Console.WriteLine($"Salary updated successfully . Updated salary is {Salary}");
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Details");
            Console.WriteLine($"Name is {Name}");
            Console.WriteLine($"Employee Number is {EmployeeId}");
            Console.WriteLine($"Salary is {Salary}");
            Console.WriteLine($"Designation is {Designation}");
        }

        
    }
    class BankAccount
    {
        public  string AccountNumber { get; }
        public string AccountHolderName { get; }
        public double Balance { get; private set; }


        public BankAccount(string accountNumber,string accountHolderName,double balance)
        {
            this.AccountNumber = accountNumber;
            this.AccountHolderName = accountHolderName;
            this.Balance = balance;
        }

        public void Deposit(double amt)
        {
            if (amt <= 0)
            {
                Console.WriteLine("Entered amt is negative");
                return;
            }
            this.Balance += amt;

            Console.WriteLine($"Your updated balance after deposit is {Balance}");
        }

        public void Withdraw(double amt)

        {
            if (amt <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive.");
                return;
            }
            if (amt > Balance)
            {
                Console.WriteLine("Insufficient balance.");
            }
            else
            {
                Balance -= amt;
                Console.WriteLine($"Your updated balance after withdraw is {Balance}");
            }
        }

        public void Display()
        {
            Console.WriteLine(AccountHolderName + " your balance is : " + Balance);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Encapsulation Assignment");
            Console.WriteLine("Problem 1: Bank Account Management\r\nCreate a BankAccount class that encapsulates account details such as accountNumber, accountHolderName, and balance.\r\n•\tRequirements:\r\no\tThe balance field should only be accessible through methods.\r\no\tProvide methods for depositing and withdrawing money.\r\no\tEnsure that withdrawals are not allowed if the balance is insufficient.\r\no\tAdd a method to display the account holder’s name and current balance.\r\nEncapsulation should ensure that no direct modification of balance is possible without using the provided methods.\r\n");
            BankAccount B = new BankAccount("123456789", "Maitri Markandeywar", 1500);
            bool enter = true;
            while (enter)
            {   
                Console.WriteLine("Press 1 to Deposit");
                Console.WriteLine("Press 2 to withdraw");
                Console.WriteLine("Press 3 to display balance");
                Console.WriteLine("Press 4 to exit");
                int inp=int.Parse(Console.ReadLine());
                if (inp == 1)
                {
                    Console.WriteLine("Enter the amount you want to deposit");
                    double amt=double.Parse(Console.ReadLine());
                    B.Deposit(amt);
                }
                else if (inp == 2)
                {
                    Console.WriteLine("Enter the amount you want to withdraw");
                    double amt = double.Parse(Console.ReadLine());
                    B.Withdraw(amt);
                }
                else if (inp == 3)
                {
                    B.Display();
                }
                else if(inp == 4)
                {
                    enter = false;
                }

                }
           

            Console.WriteLine("----------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Problem 2: Employee Management System\r\nDesign an Employee class that encapsulates employee details such as name, employeeId, salary, and designation.\r\n•\tRequirements:\r\no\tAll fields should be private, with public getters and setters for name and designation.\r\no\tEnsure that the salary field can only be modified internally via a method called UpdateSalary(decimal newSalary).\r\no\tAdd a validation to prevent the salary from being set to a negative value.\r\no\tInclude a method DisplayDetails() that shows all employee information.");
            Employee emp = new Employee("Maitri Markandeywar", 101, 50000, "Software Engineer");
            emp.DisplayDetails();
            Console.WriteLine();
            emp.UpdateSalary(60000);
            Console.WriteLine();
            emp.DisplayDetails();

        }
    }
}
