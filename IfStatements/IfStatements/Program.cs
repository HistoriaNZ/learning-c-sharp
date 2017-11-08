using System;

namespace IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            inefficientIf();
            betterIf();
        }

        static void inefficientIf()
        {
            Console.WriteLine("Please enter a number between one and three");
            int userNumber = int.Parse(Console.ReadLine());

            if (userNumber == 1)
            {
                Console.WriteLine("Your number is one.");
            }
            if (userNumber == 2)
            {
                Console.WriteLine("Your number is two.");
            }
            if (userNumber == 3)
            {
                Console.WriteLine("Your number is three.");
            }
            if (userNumber != 1 && userNumber != 2 && userNumber != 3)
            {
                Console.WriteLine("Your number is not between one and three!");
            }
            Console.ReadLine();
        }

        static void betterIf()
        {
            Console.WriteLine("Please enter a number between one and three");
            int userNumber = int.Parse(Console.ReadLine());

            if (userNumber == 1)
            {
                Console.WriteLine("Your number is one.");
            }
            else if (userNumber == 2)
            {
                Console.WriteLine("Your number is two.");
            }
            else if (userNumber == 3)
            {
                Console.WriteLine("Your number is three.");
            }
            else
            {
                Console.WriteLine("Your number is not between one and three!");
            }
            Console.ReadLine();
        }
    }
}
