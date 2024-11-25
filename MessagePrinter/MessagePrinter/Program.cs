using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagePrinter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the message: C# is fun I am going to code C# tomorrow ");
            var message = Console.ReadLine();
            Console.WriteLine(message);

            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            Console.WriteLine(messageArray);

            foreach (char letter in message)
            Console.WriteLine(letter);

            char[] reverseLetter = message.ToCharArray();
            Array.Reverse(reverseLetter);
            foreach (char letter in reverseLetter)
            Console.WriteLine(letter);

            Console.ReadLine();
            
        }
    }
}
