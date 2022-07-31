using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        // declare game parameters
        static int[] board = new int[9];
        static int userTurn;
        static int computerTurn;
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
        static void determineWinner()
        {

        }
        static void Main(string[] args)
        {
            Console.WriteLine("NEW GAME!");
            printBoard();
            //int userTurn;
            //int computerTurn;
            Random rand = new Random();
            Console.WriteLine("Please enter a number from 0 to 8");
            userTurn = int.Parse(Console.ReadLine());
            Console.WriteLine("You select " + userTurn);
            computerTurn = rand.Next(8);
            Console.WriteLine("Computer selects " + computerTurn);
            while (true)
            {
                while (userTurn == -1 || board[userTurn] != 0)
                {
                    Console.WriteLine("Please enter a number from 0 to 8");
                    userTurn = int.Parse(Console.ReadLine());
                    Console.WriteLine("You select " + userTurn);
                }
                board[userTurn] = 1;
                // computer moveset
                while (computerTurn == -1 || board[computerTurn] != 0)
                {
                    computerTurn = rand.Next(8);
                    Console.WriteLine("Computer selects " + computerTurn);
                }
                board[computerTurn] = 2;
                printBoard();
            }
        }
    }
}
