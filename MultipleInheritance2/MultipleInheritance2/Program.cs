/* Indirect multiple inheritance using interfaces. */
using System;


namespace MultipleInheritance2
{
    interface IA
    {
        void AMethod();
    }

    interface IB
    {
        void BMethod();
    }

    class A : IA
    {
        public void AMethod()
        {
            Console.WriteLine("AMethod implementation (class A)");
        }
    }

    class B : IB
    {
        public void BMethod()
        {
            Console.WriteLine("BMethod implemenation (class B)");
        }
    }

    class AB : IA, IB
    {
        A a = new A();
        B b = new B();

        public void AMethod()
        {
            a.AMethod();
        }

        public void BMethod()
        {
            b.BMethod();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate AB to utilise both A and B's methods (using interface inheritance)!
            AB ab = new AB();
            ab.AMethod();
            ab.BMethod();
            Console.ReadLine();
        }
    }
}
