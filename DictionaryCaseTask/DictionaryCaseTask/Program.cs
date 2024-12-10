using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryCaseTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> options = new Dictionary<int, string>
            {
                {1, "Add Subject" },
                {2, "Remove Subject" },
                {3, "Show all" },
                {4, "Exit" }
            };

            bool exit = false;
            while (!exit)
            {

                for (int i = 0; i < options.Count; i++)
                {
                    KeyValuePair<int, string> pair = options.ElementAt(i);
                    Console.WriteLine($"{pair.Key} - {pair.Value}");
                }

                List<string> list = new List<string>()
            {
                "Math Bob"
            };


                Console.WriteLine("Choose option between 1 and 4");
                int option = Convert.ToInt32(Console.ReadLine());

                if (option == 1)
                {
                    Console.WriteLine("Enter the name of the new subject: ");
                    string newSubject = Console.ReadLine();
                    Console.WriteLine("Teachers name: ");
                    string newTeacher = Console.ReadLine();

                    string newList = newSubject + newTeacher;

                    list.Add(newList);
                    Console.WriteLine("Subject and teacher added");
                }
                else if (option == 2)
                {
                    Console.WriteLine("Enter the name of the subject you wish to remove: ");
                    list.Remove(Console.ReadLine());
                    Console.WriteLine("Subject successfully removed");
                }

                switch (option)
                {
                    case 3:
                        Console.WriteLine("Showing all");
                        Console.WriteLine(list);
                        break;
                    case 4:
                        exit = true;
                        Console.WriteLine("Exiting program");
                        break;
                }
                Console.ReadLine();
            }
            
            
        }
    }
}
