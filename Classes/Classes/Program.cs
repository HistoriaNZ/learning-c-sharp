using System;

namespace Classes
{

    class Customer
    {
        string _firstName;
        string _lastName;


        // constructor. same name as class, no return type.
        public Customer(string firstName, string lastName)
        {
            this._firstName = firstName;
            this._lastName = lastName;
        }

        //default constructor (no arguments passed in)
        public Customer() : this("No firstname provided", "No lastname provided.")
        {
        }

        public void printFullName()
        {
            Console.WriteLine("Full name: {0} {1}", this._firstName, this._lastName);
            Console.ReadLine();
        }

        // destructor. automatically called by C# garbage collection.
        ~Customer()
        {

        }
    }

    class Circle
    {
        static float _pi = 3.141F;
        int _radius;

        public Circle(int radius)
        {
            this._radius = radius;
        }

        public static void print()
        {
            //For example only.
        }

        public float calculateArea()
        {
            return _pi * this._radius * this._radius;
        }
    }

    public class Employee
    {
        public string firstName = "FN";
        public string lastName = "LN";

        public virtual void printFullName()
        {
            Console.WriteLine("Full name: {0} {1}", firstName, lastName);
        }
    }

    public class PartTimeEmployee : Employee
    {
        public override void printFullName()
        {
            Console.WriteLine("Full name: {0} {1} - Part Time", firstName, lastName);
        }
    }

    public class FullTimeEmployee : Employee
    {
        public override void printFullName()
        {
            Console.WriteLine("Full name: {0} {1} - Full Time", firstName, lastName);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Customer c1 = new Customer("Tom", "Quinn");
            //c1.printFullName();

            //Circle circle1 = new Circle(5);
            //float circleArea = circle1.calculateArea();
            //Console.WriteLine("The area of the first circle is: {0}.", circleArea);
            //Console.ReadLine();

            //Circle circle2 = new Circle(6);
            //float circleArea2 = circle2.calculateArea();
            //Circle.print();
            //Console.WriteLine("The area of the second circle is: {0}", circleArea2);
            //Console.ReadLine();

            //FullTimeEmployee FTE = new FullTimeEmployee();
            //FTE.firstName = "Fulltime";
            //FTE.lastName = "Employee";
            //FTE.printFullName();

            //PartTimeEmployee PTE = new PartTimeEmployee();
            //PTE.firstName = "Parttime";
            //PTE.lastName = "Employee";
            //PTE.printFullName();

            //Polymorphism examples from here
            Employee[] employees = new Employee[4];

            employees[0] = new Employee();
            employees[1] = new PartTimeEmployee();
            employees[2] = new FullTimeEmployee();
            employees[3] = new FullTimeEmployee();

            foreach (Employee e in employees)
            {
                e.printFullName();
            }
        }
    }
}
