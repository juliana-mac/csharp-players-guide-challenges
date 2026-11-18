using System.Dynamic;
using System.Globalization;

namespace Challenges
{
    internal static class ExeptisGame
    {
        public static void Run(string[] args)
        {
            try
            {
                Random rdm = new Random();
                int targetNumber = rdm.Next(0, 10);
                List<int> previousGuesses = new List<int>();

                while (true)
                {
                    int number;
                    bool previousGuessed;

                    do
                    {
                        Console.WriteLine("Pick a number between 0 and 9 (inclusive).");
                        number = Convert.ToInt32(Console.ReadLine());

                        previousGuessed = previousGuesses.Contains(number);

                        if (previousGuessed)
                        {
                            Console.WriteLine("That number has been guessed before.");
                        }
                    }
                    while (previousGuessed);

                    if (number == targetNumber)
                    {
                        throw new Exception();
                    }

                    previousGuesses.Add(number);
                }

            }
            catch (Exception)
            {
                Console.WriteLine("That was the bad number! You lose!");
            }

        }
    }
}