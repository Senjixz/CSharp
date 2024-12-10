using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CLassFields
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Initial product details: ");
            Product product = new Product("Phone", 599, 5);
            Console.WriteLine(product.GetProductDetails());

            Console.WriteLine("Updated product details: ");
            product.SetName("Laptop");
            product.SetPrice(999.99);
            product.SetStock(10);

            Console.WriteLine(product.GetProductDetails());
            Console.ReadLine();
        }
    }
}
class Product
{
    private string Name { get; set; }
    private double Price { get; set; }
    private int Stock { get; set; }

    public Product(string name, double price, int stock)
    {
        Name = name;
        Price = price;
        Stock = stock;
    }
    public void SetName(string name)
    {
        this.Name = name;
    }

    public string GetName()
    {
        return this.Name;
    }
    public void SetPrice(double price)
    {
        this.Price = price;
    }
    public void SetStock(int stock)
    {
        this.Stock = stock;
    }

    public int GetStock()
    {
        return this.Stock;
    }

    public string GetProductDetails()
    {
        return $"Name: {Name}, Price: {Price}, Stock: {Stock}";
    }
    public double GetPrice()
    {
        return this.Price;
    }
}
