namespace Challenges
{
    internal class ConsolasAndTelim
    {
        public static void Run(string[] args)
        {
            Console.WriteLine("Bread is ready.");
            Console.WriteLine("Who is the bread for?");
            string name = Console.ReadLine()?? " ";
            Console.WriteLine($"Noted: {name} got bread.");
            TheThingExercise.Run(args);
            
        }
    }
}