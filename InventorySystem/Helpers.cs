using System;
using System.Collections.Generic;
using System.Text;

namespace InventorySystem
{
    internal class Helpers
    {
        public static int ReadInt()
        {
            while (true)
            {
                var intVar = Console.ReadLine();
                if (int.TryParse(intVar, out var intVarOut)) return intVarOut;
                Console.WriteLine("Invalid integer.");
            }
        }
        public static string ReadString()
        {
            while (true) {
                var stringVar = Console.ReadLine();
                if (!string.IsNullOrEmpty(stringVar))
                {
                    return stringVar;
                }
                Console.WriteLine("Invalid string.");
            }
        }
    }
}
