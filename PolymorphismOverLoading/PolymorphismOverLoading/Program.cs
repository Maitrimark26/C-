using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PolymorphismOverLoading
{
    class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public double Add(double x, double y, double z)
        {
            return x + y + z;
        }
        public int Add(int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;
            }
            return sum;
        }
    }
    class Shape
    {
        const double pi = 3.14;
        public double Area(double r)
        {
            return pi * r * r;
        }
       public  double Area(double length, double width)
        {
            return length * width;
        }
        public double Area(float height, float Base) {
            return 0.5 * height * Base;
        }
    }
    class Employee
    {
        string name;
        int age;
        public Employee()
        {
            name = "Unknown";
            Console.WriteLine("A default constructor that initializes an employee with default values (e.g., \"Unknown\" for the name) is called.");
            Console.WriteLine($"name is {name}");
            Console.WriteLine($"age is {age}\n");
        }
       public Employee(string name)
        {
            this.name = name;
            Console.WriteLine("A constructor that accepts only the employee's name is called.");
            Console.WriteLine($"name is {name}");
            Console.WriteLine($"age is {age} \n");
        }
       public Employee(string name,int age)
        {
            this.name = name;
            this.age = age;
            Console.WriteLine("A constructor that accepts both the name and age of the employee is called");
            Console.WriteLine($"name is {name}");
            Console.WriteLine($"age is {age}\n");
        }
    }
    class Book
    {
         string BookTitle;
         string Author;
         int Price;
        public Book(string title)
        {
            BookTitle = title;
            Console.WriteLine("Constructor with only one parameter is called");
            Console.WriteLine($"Book Title is {BookTitle}");
            Console.WriteLine($"Author is {Author}");
            Console.WriteLine($"Price is {Price} \n");
            
        }
        public Book(string title, string author)
        {
            BookTitle = title;
            Author = author;
            Console.WriteLine("Constructor with two parameter is called");
            Console.WriteLine($"Book Title is {BookTitle}");
            Console.WriteLine($"Author is {Author}");
            Console.WriteLine($"Price is {Price} \n");
        }
        public Book(string title, string author,int price)
        {
            BookTitle = title;
            Author = author;
            Price = price;
            Console.WriteLine("Constructor with three parameter is called");
            Console.WriteLine($"Book Title is {BookTitle}");
            Console.WriteLine($"Author is {Author}");
            Console.WriteLine($"Price is {Price} \n");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Problem Statement: Calculator with Multiple Add Methods\r\nTask: Create a Calculator class with an Add method overloaded for different input types.\r\n•\tRequirement:\r\no\tOne method should take two integers and return their sum.\r\no\tAnother method should take three doubles and return their sum.\r\no\tA third method should take an array of integers and return the sum of all elements.\r\n•\tObjective: Demonstrate how to provide different implementations for the same operation based on parameter types.");
            Calculator c = new Calculator();
            int[] arr = { 11, 52, 33, 15, 36, 94 };
            Console.WriteLine("Addition using method 1 (5+8) = " + c.Add(5, 8));
            Console.WriteLine("Addition using method 2 (15.4 + 8.6 + 9.8) = " + c.Add(15.4, 8.6, 9.8));
            Console.WriteLine("Addition using method 3 [ 11, 52, 33 ,15,36,94] = " + c.Add(arr));
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("2. Problem Statement: Area Calculation for Shapes\r\nTask: Create a Shape class with an overloaded CalculateArea method.\r\n•\tRequirement:\r\no\tOne method should calculate the area of a circle given its radius (Area = π * r²).\r\no\tAnother method should calculate the area of a rectangle given its length and width.\r\no\tA third method should calculate the area of a triangle given its base and height (Area = 0.5  base  height).\r\n•\tObjective: Show how the same method name can be reused for different shapes with varying parameters.\r\n");
            Shape s = new Shape();
            Console.WriteLine("Area of circle : " + s.Area(6.2));
            Console.WriteLine("Area of rectangle : " + s.Area(5.4, 18.6));
            Console.WriteLine("Area of triangle : " + s.Area(2.3, 6));
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("3. Problem Statement: Employee Object Creation\r\nTask: Create an Employee class with overloaded constructors to handle different initialization scenarios.\r\n•\tRequirement:\r\no\tA default constructor that initializes an employee with default values (e.g., \"Unknown\" for the name).\r\no\tA constructor that accepts only the employee's name.\r\no\tA constructor that accepts both the name and age of the employee.\r\n•\tObjective: Demonstrate flexibility in object creation with different levels of initialization.\r\n");
            Employee e = new Employee();
            Employee e1 = new Employee("Maitri");
            Employee e2 = new Employee("Maitri", 22);
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("4. Problem Statement: Book Object with Different Details\r\nTask: Create a Book class with overloaded constructors to handle varying levels of detail.\r\n•\tRequirement:\r\no\tA constructor that initializes only the book title.\r\no\tA constructor that initializes the title and author.\r\no\tA constructor that initializes the title, author, and price.\r\n•\tObjective: Show how to create objects with different sets of data using constructor overloading.");
            Book b = new Book("The faults in our stars");
            Book b1 = new Book("The faults in our stars", "John Green");
            Book b2 = new Book("The faults in our stars", "John Green", 200);
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");

        }

    }
}
