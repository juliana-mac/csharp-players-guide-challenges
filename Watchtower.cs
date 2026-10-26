namespace Challenges
{
    internal static class Watchtower
    {
        public static void Run(string[] args)
        {
           Console.WriteLine($"Enter the x value");
           int x = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine($"Inser the y value");
           int y = Convert.ToInt32(Console.ReadLine());

           if (x < 0 && y > 0)
            {
                Console.WriteLine("The enemy is to the northwest!");
            }
            else if (x == 0 && y > 0)
            {
                Console.WriteLine("The enemy is to the north!");
            }
              else if (x > 0 && y > 0)
            {
                Console.WriteLine("The enemy is to the northeast!");
            }
              else if (x < 0 && y == 0)
            {
                Console.WriteLine("The enemy is to the west!");
            }
              else if (x == 0 && y == 0)
            {
                Console.WriteLine("The enemy is here!");
            }
              else if (x > 0 && y == 0)
            {
                Console.WriteLine("The enemy is to the east!");
            }
              else if (x < 0 && y < 0)
            {
                Console.WriteLine("The enemy is to the southwest!");
            }
              else if (x == 0 && y < 0)
            {
                Console.WriteLine("The enemy is to the south!");
            }
            else 
            {
                Console.WriteLine("The enemy is to the southeast!");
            }

        }
    }
} 