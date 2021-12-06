using System;

namespace Shake_Your_Money_Maker
{
    class Program
    {

        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to shake your money maker");
            Console.WriteLine("This program will take your dollar amount and convert it into the least amount of coins needed");
            Console.WriteLine(" ");


            Console.WriteLine("Enter amount to convert into coins");
            Console.WriteLine(" ");

            string amountAsString;
            double amount;
            double penny = .01;
            double nickel = .05;
            double dime = .10;
            double quarter = .25;
            double quartersNeeded;
            double quarterRemainder;
            double dimesNeeded;
            double dimeRemainder;
            double nickelsNeeded;
            double nickelRemainder;
            double penniesNeeded;

            amountAsString = Console.ReadLine();
            amount = Convert.ToDouble(amountAsString);

            quartersNeeded = Math.Floor(amount / quarter);
            quarterRemainder = (amount % quarter);

            dimesNeeded = Math.Floor(quarterRemainder / dime);
            dimeRemainder = (quarterRemainder % dime);

            nickelsNeeded = Math.Floor(dimeRemainder / nickel);
            nickelRemainder = (dimeRemainder % nickel);

            penniesNeeded = Math.Floor(nickelRemainder / penny);

            Console.WriteLine(" ");
            Console.WriteLine($"${amount} in the least amount of coins will be: ");
            Console.WriteLine($"Quarters: {quartersNeeded}");
            Console.WriteLine($"Dimes: {dimesNeeded}");
            Console.WriteLine($"Nickels: {nickelsNeeded}");
            Console.WriteLine($"Pennies: {penniesNeeded}");

            
            




        }
    }
}
