using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Fahrenheit to Celsius Converter!");

            while (true)
            {
                try
                {
                    Console.Write("Enter a temperature in Fahrenheit: ");
                    string input = Console.ReadLine();
                    double fahrenheit = Convert.ToDouble(input);

                    if (fahrenheit < -459.67)
                    {
                        throw new ArgumentOutOfRangeException("Temperature cannot be below absolute zero (-459.67°F).");
                    }

                    double celsius = (fahrenheit - 32) * 5 / 9;
                    Console.WriteLine("The temperature {0}°F is equal to {1:F2}°C.", fahrenheit, celsius);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Invalid input. Please enter a valid number.");
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("Error: {0}", ex.Message);
                }
                Console.WriteLine("Please try again.");
            }
        }
    }
}
