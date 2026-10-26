using System.Diagnostics;

namespace Challenges
{
    internal static class DiscountedInventory
    {
        public static void Run(string[] args)
        {
            Console.WriteLine("The following items are avaliable:");
            Console.WriteLine("1 - Rope");
            Console.WriteLine("2 - Torches");
            Console.WriteLine("3 - Climbing Equipement");
            Console.WriteLine("4 - Clean Water");
            Console.WriteLine("5 - Machete");
            Console.WriteLine("6 - Canoe");
            Console.WriteLine("7 - Food Supplies");

            Console.WriteLine();

            Console.WriteLine("Type your name:");

            string clientName = Console.ReadLine();

            Console.WriteLine("What do you want to see the price of?");

            int itemNumber = Convert.ToInt32(Console.ReadLine());

            string item = itemNumber switch
            {
                1 => "Rope",
                2 => "Torches",
                3 => "Climbing Equipement",
                4 => "Clean Water",
                5 => "Machete",
                6 => "Canoe",
                7 => "Food Supplies",
                _ => throw new NotImplementedException(),
            };

            int price = item switch
            {
                "Rope" => 10,

                "Torches" => 15,

                "Climbing Equipement" => 25,

                "Clean Water" => 1,

                "Machete" => 20,

                "Canoe" => 200,

                "Food Supplies" => 1,
                _ => throw new NotImplementedException(),
            };

            if (clientName == "Juliana")
            {
                price = price / 2;
            }

            Console.WriteLine($"{item} costs {price} gold.");


        }
    }
}