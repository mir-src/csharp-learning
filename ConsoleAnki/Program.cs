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
            while (true)
            {
                Console.WriteLine("--- ANKI CONSOLE ---");
                Console.WriteLine("1. Review Flashcards");
                Console.WriteLine("2. Show Flashcards");
                Console.WriteLine("3. Delete Flashcards");
                Console.WriteLine("4. Add Flashcards");
                Console.WriteLine("5. Quit");
                List<Flashcard> cards = new List<Flashcard>();
                cards.Add(new Flashcard(1, "Capital of Japan...", "Tokyo"));
                Game.ShowCards(cards);   
                return;
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
// TODO: Add Flashcard to Deck Flow 
