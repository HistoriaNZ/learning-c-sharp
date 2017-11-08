using System;

namespace MultiCastDelegates
{
    public delegate void SampleDelegate();

    class Program
    {
        static void Main(string[] args)
        {
            //Exercise1();
            Exercise2();
            Console.ReadLine();


        }

        public static void SampleMethod1()
        {
            Console.WriteLine("Sample Method 1 invoked.");
        }

        public static void SampleMethod2()
        {
            Console.WriteLine("Sample Method 2 invoked.");
        }

        public static void SampleMethod3()
        {
            Console.WriteLine("Sample Method 3 invoked.");
        }

        public static void Exercise1()
        {
            SampleDelegate del1, del2, del3, del4;
            del1 = new SampleDelegate(SampleMethod1);
            del2 = new SampleDelegate(SampleMethod2);
            del3 = new SampleDelegate(SampleMethod3);
            //Chain delegates together with the + symbol.
            del4 = del1 + del2 + del3;
            del4();
        }

        public static void Exercise2()
        {
            //Same effect as Exercise 1, but different syntax.
            SampleDelegate del = new SampleDelegate(SampleMethod1);
            del += SampleMethod2;
            del();
        }
    }
}
