using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeVerification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var name = "John";

            Console.WriteLine("Welcome," + name ,"!");

            Console.Write("Please enter your age: ");
            string ageInput = Console.ReadLine();

            int age = int.Parse(ageInput);

            const int LegalAge = 18;
            
            if (age >= LegalAge)
            {
                Console.WriteLine("You are an adult");
            }
            else
            {
                Console.WriteLine("You are under the legal age");
            }
            int counter = 1;
            while (counter <= 5)
            {
                Console.WriteLine(counter);
                counter++;
            }


            switch(counter)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                default:
                    Console.WriteLine("Invalid Number");
                    break;
            }
            Console.WriteLine("the loop ran and printed numbers from 1 to 5.");
            Console.WriteLine("The switch statement was executed based on the final value of the counter,");
        }
    }
}
