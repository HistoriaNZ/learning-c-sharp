using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //upToTarget();
            //doWhileLoop();
            coffeeShopWhile();
        }

        static void upToTarget()
        {
            Console.WriteLine("Please enter your target:");
            int userTarget = int.Parse(Console.ReadLine());

            int start = 0;

            while (start <= userTarget)
            {
                Console.Write(start);
                start = start + 2;
            }
            Console.ReadLine();
        }

        static void doWhileLoop()
        {
            string userContinue = "YES";
            do
            {
                Console.WriteLine("Please enter your target:");
                int userTarget = int.Parse(Console.ReadLine());

                int start = 0;

                while (start <= userTarget)
                {
                    Console.Write(start + " ");
                    start += 2;
                }

                do
                {
                    Console.WriteLine("Do you want to continue: Yes or No?");
                    userContinue = (Console.ReadLine()).ToUpper();

                    if (userContinue != "YES" && userContinue != "NO")
                    {
                        Console.WriteLine("Invalid choice, please enter Yes or No.");
                    }
                } while (userContinue != "YES" && userContinue != "NO");
            } while (userContinue == "YES");
        }

        //goto segments replaced by conditionals
        static void coffeeShopWhile()
        {
            int totalCost = 0;
            string userContinue = "YES";
            do
            {
                Console.WriteLine("Please select your coffee size: 1 - Small, 2 - Medium, 3 - Large.");
                int coffeeChoice = int.Parse(Console.ReadLine());

                if (coffeeChoice == 1 || coffeeChoice == 2 || coffeeChoice == 3)
                {
                    totalCost += coffeeChoice;
                    Console.WriteLine("${0}.00 successfully added to order.", coffeeChoice);
                }
                else
                {
                    Console.WriteLine("Your choice, {0}, is invalid.", coffeeChoice);
                }

                do
                {
                    Console.WriteLine("Do you want to order another coffee?");
                    userContinue = (Console.ReadLine()).ToUpper();

                    if (userContinue != "YES" && userContinue != "NO")
                    {
                        Console.WriteLine("Your choice, {0}, is invalid. Please enter Yes or No.");
                    }
                } while (userContinue != "YES" && userContinue != "NO");
            } while (userContinue == "YES");

            Console.WriteLine("Thank you for shopping with us!");
            Console.WriteLine("Total bill: ${0}.00.", totalCost);
            Console.ReadLine();
        }
    }
}
