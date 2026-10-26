namespace Challenges
{
    internal static class TheThingExercise
    {
        public static void Run(string[] args)
        {

            Console.WriteLine($"What kind of thing are we talking about?");
            string type = Console.ReadLine()?? "";

            Console.WriteLine($"How would you describe it? Big? Azure? Tattered?");
            string description = Console.ReadLine()?? " ";
            string doom =  "Doom";
            string version= "3000";
            Console.WriteLine($"The {description}  {type}  of {doom} {version}");

        }
    }
}