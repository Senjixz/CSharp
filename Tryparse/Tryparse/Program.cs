﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tryparse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool success = true;

            while (success)
            {

                Console.WriteLine("Enter a number: ");
                string numInput = Console.ReadLine();
                //int num = Convert.ToInt32(numInput);
                if (int.TryParse(numInput, out int num))
                {
                    Console.WriteLine(num);
                }
                else
                {
                    Console.WriteLine("Failed to convert!");
                }
            }




            Console.ReadLine();
        }
    }
}
