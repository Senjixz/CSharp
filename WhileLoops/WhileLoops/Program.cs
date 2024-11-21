using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // For Loop example
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //int i = 0;

            //while (i < 10)
            //{
            //    i++;
            //    Console.WriteLine(i);
            //}

            Console.WriteLine("Enter the first number: ");
            string numberAInput = Console.ReadLine();
            int numberA = Convert.ToInt32(numberAInput);

            Console.WriteLine("Enter the second number: ");
            string numberBInput = Console.ReadLine();
            int numberB = Convert.ToInt32(numberBInput);

            int answer = numberA * numberB;
            int actualAnswer = 0;

            Console.WriteLine("Value of " + numberA + " x " + numberB + ": ");
            Console.WriteLine();
            // while Example
            // while will check the conditions first and then execute the statment
            /*
            while(answer != actualAnswer)
            {
                Console.Write("Enter your answer: ");
                string answerInput = Console.ReadLine();
                actualAnswer = Convert.ToInt32(answerInput);

                if(answer != actualAnswer)
                {
                    Console.WriteLine("Close but it was wrong");
                }
            }
            */
            // Do while example
            // Do while will execute the statment at least once and then checks
            do
            {
                Console.Write("Enter your answer: ");
                string answerInput = Console.ReadLine();
                actualAnswer = Convert.ToInt32(answerInput);
                if (answer != actualAnswer)
                {
                    Console.WriteLine("Close but it was wrong");
                    Console.WriteLine();
                }

            } while (answer != actualAnswer);
            Console.WriteLine("Well done!");
            Console.ReadLine();
        }
    }
}
