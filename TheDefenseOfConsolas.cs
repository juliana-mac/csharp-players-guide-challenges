using System.Diagnostics.Contracts;

namespace Challenges
{
    internal static class TheDefenseOfConsolas
    {
        public static void Run(string[] args)
        {
            Console.Title = "Defense of Consolas";

            Console.Write("Target row? ");
            int row = Convert.ToInt32(Console.ReadLine());

            
            Console.Write("Target column? ");
            int column = Convert.ToInt32(Console.ReadLine());

            int belowRow = row + 1;
            int aboveRow = row - 1;
            int leftRow = row;
            int rightRow = row;
            int leftColumn = column - 1;
            int rightColum = column + 1;
            int aboveColumn = column;
            int belowColumn= column;

            Console.ForegroundColor = ConsoleColor.Blue;
            
            Console.WriteLine($"Deploy to:\n({leftRow},{leftColumn})\n({aboveRow},{aboveColumn})\n({rightRow},{rightColum})\n({belowRow},{belowColumn})");

            Console.ResetColor();

#pragma warning disable CA1416 // Validate platform compatibility
            Console.Beep(600,1500);
#pragma warning restore CA1416 // Validate platform compatibility



        }
    }
}