using System;

class TriangleTypeIdentifier
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the length of the first side:");
        if (!double.TryParse(Console.ReadLine(), out double side1) || side1 <= 0)
        {
            Console.WriteLine("Invalid input for the first side. Please enter a positive number.");
            return;
        }

        Console.WriteLine("Enter the length of the second side:");
        if (!double.TryParse(Console.ReadLine(), out double side2) || side2 <= 0)
        {
            Console.WriteLine("Invalid input for the second side. Please enter a positive number.");
            return;
        }

        Console.WriteLine("Enter the length of the third side:");
        if (!double.TryParse(Console.ReadLine(), out double side3) || side3 <= 0)
        {
            Console.WriteLine("Invalid input for the third side. Please enter a positive number.");
            return;
        }
        
        if ((side1 + side2 > side3) && (side1 + side3 > side2) && (side2 + side3 > side1))
        {
            string triangleType;
            if (side1 == side2 && side2 == side3)
            {
                triangleType = "Equilateral"; 
            }
            else if (side1 == side2 || side2 == side3 || side1 == side3)
            {
                triangleType = "Isosceles"; 
            }
            else
            {
                triangleType = "Scalene"; 
            }
            Console.WriteLine($"The triangle is: {triangleType}");
        }
        else
        {
            Console.WriteLine("The entered side lengths do not form a valid triangle.");
        }
    }
}
