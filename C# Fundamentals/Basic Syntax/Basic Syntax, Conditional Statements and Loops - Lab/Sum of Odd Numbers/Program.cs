using System;

namespace SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int numCount = 0;
            int sum = 0;
            for (int i = 1; i <= 100; i+=2)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine($"{i}");
                    sum += i;
                    numCount++;
                    if (numCount==num)
                    {
                        Console.WriteLine($"Sum: {sum}");
                        return;
                    }
                }
            }
        }
    }
}
