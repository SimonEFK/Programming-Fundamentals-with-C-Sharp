using System;
using System.Linq;

namespace Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrAlpha = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int magicNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < arrAlpha.Length; i++)
            {
                for (int j = i + 1; j < arrAlpha.Length; j++)
                {
                    if (arrAlpha[i] + arrAlpha[j] == magicNum)
                    {
                        Console.Write($"{arrAlpha[i]} {arrAlpha[j]}\n");

                    }

                }
            }

        }
    }
}
