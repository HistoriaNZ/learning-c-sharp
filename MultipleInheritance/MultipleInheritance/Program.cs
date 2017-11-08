using System;

namespace MultipleInheritance
{
    class A
    {
        public virtual void Print()
        {
            Console.WriteLine("A's Implementation");
        }
    }
    
    class B : A
    {
        public override void Print()
        {
            Console.WriteLine("B's Implementation");
        }
    }

    class C : A
    {
        public override void Print()
        {
            Console.WriteLine("C's Implemenation");
        }
    }

    class D: B, C
    {
        //This class does not override the Print() method, and because it is a derived
        // class (hypothetically) of both B and C, there is ambiguity about which Print()
        // method (B's, or C's?) it will call if instantiated (the Diamond Problem).
    }

    class Program
    {
        //This will not build, it is for demonstrative purposes only.
        static void Main(string[] args)
        {
            D d = new D();
            d.Print(); // which method is called here? 
        }
    }
}
