using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParseTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a text: ");

                int num = something(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine($"Conversion succeeded: {Console.ReadLine()}");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            Console.ReadLine();
        }
        static int something(int yuh)
        {
            Convert.ToString(yuh);
            if (yuh == 0)
            {
                Console.WriteLine($"Conversion succeeded: {Console.ReadLine()}");
            }
            else if (yuh == 1)
            {
                Console.WriteLine($"Conversion failed: {Console.ReadLine()}");
            }
            return yuh;
        }
    }
    }
}
