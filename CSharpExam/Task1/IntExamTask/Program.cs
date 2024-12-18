using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntExamTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Asks the user for a number and converts it into an integer like the rest
            Console.WriteLine("Please enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
        
            Console.WriteLine("Please enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Please enter a number: ");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a text: ");
            string text = Console.ReadLine();

            //prints out all user inputs and definition of each code's use
            Console.WriteLine($"{num}, {num1}, {num2}, {text}");
            Console.WriteLine("Int is used to represent whole numbers in the Console");
            Console.WriteLine("Double is used to represent decimal numbers with a high degree of precision.");
            Console.WriteLine("Float is a crucial data type in C#, as it denotes single-precision floating-point numbers.");
            Console.WriteLine("String is used to represent text in the console");
            Console.ReadLine();
        }
    }
}
