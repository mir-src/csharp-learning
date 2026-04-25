using System;

namespace InventorySystem;

class Program
{
    class Inventory
    {
        public Dictionary<string,int> Storage { get; private set; }

        public Inventory()
        {
            Storage = new Dictionary<string, int>();
        }
        public void AddToInventory(string product, int amount)
        {
            Storage[product] = amount;
        }
        public void RemoveStock(string product)
        {
            if (Storage.Remove(product))
            {
                Console.WriteLine("Product removed succesfully.");
            }
            else
            {
                Console.WriteLine("Product doesn't exist.");
            }
        }
    }
    public static void Main(string[] args)
    {
        Inventory inventory = new Inventory();
        while (true)
        {
            Console.Clear();
            Console.WriteLine("--- Menu ---");
            Console.WriteLine("1. Add to inventory");
            Console.WriteLine("2. Delete from inventory");
            Console.WriteLine("3. Display Inventory");
            Console.WriteLine("4. Quit Menu");

            string choice = Helpers.ReadString();
            switch (choice)
            {
                case "1":
                    Console.Write("Product name: ");
                    string c1Product = Helpers.ReadString();
                    Console.WriteLine();

                    Console.Write("Amount: ");
                    int c1Amount = Helpers.ReadInt();
                    Console.WriteLine();

                    inventory.AddToInventory(c1Product, c1Amount);
                    Console.WriteLine($"Added: {c1Product} | {c1Amount}");
                    break;
                case "2":
                    Console.Write("Product name: ");
                    string c2Product = Helpers.ReadString();
                    inventory.RemoveStock(c2Product);
                    break;
                case "3":
                    foreach (KeyValuePair<string,int> item in inventory.Storage)
                    {
                        Console.WriteLine($"Key: {item.Key} | Value: {item.Value}");
                    }
                    break;
                case "4":
                    return;
            }

            Console.WriteLine("\nType any key to return to menu...");
            Console.ReadKey();
        }
    }
}