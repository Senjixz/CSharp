using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
           Console.WriteLine("1");
           Console.WriteLine("2");
           Console.WriteLine("3");
           Console.WriteLine("4");
           Console.WriteLine("5");
           */
            /*
            for(int i = 0; i < 6; i++)
            {
                Console.WriteLine(i);
            }

            for(int i = 1; i <= 10; i +=2)
            {
                Console.WriteLine(i);
            }
            */

            Console.WriteLine("What do you to repeat? ");
            string message = Console.ReadLine();

            Console.Write("How many times do you want to repeat the message?");
            int loopCounter = Convert.ToInt32(Console.ReadLine());


            if (loopCounter <= 0)
            {
                Console.WriteLine("sorry, please enter a value above 0");
            }
            else
            {


                for (int i = 0; i < loopCounter; i++)
                {
                    Console.WriteLine(message);
                }
                Console.ReadLine();
            }
        }
    }
}







/*
Console.WriteLine("How many times do you want to loop?");
int loopCounter = Convert.ToInt32(Console.ReadLine());
if (loopCounter <= 0)
{
    Console.WriteLine("sorry, please enter a value above 0");
}
else
{


    for (int i = 0; i < loopCounter; i++)
    {
        Console.WriteLine("Loop: " + i);
    }
    Console.ReadLine();
}
*/
    

