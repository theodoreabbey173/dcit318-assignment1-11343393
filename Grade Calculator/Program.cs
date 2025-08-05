using System;

class GradeCalculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a numerical grade between 0 and 100:");
        if (int.TryParse(Console.ReadLine(), out int grade))
        {
            if (grade >= 0 && grade <= 100)
            {
                string letterGrade;
                if (grade >= 90)
                {
                    letterGrade = "A";
                }
                else if (grade >= 80)
                {
                    letterGrade = "B"; 
                }
                else if (grade >= 70)
                {
                    letterGrade = "C";
                }
                else if (grade >= 60)
                {
                    letterGrade = "D"; 
                }
                else
                {
                    letterGrade = "F"; 
                }
                Console.WriteLine($"The corresponding letter grade is: {letterGrade}");
            }
            else
            {
                Console.WriteLine("Error: Please enter a grade between 0 and 100.");
            }
        }
        else
        {
            Console.WriteLine("Error: Invalid input. Please enter a valid number.");
        }
    }
}