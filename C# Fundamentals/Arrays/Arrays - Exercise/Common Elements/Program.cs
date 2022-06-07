using System;
using System.Linq;

namespace Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrAlpha = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string[] arrBeta = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();


            for (int i = 0; i < arrAlpha.Length; i++)
            {
                for (int j = 0; j < arrBeta.Length; j++)
                {
                    if (arrAlpha[i] == arrBeta[j])
                    {
                        Console.Write(arrAlpha[i] + " ");
                    }
                }
            }

        }
    }
}
