using System;

namespace InventorySystem;

class Program
{
    class Inventory
    {
        public Dictionary<string,int> Storage { get; set; }

        public Inventory()
        {
            Storage = new Dictionary<string, int>();
        }
    }
    public static void Main(string[] args)
    {
        Inventory testObject = new Inventory();
        testObject.Storage["Cake"] = 100;
        testObject.Storage["Pepsi"] = 210;
        foreach (KeyValuePair<string,int> item in testObject.Storage) {
            Console.WriteLine($"Key: {item.Key} | Value: {item.Value}");
        }
    }
}