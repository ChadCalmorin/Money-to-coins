using System;

namespace Shake_Your_Money_Maker
{
    class Program
    {

        static void Main(string[] args)
        {

            string amountAsString;
            decimal amount;
            decimal penny = .01m;
            decimal nickel = .05m;
            decimal dime = .10m;
            decimal quarter = .25m;
            decimal quartersNeeded;
            decimal quarterRemainder;
            decimal dimesNeeded;
            decimal dimeRemainder;
            decimal nickelsNeeded;
            decimal nickelRemainder;
            decimal penniesNeeded;


            Console.WriteLine("Welcome to shake your money maker");
            Console.WriteLine("This program will take your dollar amount and convert it into the least amount of coins needed\n");
            


            Console.WriteLine("Enter amount to convert into coins\n");
            

            

            amountAsString = Console.ReadLine();
            amount = Convert.ToDecimal(amountAsString);

            quartersNeeded = Math.Floor(amount / quarter);
            quarterRemainder = (amount % quarter);

            dimesNeeded = Math.Floor(quarterRemainder / dime);
            dimeRemainder = (quarterRemainder % dime);

            nickelsNeeded = Math.Floor(dimeRemainder / nickel);
            nickelRemainder = (dimeRemainder % nickel);

            penniesNeeded = Math.Floor(nickelRemainder / penny);

            
            Console.WriteLine($"\n${amount} in the least amount of coins will be: ");
            Console.WriteLine($"Quarters: {quartersNeeded}");
            Console.WriteLine($"Dimes: {dimesNeeded}");
            Console.WriteLine($"Nickels: {nickelsNeeded}");
            Console.WriteLine($"Pennies: {penniesNeeded}");








        }
    }
}
