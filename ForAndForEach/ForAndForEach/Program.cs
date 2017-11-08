using System;

namespace ForAndForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            forLoop();
            forEachLoop();
        }

        static void forLoop()
        {
            int[] numbers = new int[3];
            numbers[0] = 101;
            numbers[1] = 102;
            numbers[2] = 103;

            for (int j = 0; j < numbers.Length; j++)
            {
                Console.WriteLine(numbers[j]);

            }
            Console.ReadLine();
        }

        static void forEachLoop()
        {
            int[] numbers = new int[3];
            numbers[0] = 101;
            numbers[1] = 102;
            numbers[2] = 103;

            foreach (int k in numbers)
            {
                Console.WriteLine(k);
            }
            Console.ReadLine();
        }
    }
}


