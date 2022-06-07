using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listAlpha = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToList();



            List<string> numbers = new List<string>();

            for (int i = listAlpha.Count - 1; i >= 0; i--)
            {
                string[] digits = listAlpha[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);

                numbers.AddRange(digits);
            }
            Console.WriteLine(string.Join(" ", numbers));








        }
    }
}
