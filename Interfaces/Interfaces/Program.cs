using System;

namespace Interfaces
{
    interface ICustomer
    {
        void Print();

    }

    interface I2
    {
        void I2Method();
    }

    class Customer : ICustomer, I2
    {
        public void Print()
        {
            Console.WriteLine("Interface print method.");
        }

        public void I2Method()
        {
            Console.WriteLine("I2 method.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer();
            C1.Print();
            Console.ReadLine();
        }
    }
}
