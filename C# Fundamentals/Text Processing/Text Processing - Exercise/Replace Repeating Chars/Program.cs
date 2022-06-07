using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < input.Length-1; i++)
            {
                if (input[i]!=input[i+1])
                {
                    result.Append(input[i]);
                }
            }
            string lastElement = input[input.Length - 1].ToString();
            Console.WriteLine($"{result}{lastElement}");
        }
    }
}
