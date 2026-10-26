namespace Challenges
{
    internal static class The4SistersAndTheDuckbear
    {
        public static void Run(string[] args)
        {
            Console.WriteLine("How many chocolate eggs were gathered today?");
            int chocolateEgg = Convert.ToInt32(Console.ReadLine());

            int numSisters = 4;

            int chocolateInteger = chocolateEgg / numSisters;

            int chocolateRemainder = chocolateEgg % numSisters ;

            Console.WriteLine($"The chocolate egg for each sister is : {chocolateInteger}");
            Console.WriteLine($"The chocolate egg for the duckbear is : {chocolateRemainder}");


        }
    }
}