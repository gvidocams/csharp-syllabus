﻿using System;

namespace TicTacToe
{
    class Program
    {
        private static char[,] board = new char[3, 3];
        private static char turn = 'O';

        private static void Main(string[] args)
        {
            InitBoard();

            StartGame();

            if (CheckWin() == 1)
            {
                Console.WriteLine($"\nPlayer {turn} won!");
            }
            else
            {
                Console.WriteLine("\nIt's a draw!");
            }
        }

        private static void StartGame()
        {
            while (CheckWin() == 0)
            {
                ChangeTurn();

                Console.Clear();

                DisplayBoard();

                GetUserInput();

                Console.Clear();

                DisplayBoard();
            }
        }

        private static void InitBoard()
        {
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                    board[r, c] = ' ';
            }
        }

        private static void DisplayBoard()
        {
            Console.WriteLine("     0 1 2");
            Console.WriteLine();
            Console.WriteLine("  0  " + board[0, 0] + "|" + board[0, 1] + "|" + board[0, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  1  " + board[1, 0] + "|" + board[1, 1] + "|" + board[1, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  2  " + board[2, 0] + "|" + board[2, 1] + "|" + board[2, 2]);
        }

        private static void GetUserInput()
        {
            Console.WriteLine($"\nPlayer {turn}!");

            Console.Write("Choose your location (row, column): ");
            int[] userChoice = Array.ConvertAll(Console.ReadLine().Split(' '), input => Convert.ToInt32(input));

            if(IsAValidChoice(userChoice))
            {
                int row = userChoice[0];
                int column = userChoice[1];

                board[row, column] = turn;
            }
            else
            {
                Console.Clear();
                DisplayBoard();

                Console.WriteLine("\nInvalid input! Wrong format or already filled cell!");

                GetUserInput();
            }
        }

        private static void ChangeTurn()
        {
            if (turn == 'X')
            {
                turn = 'O';
            }
            else
            {
                turn = 'X';
            }
        }
        
        private static bool IsAValidChoice(int[] choice)
        {
            int row = choice[0];
            int column = choice[1];

            bool isInBounds = row <= 2 || column <= 2 || row >= 0 || column >= 0;
            bool isEmpty = board[row, column] == ' ';

            return isInBounds && isEmpty;
        }

        private static int CheckWin()
        {
            //Horizontal winning conditions
            if (board[0, 0] == board[0, 1] && board[0, 1] == board[0, 2] && board[0, 0] != ' ' ||
                board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2] && board[1, 0] != ' ' ||
                board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2] && board[2, 0] != ' ' ||
            //Vertical winning conditions
                board[0, 0] == board[1, 0] && board[1, 0] == board[2, 0] && board[0, 0] != ' ' ||
                board[0, 1] == board[1, 1] && board[1, 1] == board[2, 1] && board[0, 1] != ' ' ||
                board[0, 2] == board[1, 2] && board[1, 2] == board[2, 2] && board[0, 2] != ' ' ||
            //Diagonal winning conditions
                board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != ' ' ||
                board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != ' ')
            {
                return 1;
            }
            //Checking if draw
            else if (board[0, 0] != ' ' && board[0, 1] != ' ' && board[0, 2] != ' ' && board[1, 0] != ' ' && board[1, 1] != ' ' && board[1, 2] != ' ' && board[2, 0] != ' ' && board[2, 1] != ' ' && board[2, 2] != ' ')
            {
                return -1;
            }

            return 0;
        }
    }
}
