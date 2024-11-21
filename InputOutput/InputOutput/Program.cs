using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?: " );
            string userName = Console.ReadLine();

            Console.WriteLine("Your name is " + userName);
            Console.WriteLine("Welcome to C# coding " + userName + "!");
        }
    }
}
