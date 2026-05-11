using System;
using System.Collections.Generic;

namespace ConsoleAnki;

class Program
{
    class Flashcard
    {
        public string Front { get; set; }
        public string Back { get; set; }
        public Flashcard(string front, string back)
        {
            Front = front;
            Back = back;
        }
    }
    public static void Main(string[] args)
    {
        List<Flashcard> flashcards = new List<Flashcard>();
        flashcards.Add(new Flashcard("The capital of Japan is...", "Tokyo"));
        flashcards.Add(new Flashcard("The capital of France is...", "Paris"));
        foreach (Flashcard card in flashcards)
        {
            Console.WriteLine(card.Front);
            Console.WriteLine(card.Back);
        }
    }
}
// Front, Back, Pass / Fail - Simple answer system
