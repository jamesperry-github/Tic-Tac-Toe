using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        // declare game parameters
        static int[] board = new int[9];
        private static void printBoard()
        {
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
            board[0] = 0;
            board[1] = 0;
            board[2] = 0;
            board[3] = 0;
            board[4] = 0;
            board[5] = 0;
            board[6] = 0;
            board[7] = 0;
            board[8] = 0;
            Console.WriteLine("HERE IS THE BOARD");
            printBoard();

            int userTurn;
            while (true)
            {

                Console.WriteLine("Please enter a number from 0 to 8");
                userTurn = int.Parse(Console.ReadLine());
                if(userTurn > 9)
                {
                    Console.WriteLine("Your move is out of bounds");
                }
                else
                {
                    Console.WriteLine("You type " + userTurn);
                    board[userTurn] = 1;
                    printBoard();
                }
            }
        }
    }
}

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
