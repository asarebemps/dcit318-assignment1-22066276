using System;
 
namespace TriangleTypeIdentifierApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideA = ReadSide("Enter the length of side A: ");
            double sideB = ReadSide("Enter the length of side B: ");
            double sideC = ReadSide("Enter the length of side C: ");
 
            if (!IsValidTriangle(sideA, sideB, sideC))
            {
                Console.WriteLine("These side lengths do not form a valid triangle.");
                return;
            }
 
            string triangleType = GetTriangleType(sideA, sideB, sideC);
            Console.WriteLine($"Triangle Type: {triangleType}");
        }
 
        static double ReadSide(string prompt)
        {
            Console.Write(prompt);
            double.TryParse(Console.ReadLine(), out double side);
            return side;
        }
 
        static bool IsValidTriangle(double a, double b, double c)
        {
            return a > 0 && b > 0 && c > 0 &&
                   (a + b > c) && (a + c > b) && (b + c > a);
        }
 
        static string GetTriangleType(double a, double b, double c)
        {
            if (a == b && b == c)
                return "Equilateral";
            if (a == b || b == c || a == c)
                return "Isosceles";
            return "Scalene";
        }
    }
}
