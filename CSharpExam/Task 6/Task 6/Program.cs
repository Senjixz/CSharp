using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Book
    {

        //
        public string Name { get; set; }
        public string Publisher { get; set; }
        public string Year { get; set; }
        public string Genre { get; set; }
        public Book(string name, string publisher, string year, string genre)
        {
            Name = name;
            Publisher = publisher;
            Year = year;
            Genre = genre;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Publisher: {Publisher}, Year: {Year}, Genre: {Genre}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("To Kill a Mockingbird", "Harper Lee", "1960", "Fiction");
            book1.DisplayInfo();
            Console.WriteLine();
            Book book2 = new Book("MyBook", "Stian", "2024", "C#");
            book2.DisplayInfo();
            Console.ReadLine();
            
        }
    }
}
