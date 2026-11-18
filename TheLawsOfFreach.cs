using System.Dynamic;

namespace Challenges
{
    internal static class TheLawsOfFreach
    {
        public static void Run(string[] args)
        {
            int[] array = new int[] {4,51,-7,13,-99,15,-8,45,90};
            
            int currentSmallest = int.MaxValue;

            foreach (int value in array)
            {
                if (value < currentSmallest)
                {
                    currentSmallest = value;
                }

                Console.WriteLine(currentSmallest);
            }

            int total = 0;

            foreach (int value in array)
            {
                total = total + value;
            }

            float average = (float)total/ array.Length;

            Console.WriteLine(average);

        }
    }
}