using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The inputs were not being converted to an int before
            Console.Write("Enter the first number: ");
            int input1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int input2 = Convert.ToInt32(Console.ReadLine());

            int sum = Add(input1, input2);
            int difference = Subtract(input1, input2);
            int product = Multiply(input1, input2);
            int quotient = Divide(input1, input2);

            Console.WriteLine($"The sum of the numbers is: {sum}");
            Console.WriteLine($"The difference of the numbers is: {difference}");
            Console.WriteLine($"The product of the numbers is: {product}");
            Console.WriteLine($"The quotient of the numbers is: {quotient}");

            Console.ReadLine();
        }

        //The methods were all in string instead of int and had unnecessary quotation marks "" on the methods on calculating the numbers
        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }


        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
