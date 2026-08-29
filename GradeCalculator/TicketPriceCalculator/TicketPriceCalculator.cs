using System;
 
namespace TicketPriceCalculatorApp
{
    class Program
    {
        const decimal RegularPrice = 10.0m;
        const decimal DiscountedPrice = 7.0m;
 
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            string input = Console.ReadLine();
 
            if (!int.TryParse(input, out int age) || age < 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid age.");
                return;
            }
 
            decimal price = GetTicketPrice(age);
            Console.WriteLine($"Age: {age} -> Ticket Price: GHC{price:F2}");
        }
 
        static decimal GetTicketPrice(int age)
        {
            bool isSeniorCitizen = age >= 65;
            bool isChild = age <= 12;
 
            return (isSeniorCitizen || isChild) ? DiscountedPrice : RegularPrice;
        }
    }
}
 
