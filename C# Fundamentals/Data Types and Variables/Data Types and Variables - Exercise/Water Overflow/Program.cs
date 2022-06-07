using System;

namespace Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                ushort water = ushort.Parse(Console.ReadLine());
                byte tankCap = 255;
                sum += water;
                if ((sum > tankCap) || (water > tankCap))
                {
                    sum -= water;
                    Console.WriteLine("Insufficient capacity!");
                }

            }
            Console.Write(sum);
        }
    }
}
