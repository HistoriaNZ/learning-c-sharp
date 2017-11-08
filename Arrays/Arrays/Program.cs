using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            intArrays();
            initAndAssign();
        }

        //Arrays in C# are STRONGLY TYPED.
        static void intArrays()
        {
            int[] evenNumbers = new int[3];

            evenNumbers[0] = 0;
            evenNumbers[1] = 2;
            evenNumbers[2] = 4;

            Console.WriteLine(evenNumbers[1]);
            Console.ReadLine();
        }

        static void initAndAssign()
        {
            int[] oddNumbers = { 1, 2, 3};

            Console.WriteLine(oddNumbers[2]);
            Console.ReadLine();
        }
    }
}
