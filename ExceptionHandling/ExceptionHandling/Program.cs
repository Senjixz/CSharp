using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Calculator
    {
        public double Divide(int numerator, int denominator)
        {
            try
            {
                return (double)numerator / denominator;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero is not allowed");
                return 0.0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return 0.0;
            }
        }
        public int ParseInput(string input)
        {
            try
            {
                return int.Parse(input);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid Input. Please enter a valid integer");
                return -1;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return -1;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            try
            {
                Console.WriteLine("Please enter an integer: ");
                string numeratorInput = Console.ReadLine();
                int numerator = calculator.ParseInput(numeratorInput);

                Console.WriteLine("Please enter a second integer: ");
                string denominatorInput = Console.ReadLine();
                int denominator = calculator.ParseInput(denominatorInput);

                if (numerator == -1 || denominator == -1)
                {
                    Console.WriteLine("Calculation cannot proceed due to invalid inputs.");
                    return;
                }
                double result = calculator.Divide(numerator, denominator);
                Console.WriteLine($"Result: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error occured: {ex.Message}");
            }
            Console.ReadLine();
        }
    }
}
