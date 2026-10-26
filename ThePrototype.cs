namespace Challenges
{
    internal static class ThePrototype
    {
        public static void Run(string[] args)
        {
            int numberUser1;
            do
            {
                Console.WriteLine($"User 1, enter a number between 0 and 100:");
                numberUser1 = Convert.ToInt32(Console.ReadLine());
            }
            while(numberUser1 < 0 || numberUser1 > 100);

            Console.Clear();
            
            Console.WriteLine($"User 2, guess the number.");
            int numberUser2 = Convert.ToInt32(Console.ReadLine());

            while (numberUser2 != numberUser1)
            {
                Console.WriteLine($"What is your next guest?");

                numberUser2 = Convert.ToInt32(Console.ReadLine());

                if (numberUser2 > numberUser1)
                {
                    Console.WriteLine($"{numberUser2} is too high.");
                }
                else if (numberUser2 < numberUser1)
                {
                    Console.WriteLine($"{numberUser2} is too low.");
                }
                else
                {
                    Console.WriteLine("You guessed the number!");
                }
            }
        }
    }
}