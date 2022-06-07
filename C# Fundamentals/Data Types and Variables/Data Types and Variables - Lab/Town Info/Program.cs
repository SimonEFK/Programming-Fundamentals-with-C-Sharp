using System;

namespace Town_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            string townName = Console.ReadLine();
            int populationCount = int.Parse(Console.ReadLine());
            int squareKm = int.Parse(Console.ReadLine());

            Console.WriteLine("Town {0} has population of {1} and area {2} square km.", townName, populationCount, squareKm);
        }
    }
}
