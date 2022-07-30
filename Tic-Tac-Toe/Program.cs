using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        private static void printBoard()
        {
            // declare game parameters
            int[] board = new int[9];
            board[0] = 0; //unoccupied
            board[1] = 0;
            board[2] = 0;
            board[3] = 1; //player 1 (X)
            board[4] = 2; //player 2 (O)
            board[5] = 0;
            board[6] = 0;
            board[7] = 0;
            board[8] = 1;

            for (int i = 0; i < 9; i++)
            {
                //Console.WriteLine("Square" + i + " contains " + board[i]);
                // print X or O for each square;
                // '.' means unoccupied; 1 == player 1 (X); 2 == player 2 (O);
                if (board[i] == 0)
                {
                    Console.Write(".");
                }
                if (board[i] == 1)
                {
                    Console.Write("X");
                }
                if (board[i] == 2)
                {
                    Console.Write("O");
                }
                // print a new line every 3rd character;
                if (i == 2 || i == 5 || i == 8)
                {
                    Console.WriteLine("");
                }
            }
        }
        static void Main(string[] args)
        {
            printBoard();
        }
    }
}

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
