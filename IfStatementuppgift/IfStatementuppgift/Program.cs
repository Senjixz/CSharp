using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatementuppgift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            Console.Write("What is your age? ");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);

            Console.WriteLine();
            Console.WriteLine("Your name is " + name + " and you age is " + age);

            if (age >= 18)
            {
                Console.WriteLine("You are eligible to vote");
            }
            else if(age <=18)
            {
                Console.WriteLine("You are not eligible to vote");
            }
            if (age >= 0 || age > 150)
            {
                Console.WriteLine("Invalid age!");
            }
        }
    }
}
