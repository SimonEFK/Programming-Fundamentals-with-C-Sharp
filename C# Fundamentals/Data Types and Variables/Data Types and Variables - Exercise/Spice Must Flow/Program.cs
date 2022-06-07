using System;

namespace Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentAmount = n;
            int daysCounter = 0;
            int workersConsume = 26;
            int sum = 0;

            while (currentAmount >= 100)
            {

                sum += currentAmount - workersConsume;
                daysCounter++;
                currentAmount -= 10;

            }
            if (daysCounter > 0)
            {
                sum -= workersConsume;

            }
            Console.WriteLine($"{daysCounter}\n{sum}");



        }
    }
}
