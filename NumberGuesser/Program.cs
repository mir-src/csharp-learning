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
                continue;
            }

            switch (choice)
            {
                case 1:
                    Random randomNumber = new Random();
                    int randomNr = randomNumber.Next(1, 11);
                    while (true)
                    {
                        Console.Clear();
                        Console.Write("Enter number: ");
                        if (!int.TryParse(Console.ReadLine(), out var user))
                        {
                            Console.WriteLine("Invalid number.");
                            continue;
                        }

                        if (user == randomNr)
                        {
                            Console.WriteLine("You guessed the number correctly.");
                            break;
                        }
                        else
                        {
                            if (user < randomNr) {
                                Console.WriteLine("The number is HIGHER.");
                            }
                            if (user > randomNr)
                            {
                                Console.WriteLine("The number is LOWER");
                            }
                        }
                        Console.WriteLine("\nTry again. Press any button...");
                        Console.ReadKey();
                    }

                    break;
                case 2:
                    return;
            }
            Console.WriteLine("\nType any key to return to Menu...");
            Console.ReadKey();
        }
    }
} 
