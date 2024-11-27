using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortRevRem_Find
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]
            {
                45, 12, 78, 34, 89, 23,
            };

            foreach(var orig in numbers)
            {
                Console.WriteLine(orig);
            }

            Array.Sort(numbers);

            foreach (int num in numbers)
            {
                Console.WriteLine($"{num}");
            }

            Array.Sort(numbers);
            Array.Reverse(numbers);

            foreach (var item in numbers)
            {
                Console.Write($"{item} ");
            }

            int numToRemove = 78;
            numbers = numbers.Where(val => val != numToRemove).ToArray();
            foreach (int num in numbers)
            {
                Console.WriteLine($"{num}");
            }

            int search = 34;

            int position = Array.IndexOf(numbers, search);

            if (position > -1)
            {
                Console.WriteLine($"{search} has been found at position {position + 1}");
            }
            else
            {
                Console.WriteLine($"Number {search} does not exist");
            }

            Console.ReadLine();
        }
    }
}
