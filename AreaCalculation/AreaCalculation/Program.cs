using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculation
{
    class Triangle
    {
        public static double CalculateArea(Double width, Double height)
        {
            return (width * height) / 2;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the width of the triangle: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the height of the triangle: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double area = Triangle.CalculateArea(width, height);
            Console.WriteLine($"The area of the triangle is {area}");

            Console.ReadLine();
        }
    }
}
