using System;

namespace TicTacToe;

class Program
{
    enum Cell { Empty, X, O}
    class Utils
    {
        public static void MakeMove(Cell[,] board, Cell player)
        {
            Console.Write("Choose position (1-9)");
            if (!int.TryParse(Console.ReadLine(), out var number))
            {
                Console.WriteLine($"'{number}' is not a number.");
                return;
            }
            if (number < 1 || number > 9)
            {
                Console.WriteLine("The number is not inside the valid range");
                return;
            }
            int row = (number - 1) / 3;
            int col = (number - 1) % 3;
            board[row, col] = player;
        }
        public static void Display(Cell[,] board)
        {
            int position;
            for (int i = 0; i < 3; i++)
            {
                Console.Write("|");
                for (int j = 0; j < 3; j++)
                {
                    position = i * 3 + j + 1;
                    if (board[i, j] == Cell.Empty)
                    {
                        Console.Write($" {position} |");
                    }
                    else
                    {
                        Console.Write($" {board[i, j]} |");
                    }
                }
                Console.Write("\n");
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
            int player = 1;

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
                        if (player == 1)
                        {
                            Utils.MakeMove(board, Cell.O);
                            player = 2;
                        }
                        else
                        {
                            Utils.MakeMove(board, Cell.X);
                            player = 1;
                        }
                        // Todo: Check Win condition
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


