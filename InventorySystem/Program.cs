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
        Inventory objectInventory = new Inventory();
        int mAmount = Helpers.ReadInt();
        string mProduct = Helpers.ReadString();
        objectInventory.AddToInventory(mProduct,mAmount);
        foreach (KeyValuePair<string,int> item in objectInventory.Storage)
        {
            Console.WriteLine($"Key: {item.Key} | Value: {item.Value}");
        }

        objectInventory.RemoveStock(mProduct);
        Console.WriteLine("After removal");
        foreach (KeyValuePair<string,int> item in objectInventory.Storage)
        {
            Console.WriteLine($"Key: {item.Key} | Value: {item.Value}");
        }
    }
}