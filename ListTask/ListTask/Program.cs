using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> FoodList = new List<string>();
            FoodList.Add("Tomato");
            FoodList.Add("Cucumber");
            FoodList.Add("Paprika");
            for (int i = 0; i < FoodList.Count; i++)
            {
                Console.WriteLine(FoodList[i]);
            }

            Console.WriteLine("Please enter what you would like to add to the list or simply type 'stop' to exit the program: ");
            string userInput = Console.ReadLine();

            while (true)
            {
                if (userInput.ToLower() == "stop")
                {
                    Console.WriteLine("Exiting program, showing final food list");
                    for (int i = 0; i < FoodList.Count; i++)
                    {
                        Console.WriteLine(FoodList[i]);
                    }
                    break;
                }
                if (!string.IsNullOrWhiteSpace(userInput))
                {
                    FoodList.Add(userInput);
                    Console.WriteLine($"'{userInput}' has been added to the list");
                    Console.WriteLine("Current food list");
                    for (int i = 0; i < FoodList.Count; i++)
                    {
                        Console.WriteLine(FoodList[i]);
                    }
                    break;
                }
            }

            Console.ReadLine();
        }
    }
}
