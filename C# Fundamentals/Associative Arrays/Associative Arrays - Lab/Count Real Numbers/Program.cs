using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();


            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();

            foreach (int num in numbers)
            {

                if (counts.ContainsKey(num))
                {
                    counts[num]++;
                }
                else
                {
                    counts[num] = 1;
                }

            }
            foreach (var num in counts)
            {
                Console.WriteLine($"{num.Key} -> {num.Value}");
            }




        }
    }
}
