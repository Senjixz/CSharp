using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even, " + "(" + number + ")");
            }
            else
            {
                Console.WriteLine("The number is odd, " + "(" + number + ")");
            }

            Console.ReadLine();
        }
    }
}
