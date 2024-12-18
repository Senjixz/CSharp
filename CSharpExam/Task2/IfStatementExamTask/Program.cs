using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatementExamTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Asks the user for a number
            Console.WriteLine("Please enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            //If and else-if statements to check the numbers
            //Checks if the number is positive
            if (num > 0)
            {
                Console.WriteLine("The number is positive");
            }
            //Checks if the number is negative
            else if (num < 0)
            {
                Console.WriteLine("The number is negative");
            }
            //Checks if the number is zero
            else if (num == 0)
            {
                Console.WriteLine("The number is zero");
            }
            //Checks if the number is Invalid
            else
            {
                Console.WriteLine("Invalid Input");
            }
            Console.ReadLine();
        }
    }
}
