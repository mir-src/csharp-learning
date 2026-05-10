using System;

namespace TicTacToe;

class Program
{
    enum Cell { Empty, X, O}
    class Utils
    {
        public static void MakeMove(Cell[,] board, Cell player)
        {
            Console.Write("Choose position (1-9): ");
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
        public static Cell CheckWin(Cell[,] board)
        {
            Cell c = board[0, 0];

            if (c != Cell.Empty && c == board[1, 1] && c == board[2, 2])
            {
                return c;
            }
            c = board[0, 2];
            if (c != Cell.Empty && c == board[1, 1] && c == board[2, 0])
            {
                return c;
            }
            

            for (int row=0; row<3; row++)
            {
                c = board[row, 0];
                if (c != Cell.Empty && c == board[row, 1] && c == board[row, 2]) 
                {
                    return c;
                }
            }
            for (int col=0; col<3; col++)
            {
                c = board[0, col];
                if (c != Cell.Empty && c == board[1, col] && c == board[2, col])
                {
                    return c;
                }
            }
            return Cell.Empty;
        }
    }
    public static void Main(string[] args)
    {
        Cell[,] board = new Cell[3, 3];
        int player = 1;
        int moves = 9;

        while (true)
        {
            if (moves <= 0)
            {
                Console.WriteLine("No one has won...");
                return;
            }
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
            Cell win = Utils.CheckWin(board);
            if (win == Cell.O)
            {
                Console.WriteLine($"Player 1 has WON ({win})");
                return;
            }
            if (win == Cell.X)
            {
                Console.WriteLine($"Player 2 has WON ({win})");
                return;
            }
            moves--;
        }
    }
}


