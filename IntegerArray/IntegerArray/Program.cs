using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5 };
            int sum = SumOfNumbers(numbers);

            Console.WriteLine("Array lenght is " + numbers.Length);

            if (numbers.Length > 0)
            {
                if (sum >= 0)
                {
                    Console.WriteLine("The total is: " + sum);
                }
            }
            else
            {
                Console.WriteLine("Cannot add up an empty array");
            }
            Console.ReadLine();
        }
        static int SumOfNumbers(int[] numbers)
        {
            if (numbers.Length == 0)
            { 
                return 0;
            }
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }
    }
}
