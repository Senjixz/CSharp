using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsTask
{
    class MathOperations
    {
        public int Add(int a, int b)
        { 
            return a + b;
        }
        public int Subtract(int a, int b)
        { 
            return a - b;
        }
        public int Multiply(int a, int b)
        { 
            return a * b;
        }
        public double Divide(int a, int b)
        { 
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            return (double)a / b;
        }
        public double Power(int baseNumber, int exponent)
        { 
            return Math.Pow(baseNumber, exponent);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MathOperations mathOps = new MathOperations();

            try
            {
                Console.Write("Enter the first number: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Enter the second number: ");
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("\nResults:");
                Console.WriteLine($"Addition: {num1} + {num2} = {mathOps.Add(num1, num2)}");
                Console.WriteLine($"Subtraction: {num1} - {num2} = {mathOps.Subtract(num1, num2)}");
                Console.WriteLine($"Multiplication: {num1} * {num2} = {mathOps.Multiply(num1, num2)}");

                try
                {
                    Console.WriteLine($"Division: {num1} / {num2} = {mathOps.Divide(num1, num2)}");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

                Console.WriteLine($"Power: {num1} ^ {num2} = {mathOps.Power(num1, num2)}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter valid integers.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}