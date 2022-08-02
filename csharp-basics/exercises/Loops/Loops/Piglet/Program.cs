using System;

namespace Piglet
{
    internal class Piglet
    {
        static int points = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Piglet!");

            GameLoop();

            Console.WriteLine($"\nYou got {points} points.");
        }

        static void GameLoop()
        {
            Random rand = new Random();
            int dice = rand.Next(1, 7);

            if (dice == 1)
            {
                Console.WriteLine("\nYou rolled a 1");
                points = 0;
                return;
            }

            while (dice != 1)
            {
                dice = rand.Next(1, 7);

                if(dice == 1)
                {
                    Console.WriteLine("\nYou rolled a 1");
                    points = 0;
                    return;
                }

                points += dice;

                Console.WriteLine($"\nYou rolled a {dice}!");
                char choice = GetUserInput();

                switch (choice)
                {
                    case 'y':
                        continue;
                    case 'n':
                        return;
                    default:
                        Console.WriteLine("Invalid input");
                        GetUserInput();
                        break;
                }
            }
        }

        static char GetUserInput()
        {
            Console.Write("Roll again (y - yes, n - no): ");
            ConsoleKeyInfo choice = Console.ReadKey();

            return choice.KeyChar;
        }
    }
}
