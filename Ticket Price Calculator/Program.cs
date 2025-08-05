using System;

class TicketPriceCalculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your age:");
        if (int.TryParse(Console.ReadLine(), out int age))
        {
            if (age >= 0)
            {
                int ticketPrice;
                if (age <= 12 || age >= 65)
                {
                    ticketPrice = 7; 
                }
                else
                {
                    ticketPrice = 10;
                }
                Console.WriteLine($"Your ticket price is: GHC{ticketPrice}");
            }
            else
            {
                Console.WriteLine("Error: Age cannot be negative.");
            }
        }
        else
        {
            Console.WriteLine("Error: Invalid input. Please enter a valid age.");
        }
    }
}