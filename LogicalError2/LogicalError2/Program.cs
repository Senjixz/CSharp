using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalError2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an age number");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 29)
            {
                Console.WriteLine("Over 18");
            }
            else if (age < 39)
            {
                Console.WriteLine("Over 30");
            }
            else if (age < 100)
            {
                Console.WriteLine("Over 50");
            }

            Console.ReadLine();
        }
    }
}
