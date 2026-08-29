using System;
 
namespace GradeCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a numerical grade (0 - 100): ");
            string input = Console.ReadLine();
 
            if (!double.TryParse(input, out double grade) || grade < 0 || grade > 100)
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
                return;
            }
 
            string letterGrade = GetLetterGrade(grade);
            Console.WriteLine($"Grade: {grade} -> Letter Grade: {letterGrade}");
        }
 
        static string GetLetterGrade(double grade)
        {
            if (grade >= 90) return "A";
            if (grade >= 80) return "B";
            if (grade >= 70) return "C";
            if (grade >= 60) return "D";
            return "F";
        }
    }
}
