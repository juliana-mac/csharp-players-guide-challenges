using System.Dynamic;

namespace Challenges
{
    internal static class TheReplicatorOfDTo
    {
        public static void Run(string[] args)
        {
            int[] array1 = new int[5];

            Console.WriteLine("Type 5 numbers:");

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] array2 = new int[5];

            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = array1[i];
            }

            for (int position = 0; position < array2.Length; position++)
            {
                Console.WriteLine($"{array1[position]} and {array2[position]}");
            }

        }
    }
}