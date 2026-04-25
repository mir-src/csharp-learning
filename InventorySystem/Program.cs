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
            Storage.Remove(product);
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
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    return;
            }

            Console.WriteLine("\nType any key to return to menu...");
            Console.WriteLine("");
        }
    }
}