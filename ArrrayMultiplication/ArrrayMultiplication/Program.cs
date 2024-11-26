using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrrayMultiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 7;
            int length = 5;

            int[] multiplicationArray = new int[length];
            for (int i = 0; i < length; i++)
            {
                multiplicationArray[i] = num1 * (i + 1);
            }

            Console.WriteLine($"Multiplication Table for {num1}:");
            foreach (int value in multiplicationArray)
            {
                Console.WriteLine(value);
            }

                Console.ReadLine();
        }
    }
}
