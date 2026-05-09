using System;

namespace TicTacToe;

class Program
{
    enum Cell { E, X, O}
    class Utils
    {
        public static void Display(Cell[,] board)
        {
            for (int i = 0; i < 3; i++){
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(board[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
    public static void Main(string[] args)
    {
        Cell[,] board = new Cell[3, 3];
        while (true)
        {
            Console.Clear();
            Console.WriteLine("1. Start Game");
            Console.WriteLine("2. Quit");

            string choice = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(choice))
            {
                continue;
            }

            switch (choice)
            {
                case "1":
                    while (true)
                    {
                        Utils.Display(board);
                        Console.WriteLine("Make a move: ");
                    }
                    break;
                case "2":
                    return;
            }

            Console.WriteLine("\n Press a key to advance");
            Console.ReadKey();
        }
    }
}


