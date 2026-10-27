namespace Challenges
{
    internal static class TheMagicCannon
    {
        public static void Run(string[] args)
        {

            for (int turn = 1; turn <= 100; turn++)
            {
                if (turn % 3 == 0 && turn % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"{turn}: Fire and Electric");
                }
                else if (turn % 3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{turn}: Fire");
                }
                else if (turn % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{turn}: Electric");
                }
                else
                {
                    Console.ResetColor();
                    Console.WriteLine($"{turn}: Normal");

                }
            }
            Console.ResetColor();
        }
    }
}