using System;
using System.Collections.Generic;
using System.Linq;

namespace Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMinValue();

        }

        private static void PrintMinValue()
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < 3; i++)
            {
                int input = int.Parse(Console.ReadLine());
                numbers.Add(input);
            }
            Console.WriteLine($"{numbers.Min()}");
        }

    }
}
