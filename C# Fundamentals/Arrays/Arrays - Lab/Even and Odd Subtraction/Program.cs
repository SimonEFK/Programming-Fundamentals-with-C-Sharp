using System;
using System.Linq;

namespace Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int evenSum = 0;
            int oddSum = 0;
            int diff = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenSum += arr[i];
                }
                else
                {
                    oddSum += arr[i];
                }
            }
            diff = evenSum - oddSum;
            Console.WriteLine(diff);

        }
    }
}
