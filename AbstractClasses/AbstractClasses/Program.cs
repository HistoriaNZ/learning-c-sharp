using System;

namespace AbstractClasses
{
    public abstract class Customer
    {
        public abstract void Print();
    }

    public class DerivedClass : Customer
    {
        public override void Print()
        {
            Console.WriteLine("Print method.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer C = new DerivedClass();
            C.Print();
            Console.ReadLine();
        }
    }
}
