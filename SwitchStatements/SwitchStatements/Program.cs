using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //switchStatement();
            //condensedSwitch();
            coffeeShop();
        }

        static void switchStatement()
        {
            Console.WriteLine("Please enter a number.");
            int userNumber = int.Parse(Console.ReadLine());

            switch(userNumber)
            {
                case 10:
                    Console.WriteLine("Your number is 10.");
                    break;
                case 20:
                    Console.WriteLine("Your number is 20.");
                    break;
                case 30:
                    Console.WriteLine("Your number is 30.");
                    break;
                default:
                    Console.WriteLine("Your number is not 10, 20 or 30.");
                    break;
            }
            Console.ReadLine();
        }

        // Removing redundant code segments
        static void condensedSwitch()
        {
            Console.WriteLine("Please enter a number.");
            int userNumber = int.Parse(Console.ReadLine());

            switch(userNumber)
            {
                case 10:
                case 20:
                case 30:
                    Console.WriteLine("Your number is {0}", userNumber);
                    break;
                default:
                    Console.WriteLine("Your number is not 10, 20 or 30.");
                    break;
            }
            Console.ReadLine();
        }

        //goto not reccomended, usually better to refactor!
        static void coffeeShop()
        {

            int totalCost = 0;
            Start:
            Console.WriteLine("Please select your coffee size: 1 - Small, 2 - Medium, 3 - Large.");
            int coffeeChoice = int.Parse(Console.ReadLine());

            switch (coffeeChoice)
            {
                case 1:
                    totalCost += 1;
                    break;
                case 2:
                    totalCost += 2;
                    break;
                case 3:
                    totalCost += 3;
                    break;
                default:
                    Console.WriteLine("Your choice, {0}, is invalid.", coffeeChoice);
                    goto Start;
            }

            Decide:
            Console.WriteLine("Do you want to buy another coffee - Yes or No?");
            string continueShopping = Console.ReadLine();

            switch (continueShopping.ToUpper())
            {
                case "YES":
                    goto Start;
                case "NO":
                    break;
                default:
                    Console.WriteLine("Your choice, {0}, is invalid. Please try again.", continueShopping);
                    goto Decide;
            }

            Console.WriteLine("Thank you for shopping with us!");
            Console.WriteLine("Total bill: ${0}.00.", totalCost);
            Console.ReadLine();
        }

    }
}
