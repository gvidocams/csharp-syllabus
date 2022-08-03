using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Hangman
{
    internal class Program
    {
        private static string[] words = { "apple", "banana", "city", "dog", "certification", "codelex" };
        private static string wordToSolve = "";
        private static string misses = "";

        static void Main(string[] args)
        {
            Game();
        }

        static void Game()
        {
            wordToSolve = GetWord();
            char[] gameLine = InitLine();

            while (misses.Length <= 8)
            {
                DisplayGame(gameLine);

                char userGuess = GetUserInput();

                CheckForMissOrHit(userGuess, gameLine);

                DisplayGame(gameLine);

                if(CheckForWinOrLoss(gameLine))
                {
                    Console.WriteLine("Congratulations! You won!!!");
                    return;
                }
            }

            Console.WriteLine("You didn't guess the word");
        }

        static string GetWord()
        {
            Random random = new Random();
            int randomIndex = random.Next(words.Length);
            string word = words[randomIndex];

            return word;
        }

        static char[] InitLine()
        {
            char[] letters = wordToSolve.ToCharArray();
            char[] hidden = Array.ConvertAll(letters, letter => '_');

            return hidden;
        }

        static void DisplayGame(char[] gameLine)
        {
            Console.Clear();
            Console.WriteLine($"Word:   {String.Join(" ", gameLine)}");
            Console.WriteLine($"\nMisses: {misses}");
        }

        static char GetUserInput()
        {
            Console.Write("\nGuess a letter: ");
            ConsoleKeyInfo userChoice = Console.ReadKey();

            return userChoice.KeyChar;
        }
        
        static void CheckForMissOrHit(char userGuess, char[] gameLine)
        {
            if (wordToSolve.IndexOf(userGuess) == -1)
            {
                misses += $"{userGuess}";
            }
            else
            {
                for (int i = 0; i < wordToSolve.Length; i++)
                {
                    if (wordToSolve[i] == userGuess)
                    {
                        gameLine[i] = userGuess;
                    }
                }
            }
        }

        static bool IsWinner(char[] gameLine)
        {
            return Array.IndexOf(gameLine, '_') == -1;
        }
    }
}
