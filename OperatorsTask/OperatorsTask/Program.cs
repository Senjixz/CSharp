using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 2;
            int num2 = 5;
            int num3 = 7;
            int num4 = 3;
            int num5 = 10;
            int num6 = 4;

            Console.WriteLine(num1 += num2);
            Console.WriteLine(num3 *= num4);
            Console.WriteLine(num5 /= num6);

            Console.WriteLine(++num6);
            Console.WriteLine(--num6);
            Console.WriteLine(num6++);
            Console.WriteLine(num6--);


            Console.ReadLine();
        }
    }
}
