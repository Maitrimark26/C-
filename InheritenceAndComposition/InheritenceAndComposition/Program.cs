using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InheritenceAndComposition
{
    //Task 1
    class Vehicle
    {
        protected string LicensePlate;
        protected double MaxSpeed;

        public Vehicle(string licensePlate, double maxSpeed)
        {
            LicensePlate = licensePlate;
            MaxSpeed = maxSpeed;
        }

        public virtual void StartEngine()
        {
            Console.WriteLine("Engine starts.....");
        }
        public virtual void Display()
        {
            Console.WriteLine($"License plate is {LicensePlate}");
            Console.WriteLine($"Maximum speed is {MaxSpeed} km/hr ");
        }
    }
    class Car : Vehicle
    {
        string BrandName;
        int NoOfWheels;
        public Car(string plate, double speed, string brandName, int noOfWheels) : base(plate, speed)
        {

            BrandName = brandName;
            NoOfWheels = noOfWheels;

        }
        public void ChangeGear()
        {
            Console.WriteLine("Gear changed...");
        }
        public void PutSeatBelt()
        {
            Console.WriteLine("Put on seat belt...");
        }
        public override void StartEngine()
        {
            Console.WriteLine("Car engine started...");
        }
        public override void Display()
        {
            Console.WriteLine("vehicle car");
            base.Display();
            Console.WriteLine($"Brand name is {BrandName}");
            Console.WriteLine($"No of wheels is {NoOfWheels}");
        }
    }
    class Moterbike : Vehicle
    {
        string color;
        bool hasSilencer;
        public Moterbike(string plate, double speed, string color, bool hasSilencer) : base(plate, speed)
        {

            this.color = color;
            this.hasSilencer = hasSilencer;
        }
        public override void StartEngine()
        {
            Console.WriteLine("Bike engine started...");
        }
        public void Accelerate()
        {
            Console.WriteLine("Bike accelerated...");
        }
        public override void Display()
        {
            Console.WriteLine("Vehicle moterbike");
            base.Display();
            Console.WriteLine($"Color is {color}");
            Console.WriteLine($"has silencer {hasSilencer}");
        }
    }
    class Bicycle : Vehicle
    {
        int NoOfPeddals;
        public Bicycle(string plate, double speed, int noofpedals) : base(plate, speed)
        {

            this.NoOfPeddals = noofpedals;
        }
        public override void StartEngine()
        {
            Console.WriteLine("Cycle has no engine...");
        }
        public void RingBell()
        {
            Console.WriteLine("Bell rings...");
        }
        public override void Display()
        {
            Console.WriteLine("Vehicle bicycle");
            base.Display();

            Console.WriteLine($"No of peddals is {NoOfPeddals}");
        }
    }
    //Task 2
    class Address
    {
        public string Street { get; }
        public string City { get; }
        public string State { get; }
        public int PostalCode { get; }
        public Address(string street, string city, string state, int postalcode)
        {
            Street = street;
            City = city;
            State = state;
            PostalCode = postalcode;
        }
    }
    class Student
    {
        public string Name { get; }
        public int RollNo { get; }
        private Address Ad;
        public Student(string name, int rollNo, string street, string city, string state, int postalcode)
        {
            Name = name;
            RollNo = rollNo;
            Ad = new Address(street, city, state, postalcode);
        }
        public void Display()
        {
            Console.WriteLine("Student Details\n");
            Console.WriteLine($"Name is {Name}");
            Console.WriteLine($"RollNo is {RollNo}");
            Console.WriteLine($"street is {Ad.Street}");
            Console.WriteLine($"city is {Ad.City}");
            Console.WriteLine($"state is {Ad.State}");
            Console.WriteLine($"postal code is {Ad.PostalCode}");
        }

    }
    //Task 3
    class Suplier
    {
        public string SupName { get; }
        public string Contact { get; }

        public Suplier(string supName, string contact)
        {
            SupName = supName;
            Contact = contact;
        }
    }

    class Product
    {
        public string Name { get; }
        public double Price { get; }
        public string SKU { get; }

        protected Suplier sp { get; }

        public Product(string name, double price, string sKU, Suplier sp)
        {
            Name = name;
            Price = price;
            SKU = sKU;
            this.sp = sp;
        }
    }

    class Electronics : Product
    {
        public int WarrantyPeriod { get; }
        public string BrandName { get; }

        public Electronics(int warrantyPeriod, string brandName, string name, double price, string sku, Suplier s) : base(name, price, sku, s)
        {
            WarrantyPeriod = warrantyPeriod;
            BrandName = brandName;
        }

        public void Display()
        {
            Console.WriteLine("\nProduct details\n");
            Console.WriteLine($"Name is {Name}");
            Console.WriteLine($"Brand Name is {BrandName}");
            Console.WriteLine($"Price is Rs {Price}");
            Console.WriteLine($"Warranty Period is {WarrantyPeriod} year");
            Console.WriteLine($"SKU is {SKU}");
            Console.WriteLine($"Supplier Name {sp.SupName}");
            Console.WriteLine($"Suplier Contact {sp.Contact}\n");
        }
    }

    class Clothing : Product
    {

        public Clothing(string name, double price, string sku, Suplier s) : base(name, price, sku, s)
        {

        }

        public void Display()
        {
            Console.WriteLine("\nProduct details\n");
            Console.WriteLine($"Name is {Name}");
            Console.WriteLine($"Price is Rs {Price}");
            Console.WriteLine($"SKU is {SKU}");
            Console.WriteLine($"Supplier Name {sp.SupName}");
            Console.WriteLine($"Suplier Contact {sp.Contact}\n");
        }
    }

    class Groceries : Product
    {


        public Groceries(string name, double price, string sku, Suplier s) : base(name, price, sku, s)
        {

        }

        public void Display()
        {
            Console.WriteLine("\nProduct details\n");
            Console.WriteLine($"Name is {Name}");
            Console.WriteLine($"Price is Rs {Price}");
            Console.WriteLine($"SKU is {SKU}");
            Console.WriteLine($"Supplier Name {sp.SupName}");
            Console.WriteLine($"Suplier Contact {sp.Contact}\n");
        }
    }

    class Employee
    {
        public string Name { get; }
        public int EmployeeID { get; }
        public double Salary { get; }

        public Employee(string name, int employeeID, double salary)
        {
            Name = name;
            EmployeeID = employeeID;
            Salary = salary;
        }
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Employee ID: {EmployeeID}");
            Console.WriteLine($"Salary: {Salary}");
        }
    }
    class Manager : Employee
    {
        public int Yoe { get; }
        public int NoOfProjectsManaged { get; }
        public Manager(int yoe, int noOfProjectsManaged, string name, int id, double salary) : base(name, id, salary)
        {
            Yoe = yoe;
            NoOfProjectsManaged = noOfProjectsManaged;
        }


        public void ManageTeam()
        {
            Console.WriteLine($"{Name} is managing {NoOfProjectsManaged} projects.\n");
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Years of Experience: {Yoe}");
            Console.WriteLine($"Projects Managed: {NoOfProjectsManaged}\n");
        }
    }

    class Intern : Employee
    {
        public int Tenure { get; }

        public Intern(int tenure, string name, int id, double salary) : base(name, id, salary)
        {
            Tenure = tenure;
        }


        public void Internship()
        {
            Console.WriteLine($"{Name} is an intern for {Tenure} months.\n");
        }
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Internship Duration: {Tenure} months\n");
        }

    }

    class Engineer : Employee
    {
        public string Domain { get; }
        public Engineer(string domain, string name, int id, double salary) : base(name, id, salary)
        {
            Domain = domain;
        }

        public void Work()
        {
            Console.WriteLine($"{Name} is working in the {Domain} domain.\n");
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Domain: {Domain}\n");
        }

    }
    class Book
    {
        public string Title { get; }
        public string Author { get; }

        public string PubDate { get; }

        public Book(string title, string author, string pDate)
        {
            Title = title;
            Author = author;
            PubDate = pDate;
        }
        public void Display()
        {
            Console.WriteLine($"The title of book is : {Title} , The Author of book is : {Author} , The publishing date of book is : {PubDate}");
        }
    }
    class Library
    {
        private List<Book> Shelf;

        public Library()
        {
            Shelf = new List<Book>();
        }
        public void AddBook(Book book)
        {
            Shelf.Add(book);
            Console.WriteLine($"Book '{book.Title}' added to the library.");
        }
        public void RemoveBook(string title)
        {

            var bookToRemove = Shelf.FirstOrDefault(b => b.Title == title);
            if (bookToRemove != null)
            {
                Shelf.Remove(bookToRemove);
                Console.WriteLine($"Book '{title}' removed from the library.");
            }
            else
            {
                Console.WriteLine($"Book '{title}' not found in the library.");
            }
        }
        public void ShowBooks()
        {
            if (Shelf.Count == 0)
            {
                Console.WriteLine("No book in library");
            }
            else
            {
                foreach (var item in Shelf)
                {
                    item.Display();
                }
            }

        }
    }

    class Customer
    {
        public string Name { get; }
        public string Address { get; }
        public string PhoneNumber { get; }

        public Customer(string name, string address, string phoneNumber)
        {
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
        }
    }
    class Account
    {

        public int AccNum { get; }
        private Customer c;

        public Account(int accNum, Customer c)
        {
            AccNum = accNum;
            this.c = c;
        }
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Account Number {AccNum}");
            Console.WriteLine($"Account Holder Name {c.Name}");
            Console.WriteLine($"Account Holder Address {c.Address}");
            Console.WriteLine($"Account Holder Phone no {c.PhoneNumber}");
        }
    }
    class SavingAccount : Account
    {
        public SavingAccount(int accNum, Customer customer) : base(accNum, customer) { }
        public override void DisplayDetails()
        {
            Console.WriteLine("---- Savings Account Details ----");
            base.DisplayDetails();
        }
    }
    class CurrentAccount : Account
    {
        public CurrentAccount(int accNum, Customer customer) : base(accNum, customer) { }
        public override void DisplayDetails()
        {
            Console.WriteLine("---- Current Account Details ----");
            base.DisplayDetails();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritence and Composition");
            Console.WriteLine("1.Problem");
            Car c = new Car("MH 12 AB 1234", 90, "Maruti", 4);
            c.Display();
            c.StartEngine();
            c.ChangeGear();
            c.PutSeatBelt();
            Console.WriteLine();
            Moterbike m = new Moterbike("KA 05 XY 5678", 45, "black", true);
            m.Display();
            m.StartEngine();
            m.Accelerate();
            Console.WriteLine();
            Bicycle b = new Bicycle("", 20, 2);
            b.Display();
            b.StartEngine();
            b.RingBell();
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("2. Problem");
            bool input = true;
            while (input)
            {
                Console.WriteLine("Press 0 to exit and 1 to continue");
                int inp = int.Parse(Console.ReadLine());
                if (inp == 0)
                {
                    input = false;
                }
                else
                {
                    Console.Write("Enter name ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Roll No ");
                    int roll = int.Parse(Console.ReadLine());
                    Console.Write("Enter street ");
                    string street = Console.ReadLine();
                    Console.Write("Enter city ");
                    string city = Console.ReadLine();
                    Console.Write("Enter state ");
                    string state = Console.ReadLine();
                    Console.Write("Enter postal code ");
                    int code = int.Parse(Console.ReadLine());
                    Student s1 = new Student(name, roll, street, city, state, code);
                    s1.Display();
                    Console.WriteLine();
                }

            }

            Console.WriteLine("----------------------------------------------------------");

            Console.WriteLine("3 Problem");
            Suplier sp1 = new Suplier("ABC SALES", "9874563214");
            Suplier sp2 = new Suplier("XYZ WHOLESALES", "9632587412");
            Suplier sp3 = new Suplier("PQR MARKET", "9122587412");


            bool input1 = true;
            while (input1)
            {
                Console.WriteLine("Press 0 to exit and 1 to continue");
                int inp = int.Parse(Console.ReadLine());
                if (inp == 0)
                {
                    input1 = false;
                }
                else
                {
                    Console.WriteLine("Enter 1 to shop for electronics product");
                    Console.WriteLine("Enter 2 to shop for clothing product");
                    Console.WriteLine("Enter 3 to shop for groceries product");
                    int ans = int.Parse(Console.ReadLine());
                    if (ans == 1)
                    {
                        Console.Write("Enter Product name ");
                        string name = Console.ReadLine();
                        Console.Write("Enter warranty period ");
                        int warranty = int.Parse(Console.ReadLine());
                        Console.Write("Enter brand name ");
                        string bname = Console.ReadLine();
                        Console.Write("Enter sku");
                        string sku = Console.ReadLine();
                        Console.Write("Enter price ");
                        double price = double.Parse(Console.ReadLine());

                        Electronics s1 = new Electronics(warranty, bname, name, price, sku, sp1);
                        s1.Display();
                        Console.WriteLine();
                    }
                    else if (inp == 2)
                    {
                        Console.Write("Enter Product name ");
                        string name = Console.ReadLine();
                        Console.Write("Enter price ");
                        double price = double.Parse(Console.ReadLine());
                        Console.Write("Enter sku");
                        string sku = Console.ReadLine();
                        Console.Write("Enter material");
                        string mat = Console.ReadLine();
                        Clothing s1 = new Clothing(name, price, sku, sp2);
                        s1.Display();
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write("Enter Product name ");
                        string name = Console.ReadLine();
                        Console.Write("Enter price ");
                        double price = double.Parse(Console.ReadLine());
                        Console.Write("Enter sku");
                        string sku = Console.ReadLine();
                        Groceries s1 = new Groceries(name, price, sku, sp3);
                        s1.Display();
                        Console.WriteLine();
                    }
                }
                Console.WriteLine("----------------------------------------------------------");


                Console.WriteLine("4.Problem");

                while (true)
                {
                    Console.WriteLine("Enter employee type as Manager || Intern || Engineer  or type 'exit' to quit:");
                    string empType = Console.ReadLine();
                    if (empType.ToLower() == "exit") break;

                    Console.WriteLine("Enter Name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter Employee ID:");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Salary:");
                    double salary = double.Parse(Console.ReadLine());

                    if (empType.ToLower() == "manager")
                    {
                        Console.WriteLine("Enter Years of Experience:");
                        int yoe = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Number of Projects Managed:");
                        int projects = int.Parse(Console.ReadLine());
                        Manager m1 = new Manager(yoe, projects, name, id, salary);
                        m1.DisplayDetails();
                        m1.ManageTeam();
                    }
                    else if (empType.ToLower() == "intern")
                    {
                        Console.WriteLine("Enter Internship Duration (months):");
                        int tenure = int.Parse(Console.ReadLine());
                        Intern i = new Intern(tenure, name, id, salary);
                        i.Internship();
                        i.DisplayDetails();
                    }
                    else if (empType.ToLower() == "engineer")
                    {
                        Console.WriteLine("Enter Domain:");
                        string domain = Console.ReadLine();
                        Engineer e = new Engineer(domain, name, id, salary);
                        e.Work();
                        e.DisplayDetails();
                    }
                    else
                    {
                        Console.WriteLine("Invalid employee type. Try again.");
                    }
                }

                Console.WriteLine("--------------------------------------------------");

                Console.WriteLine("5. Problem");
                Library lb = new Library();
                lb.AddBook(new Book("C#", "Kasturi", "1998/05/4"));
                lb.AddBook(new Book("JAVA", "Samruddhi", "1985/02/14"));
                lb.AddBook(new Book("C++", "Shardul", "1913/04/24"));
                while (true)
                {
                    Console.WriteLine("Press 1 to Add a book");
                    Console.WriteLine("Press 2 to remove a book");
                    Console.WriteLine("Press 3 to display books");
                    Console.WriteLine("Press 4 to exit");
                    int input2 = int.Parse(Console.ReadLine());
                    if (input2 == 1)
                    {
                        Console.WriteLine("Enter title");
                        string title = Console.ReadLine();
                        Console.WriteLine("Enter author");
                        string author = Console.ReadLine();
                        Console.WriteLine("Enter publishing date in (yyyy,mm,dd)");
                        string pdate = Console.ReadLine();
                        lb.AddBook(new Book(title, author, pdate));

                    }
                    else if (input2 == 2)
                    {
                        Console.WriteLine("Enter title");
                        string title = Console.ReadLine();
                        lb.RemoveBook(title);
                    }
                    else if (input2 == 3)
                    {
                        lb.ShowBooks();
                    }
                    else
                    {
                        break;
                    }

                }


                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("6. Problem ");
                Customer c1 = new Customer("Maitri", "Ramnagar", "987654321");
                Customer c2 = new Customer("Kasturi", "Shanti Nagar", "789453121");
                Account savings = new SavingAccount(101, c1);
                Account current = new CurrentAccount(102, c2);
                savings.DisplayDetails();
                Console.WriteLine();
                current.DisplayDetails();
            }
        }
    }
}
