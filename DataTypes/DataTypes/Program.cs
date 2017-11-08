using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            commonOperators();
            ternaryTest();
            nullableTypes();
            nullCoalescing();
        }

        static void commonOperators()
        {
            int numerator = 10;
            int denominator = 2;
            int result = numerator / denominator;
            Console.WriteLine("Result = {0}", result);
            Console.ReadLine();
        }

        static void ternaryTest()
        {
            int number = 15;
            bool isNumber10 = number == 10 ? true : false;
            Console.WriteLine("Number == 10 is {0}", isNumber10);
            Console.ReadLine();
        }

        static void nullableTypes()
        {
            bool? AreYouMajor = null;
            if (AreYouMajor == true)
            {
                Console.WriteLine("User is a major.");
            }
            else if (AreYouMajor == false)
            {
                Console.WriteLine("User is not a major.");
            }
            else
            {
                Console.WriteLine("User did not answer the question.");
            }
            Console.ReadLine();
        }

        static void nullCoalescing()
        {
            int? ticketsOnSale = null;
            int availableTickets;

            //long way
            if (ticketsOnSale == null)
            {
                availableTickets = 0;
            }
            else
            {
                availableTickets = ticketsOnSale.Value; // return non-nullable int value from nullable variable!
            }
            Console.WriteLine("Available Tickets: {0}", availableTickets);
            Console.ReadLine();

            //same operation using null coalescence
            availableTickets = ticketsOnSale ?? 0;
            Console.WriteLine("Available Tickets (null coalescence): {0}", availableTickets);
            Console.ReadLine();
        }
    }
}
