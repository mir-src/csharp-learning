using System;
using System.Collections.Generic;

namespace ConsoleAnki;

class Program
{
    class Flashcard
    {
        public int Id { get; set; }
        public string Front { get; set; }
        public string Back { get; set; }
        public Flashcard(int id, string front, string back)
        {
            Id = id;
            Front = front;
            Back = back;
        }
    }
    class Game
    {
        public static void Start()
        {
            List<Flashcard> cards = new List<Flashcard>();
            int id = 1; 
            while (true)
            {
                Console.Clear();
                Console.WriteLine("--- ANKI CONSOLE ---");
                Console.WriteLine("1. Review Flashcards");
                Console.WriteLine("2. Show Flashcards");
                Console.WriteLine("3. Delete Flashcards");
                Console.WriteLine("4. Add Flashcards");
                Console.WriteLine("5. Quit");

                string choice = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(choice))
                {
                    Console.WriteLine("Invalid choice");
                    continue;
                }

                switch (choice)
                {
                    case "1":
                        break;
                    case "2":
                        Game.ShowCards(cards);
                        break;
                    case "3":
                        break;
                    case "4":
                        Console.Write("Front: ");
                        string c4Front = Console.ReadLine();
                        Console.Write("\n");
                        if (string.IsNullOrWhiteSpace(c4Front))
                        {
                            Console.WriteLine("Invalid Front of the card");
                        }
                        Console.Write("Back: ");
                        string c4Back = Console.ReadLine();
                        Console.Write("\n");
                        if (string.IsNullOrWhiteSpace(c4Front))
                        {
                            Console.WriteLine("Invalid Back of the card");
                        }
                        cards.Add(new Flashcard(id, c4Front, c4Back));
                        id++;
                        Console.WriteLine("Card added succesfully!");
                        break;
                    case "5":
                        return;
                }
                Console.WriteLine("\n Type any key to return to menu...");
                Console.ReadKey();
            }
        }
        public static void ShowCards(List<Flashcard> cards)
        {
            foreach (Flashcard card in cards)
            {
                Console.WriteLine($"{card.Id}. {card.Front}");
            }
        }
    }
    public static void Main(string[] args)
    {
        Game.Start();
    }
}
// TODO: Add delete card from deck flow  
