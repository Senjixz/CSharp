using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsInC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number do you want to repeat? ");
            string message = Console.ReadLine();

            Console.Write("How many times do you want to repeat the number?");
            int loopCounter = Convert.ToInt32(Console.ReadLine());


            if (loopCounter <=0)
            {
                Console.WriteLine("Apologies, please enter enter a value above 0");
            }
            else
            {


                for (int i = 0; i < loopCounter; i++)
                {
                    Console.WriteLine(message);
                }
                Console.WriteLine("Loop has finished");
            }
        }
    }
}
