using System;

namespace Conversions
{
    class Program
    {
        static void Main(string[] args)
        {
            implicitConversion();
            explicitConversion();
            parsing();
            tryParsing();
        }

        static void implicitConversion()
        {
            int i = 100;
            float f = i;
            Console.WriteLine("No explicit conversion required: {0}", f);
            Console.ReadLine();
        }

        static void explicitConversion()
        {
            float f = 123345333.45F;
            int i = Convert.ToInt32(f);
            Console.WriteLine("Must explicitly convert from larger datatype to smaller: {0}", i);
            Console.ReadLine();
        }

        static void parsing()
        {
            string strNumber = "100";
            int i = int.Parse(strNumber);
            Console.WriteLine("Parsed string to int: {0}", i);
            Console.ReadLine();
        }

        static void tryParsing()
        {
            string strNumber = "1000987";
            int result = 0;
            bool isConversionSuccessful = int.TryParse(strNumber, out result);
            
            if (isConversionSuccessful)
            {
                Console.WriteLine("Successfully converted string to: {0} (int)", result);
            }
            else
            {
                Console.WriteLine("Conversion failed. :(");
            }
            Console.ReadLine();
        }
    }
}
