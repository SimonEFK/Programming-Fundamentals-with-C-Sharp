using System;
using System.Linq;

namespace Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumAlpha = 0;
            int sumBeta = 0;

            int[] arrAlpha = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] arrBeta = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < arrAlpha.Length; i++)
            {
                sumAlpha += arrAlpha[i];
                sumBeta += arrBeta[i];
                if (arrAlpha[i] != arrBeta[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
            }
            if (sumAlpha == sumBeta)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sumAlpha}");
            }



        }
    }
}
