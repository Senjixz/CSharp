using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleArea
{
    class circle
    {
        public double Radius { get; set; }

        public circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            circle circle = new circle(1.5);
            double area = circle.CalculateArea();
            Console.WriteLine($"Area of the circle is: {area}");
            Console.ReadLine();
        }
    }
}
