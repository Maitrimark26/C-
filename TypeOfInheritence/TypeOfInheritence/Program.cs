using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeOfInheritence
{
    internal class Program
    {
        class Person
        {
            public string Name { get; }
            public int Age { get; }

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
            public virtual void Display()
            {
                Console.WriteLine("****** Student details ******");
                Console.WriteLine($"Name of student is {Name}");
                Console.WriteLine($"Age of student is {Age}");

            }
        }
        class Student : Person
        {
            public string Grade { get; }
            public Student(string grade, string name, int age) : base(name, age)
            {
                Grade = grade;
            }
            public override void Display()
            {
                base.Display();
                Console.WriteLine($"Grade of student is {Grade}\n");
            }


        }
        class Vehicle
        {
            public string NumberPlate { get; }
            public int MaxSpeed { get; }


            public Vehicle(string numberPlate, int maxspeed)
            {
                NumberPlate = numberPlate;
                MaxSpeed = maxspeed;

            }

            public virtual void StartEngine()
            {
                Console.WriteLine($"Engine starts...");
            }
            public virtual void Display()
            {
                Console.WriteLine($"Number Plate: {NumberPlate}, Max Speed: {MaxSpeed} km/h");
            }
        }
        class Car : Vehicle
        {
            public string Brand { get; }
            public string Model { get; }


            public Car(string brand, string model, string plate, int maxspeed) : base(plate, maxspeed)
            {
                Brand = brand;
                Model = model;
            }
            public override void StartEngine()
            {
                Console.WriteLine($"Starting {Brand} {Model} car engine...");
            }
            public override void Display()
            {
                base.Display();
                Console.WriteLine($"Brand: {Brand}, Model: {Model}");
            }
        }
        class ElectricCar : Car
        {
            public int Batterylife { get; }
            public double RechargeTime { get; }

            public ElectricCar(int batterylife, double rechargeTime, string br, string model, string plate, int maxspeed) : base(br, model, plate, maxspeed)
            {
                Batterylife = batterylife;
                RechargeTime = rechargeTime;
            }
            public override void StartEngine()
            {
                Console.WriteLine($"Starting electric {Brand} {Model} silently...");
            }

            public override void Display()
            {
                base.Display();
                Console.WriteLine($"Battery Life: {Batterylife}%, Recharge Time: {RechargeTime} hours");
            }

        }

        class Animal
        {
            public void Speak()
            {
                Console.WriteLine("Speaks....");
            }
            public void Eat()
            {
                Console.WriteLine("Eats...");
            }
        }
        class Dog : Animal
        {
            public void Barks()
            {
                Console.WriteLine("Dog Barks...");
            }
        }
        class Cat : Animal
        {
            public void Meaws()
            {
                Console.WriteLine("Cat meaws...");
            }
        }

        interface IFly
        {
            void Fly();

        }
        interface ISwim
        {
            void Swim();
        }
        class Duck : IFly, ISwim
        {
            public virtual void Fly()
            {
                Console.WriteLine("Duck cannot fly");
            }
            public virtual void Swim()
            {
                Console.WriteLine("Duck swims");
            }

        }
        class MallardDuck : Duck
        {
            string type;

            public MallardDuck(string type)
            {
                this.type = type;
            }

            public override void Fly()
            {
                Console.WriteLine($"{type} Duck can fly");
            }
            public override void Swim()
            {
                Console.WriteLine($"{type} Duck can swim");
            }
        }
        class RubberDuck : Duck
        {
            string type;

            public RubberDuck(string type)
            {
                this.type = type;
            }

            public override void Fly()
            {
                Console.WriteLine($"{type} Duck cannot fly");
            }
            public override void Swim()
            {
                Console.WriteLine($"{type} Duck cannot swim");
            }
        }
        interface IShape
        {
            void CalArea();
            void Display();
        }
        class Rectange : IShape
        {
            public int Length { get; }
            public int Width { get; }

            public Rectange(int length, int width)
            {
                Length = length;
                Width = width;
            }

            public void CalArea()
            {
                Console.WriteLine($"Area of rectangle is {Length * Width}");
            }

            public void Display()
            {
                Console.WriteLine("*** Details of rectangle ***");
                Console.WriteLine($"The length of rectangle is {Length} and width is {Width}");
            }
        }
        class Circle : IShape
        {
            public int Radius { get; }


            public Circle(int radius)
            {
                Radius = radius;
            }

            public void CalArea()
            {
                Console.WriteLine($"Area of circle is {3.14 * Radius * Radius}");
            }

            public void Display()
            {
                Console.WriteLine("*** Details of Circle ***");
                Console.WriteLine($"The radius of circle is {Radius}");
            }
        }
        class Triangle : IShape
        {
            public int Length { get; }
            public int Width { get; }

            public Triangle(int length, int width)
            {
                Length = length;
                Width = width;
            }

            public void CalArea()
            {
                Console.WriteLine($"Area of triangle is {0.5 * Length * Width}");
            }

            public void Display()
            {
                Console.WriteLine("*** Details of triangle ***");
                Console.WriteLine($"The height of triangle is {Length} and breadth is {Width}");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Type of inheritence");
            Console.WriteLine("Problem 1");
            while (true)
            {
                Console.WriteLine("Press 1 to continue and 0 to exit");
                int inp = int.Parse(Console.ReadLine());
                if (inp == 0) { break; }
                string name; int age; string grade;
                Console.Write("Enter name of student ");
                name = Console.ReadLine();
                Console.Write("Enter age of student ");
                age = int.Parse(Console.ReadLine());
                Console.Write("Enter grade of student ");
                grade = Console.ReadLine();
                Student s = new Student(grade, name, age);
                s.Display();
            }
            Console.WriteLine("Problem 2");
            Vehicle vehicle = new Vehicle("ABC123", 180);
            vehicle.StartEngine();
            vehicle.Display();

            Console.WriteLine();

            Car car = new Car("Toyota", "Corolla", "XYZ456", 200);
            car.StartEngine();
            car.Display();

            Console.WriteLine();

            ElectricCar electricCar = new ElectricCar(85, 1.5, "Tesla", "Model S", "EVC789", 250);
            electricCar.StartEngine();
            electricCar.Display();





            Console.WriteLine("Problem 3");
            Console.WriteLine("*** Animal ***");
            Animal a = new Animal();
            a.Speak();
            a.Eat();
            Console.WriteLine("*** Dog ***");
            Dog d = new Dog();
            d.Speak();
            d.Eat();
            d.Barks();
            Console.WriteLine("*** Cat ***");
            Cat c = new Cat();
            c.Speak();
            c.Eat();
            c.Meaws();
            Console.WriteLine("Problem 4");
            Duck duck = new Duck();
            duck.Fly();
            duck.Swim();
            Console.WriteLine();

            Duck Mallardduck = new MallardDuck("Mallard");
            Mallardduck.Fly();
            Mallardduck.Swim();
            Console.WriteLine();
            Duck Ruberduck = new RubberDuck("Rubber");
            Ruberduck.Fly();
            Ruberduck.Swim();
            Console.WriteLine("Problem 5");
            Rectange r = new Rectange(5, 9);
            r.Display();
            r.CalArea();
            Console.WriteLine();
            Triangle t = new Triangle(25, 19);
            t.Display();
            t.CalArea();
            Console.WriteLine();
            Circle c1 = new Circle(26);
            c1.Display();
            c1.CalArea();




        }

    }
}

