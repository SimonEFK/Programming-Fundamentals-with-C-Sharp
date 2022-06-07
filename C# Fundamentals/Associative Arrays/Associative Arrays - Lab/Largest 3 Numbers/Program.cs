using System;
using System.Collections.Generic;
using System.Linq;


namespace Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .OrderByDescending(n => n)
                .ToArray();


            for (int i = 0; (i < 3); i++)
            {

                if (i >= input.Length)
                {

                    return;

                }
                Console.Write(input[i] + " ");
            }
        }
    }
}
