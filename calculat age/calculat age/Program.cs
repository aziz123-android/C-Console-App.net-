using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculat_age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the current year: ");
            int currentYear = int.Parse(Console.ReadLine());

            Console.Write("Enter your birth year: ");
            int birthYear = int.Parse(Console.ReadLine());

            // Create an AgeCalculator instance with user input
            AgeCalculator ageCalculator = new AgeCalculator(currentYear, birthYear);
            int age = ageCalculator.CalculateAge();

            Console.WriteLine($"Your current age is: {age}");
            Console.ReadLine();
        }
    }
}
