using System;

namespace NumberGuesser;

class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("--- Number Guesser ---");
            Console.WriteLine("1. Play game");
            Console.WriteLine("2. Quit");
            
            if (!int.TryParse(Console.ReadLine(), out var choice))
            {
                Console.WriteLine("Invalid number.");
            }

            switch (choice)
            {
                case 1:
                    break;
                case 2:
                    return;
            }
            Console.WriteLine("\nType any key to return to Menu...");
            Console.ReadKey();
        }
    }
} 
