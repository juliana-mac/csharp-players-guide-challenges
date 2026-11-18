namespace Challenges
{
    internal static class TheLongGame
    {
        public static void Run(string[] args)
        {
            Console.WriteLine("Enter your name.");
            string name = Console.ReadLine();

            int score = 0;
            string fileName = $"{name}.txt";

            if (File.Exists(fileName))
            {
                score = Convert.ToInt32(File.ReadAllText(name + ".txt"));
                Console.WriteLine($"Last time, {name}, your score was: {score}");

            }

            Console.WriteLine("Press any key to score. Press Enter to stop.");

            ConsoleKeyInfo key = Console.ReadKey();

            while (key.Key != ConsoleKey.Enter)
            {
                score++;
                Console.WriteLine($"{name} your score is:{score}");
                key = Console.ReadKey();

            }
            Console.WriteLine($"\nGame over! Final score: {score}");

            File.WriteAllText($"{name}.txt", Convert.ToString(score));

        }
    }
}