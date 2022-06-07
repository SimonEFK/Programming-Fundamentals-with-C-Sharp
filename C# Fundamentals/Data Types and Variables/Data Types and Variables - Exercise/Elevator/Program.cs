using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int pplCount = int.Parse(Console.ReadLine());
            int elevatorCap = int.Parse(Console.ReadLine());

            int tripsCount = 0;

            if (pplCount <= elevatorCap)
            {
                tripsCount++;
            }
            else if (pplCount % elevatorCap == 0)
            {
                tripsCount += pplCount / elevatorCap;
            }
            else
            {
                tripsCount = pplCount / elevatorCap + 1;
                
            }
            Console.Write($"{tripsCount}");
        }
    }
}
