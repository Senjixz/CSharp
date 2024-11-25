using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PasswordChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a password: ");
            string password = Console.ReadLine();

            Console.Write("Confirm password: ");
            string compare = Console.ReadLine();

            if (password == string.Empty)
            {
                Console.WriteLine("Please enter a password");
            }
            else if (password == compare)
            {
                Console.WriteLine("Passwords match");
            }
            if (password != compare)
            {
                Console.WriteLine("Passwords do not match");
            }


                Console.ReadLine();


        }
    }
}
