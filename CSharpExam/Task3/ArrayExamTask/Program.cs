using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExamTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //an Array list with names
            string[] names = { "Alice", "John", "Mia" };

            //Prints out Hello for each name before printing them
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"Hello {names[i]}");
            }

            //List of number Array
            int[] numbers = new int[]
            {
                12, 45, 78, 3, 99, 21, 8
            };

            //Sorts the array in a descending order
            Array.Sort(numbers);

            int[] sortedNumbers = new int[numbers.Length];
            int x = 0;

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                sortedNumbers[x] = numbers[i];
                x++;
            }

            //Clears the last element in the sorted array
            Array.Clear(numbers, 3, numbers.Length);

            //Prints the sorted and cleared array
            foreach (var num in sortedNumbers)
            {
                Console.Write($"{num} ");
            }

            Console.ReadLine();
        }
    }
}
