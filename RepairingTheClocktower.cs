namespace Challenges
{
    internal static class RepairingTheClocktower
    {
        public static void Run(string[] args)
        {
            Console.WriteLine($"Enter a number");
            int Number = Convert.ToInt32(Console.ReadLine());
        
            if (Number % 2 == 0)
            {
                Console.WriteLine($"Tick");
            }
            else
            {
                Console.WriteLine($"Tock");
            }
        }
    }
} 