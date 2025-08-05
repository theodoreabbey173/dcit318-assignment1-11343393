using System;

class TicketPriceCalculator
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        int price = (age <= 12 || age >= 65) ? 7 : 10;
        Console.WriteLine("Your ticket price is: GHC" + price);
    }
}

