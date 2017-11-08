using System;

namespace Classes2
{
    public class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("I am the base class' print method.");
        }
    }

    public class DerivedClass : BaseClass
    {
        public override void Print()
        {
            Console.WriteLine("I am the derived class' print method.");
        }
    }

    public class Program
    {
        public static void Main()
        {
            BaseClass B = new DerivedClass();
            B.Print();
            Console.ReadLine();

            DerivedClass D = new DerivedClass();
            D.Print();
            Console.ReadLine();
        }
    }
}
