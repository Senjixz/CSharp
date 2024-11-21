using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////User input "Name"
            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();

            ////User input
            //Console.Write("Enter your age: ");
            //string ageInput = Console.ReadLine();
            //int age = Convert.ToInt32(ageInput);

            ////Writes it out
            //Console.WriteLine();
            //Console.WriteLine("Your name is " + name + " and your age is " + age);

            ////If checking your age
            //// == > >= < <= && 
            ///*if(age >=18 && age <= 20)
            //{
            //    Console.WriteLine("You are between 18 and 20");
            //}
            //else if(age >=20)
            //{
            //    Console.WriteLine("You are 21 or older");
            //}
            //*/

            //if (age < 0 || age > 150)
            //{
            //    Console.WriteLine("Invalid age!");
            //}
            //else
            //{
            //    if (age >= 18 && age <= 20)
            //    {
            //        Console.WriteLine("You are between 18 and 20");
            //    }
            //    else if (age >= 21)
            //    {
            //        Console.WriteLine("You are 21 or older");
            //    }

            //}

            //User Input
            Console.Write("Enter the first number: ");
            string numberAInput = Console.ReadLine();
            int numberA = Convert.ToInt32(numberAInput);

            //User Input
            Console.Write("Enter the second number: ");
            string numberBInput = Console.ReadLine();
            int numberB = Convert.ToInt32( numberBInput);

            // Int variable = numA * numB
            // + - * /
            int answer = numberA + numberB;

            //Console.Write("Value of " + numberA + " * " + numberB + ": " + answer);
            Console.Write("Value of " + numberA + " * " + numberB + ": ");

            // User Input to guess answer
            string answerInput = Console.ReadLine();
            int actualAnswer = Convert.ToInt32(answerInput);

            // If check for guessing answer
            if(answer == actualAnswer)
            {
                Console.WriteLine("Correct answer");
            }
            else if (answer!= actualAnswer)
            {
                Console.WriteLine("Close but it was wrong");
            }


            Console.ReadLine();
        }
    }
}
