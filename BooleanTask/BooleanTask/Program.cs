using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;
            int num4 = 4;

            bool isTrue = true;

            bool resultAnd = isTrue && (num1 > num3 && num2 <  num4);
            bool resultOr = isTrue || (num1 == num3 || num2 == num4);
            bool resultNot = !isTrue;

            if (num1 > num3)
            {
                Console.WriteLine("num1 is greater than num3");
            }
            else if (num1 < num3)
            {
                Console.WriteLine("num1 is not greater than num3");
            }
            if (num2 < num4)
            {
                Console.WriteLine("num2 is less than num4");
            }
            else if (num2 > num4)
            {
                Console.WriteLine("num2 is not less than num4");
            }
            if (num1 == num4)
            {
                Console.WriteLine("num1 is equal to num4");
            }
            else if (num1 != num4)
            {
                Console.WriteLine("num1 is not equal to num4");
            }
            if (num2 != num3)
            {
                Console.WriteLine("num2 is not equal to num3");
            }
            else if (num2 == num3)
            {
                Console.WriteLine("num2 is equal to num3");
            }

            Console.WriteLine(resultAnd);
            Console.WriteLine(resultOr);

            Console.ReadLine();
        }
    }
}
