using System;
using System.Collections.Generic;

class Program
{
    // A Dictionary to store items and keys
    static Dictionary<string, string> Items = new Dictionary<string, string>();

    static void Main()
    {
        bool exitProgram = false;

        while (!exitProgram)
        {
            // Display options
            Console.WriteLine("1. Add an item and its definition");
            Console.WriteLine("2. Remove an item");
            Console.WriteLine("3. Show all items and their definitions");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option 1-4: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Adds the item
                    AddItem();
                    break;

                case "2":
                    // Removes the item
                    RemoveItem();
                    break;

                case "3":
                    // Shows all items
                    ShowItems();
                    break;

                case "4":
                    // Exits the program
                    exitProgram = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please choose an option between 1 and 4.");
                    break;
            }
        }

        Console.WriteLine("Exiting the program...");
    }

    // Method to add an item and its definition to the dictionary
    static void AddItem()
    {
        Console.Write("Enter the item name: ");
        string item = Console.ReadLine();

        Console.Write("Enter the definition of the item: ");
        string definition = Console.ReadLine();

        // Checks if the item already exists in the dictionary
        if (Items.ContainsKey(item))
        {
            Console.WriteLine("This item already exists. Do you want to overwrite it? (yes/no): ");
        }
        else
        {
            // Adds the item to the dictionary
            Items.Add(item, definition);
            Console.WriteLine("Item added successfully.");
        }
    }

    // Method to remove an item from the dictionary
    static void RemoveItem()
    {
        Console.Write("Enter the item name to remove: ");
        string itemToRemove = Console.ReadLine();

        // Check if the item exists in the dictionary
        if (Items.ContainsKey(itemToRemove))
        {
            // Remove the item
            Items.Remove(itemToRemove);
            Console.WriteLine("Item removed successfully.");
        }
        else
        {
            Console.WriteLine("Item not found.");
        }
    }
    static void ShowItems()
    {
        if (Items.Count > 0)
        {
            Console.WriteLine("Items and their definitions:");
            foreach (var kvp in Items)
            {
                Console.WriteLine($"Item: {kvp.Key}, Definition: {kvp.Value}");

            }
        }
    }
}