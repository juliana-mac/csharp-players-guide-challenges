namespace Challenges
{
    internal static class TheTriangleFarmer
    {
        public static void Run(string[] args)
        {

            Console.WriteLine($"Write the base size of your triangle.");
            float baseSizeTriangle = Convert.ToSingle(Console.ReadLine());


            Console.WriteLine($"Write the height of your triangle.");
            float heightTriangle = Convert.ToSingle(Console.ReadLine());

            float triangleArea = (baseSizeTriangle * heightTriangle)/ 2;

            Console.WriteLine($"The area of your triangle is: {triangleArea}");



        }
    }
}