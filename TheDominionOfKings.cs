namespace Challenges
{
    internal static class TheDominionOfKings
    {
        public static void Run(string[] args)
        {
            
            Console.WriteLine("How many provinces do you have?");
            int provinces = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many duchies do you have?");
            int duchies = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many estates do you have?");
            int estates = Convert.ToInt32(Console.ReadLine());

            int totalPoints = provinces * 6 + duchies * 3 + estates * 1;

            Console.WriteLine($"Your provinces are:{provinces}");
            Console.WriteLine($"Your duchy are:{duchies}");
            Console.WriteLine($"Your estates are:{estates}");
            Console.WriteLine($"Your total points are:{totalPoints}");

        }
    }
} 