using System;

namespace MethodsAndFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            //p.evenNumbers();
            //p.evenNumbers2(10);
            //Console.WriteLine(p.addNumbers(4, 5));
            int total = 0;
            int product = 0;

            calculate(10, 20, out total, out product);
            Console.WriteLine("Sum = {0} and Product = {1}.", total, product);
            Console.ReadLine();

            int[] numbers = new int[3];
            numbers[0] = 101; numbers[1] = 102; numbers[2] = 103;

            paramsMethod();
            paramsMethod(numbers);
        }

        // non-static; must be called on instance of the Program class!
        public void evenNumbers()
        {
            int start = 0;

            while (start <= 20)
            {
                Console.WriteLine(start);
                start += 2;
            }
            Console.ReadLine();
        }

        public void evenNumbers2(int target)
        {
            int start = 0;

            while (start <= target)
            {
                Console.WriteLine(start);
                start += 2;
            }
            Console.ReadLine();
        }

        // adding paramaters for more flexibility
        public int addNumbers(int a, int b)
        {
            return a + b;
        }

        //this method CHANGES the variable passed to it! (ref)
        public static void simpleMethod(ref int j)
        {
            j = 101;
        }


        //returning more than one value
        public static void calculate(int first, int second, out int sum, out int product)
        {
            sum = first + second;
            product = first * second;
        }

        public static void paramsMethod(params int[] numbers)
        {
            Console.WriteLine("There are {0} elements in this array.", numbers.Length);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
