using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char startChar = char.Parse(Console.ReadLine());
            char endChar = char.Parse(Console.ReadLine());
            PrintASCII(startChar, endChar);

        }

        private static void PrintASCII(char startChar, char endChar)
        {
            StringBuilder result = new StringBuilder();
            for (int i = Math.Min(startChar + 1,endChar+1); i < Math.Max(endChar,startChar); i++)
            {
                char currChar = (char)i;
                result.Append(currChar.ToString() + ' ');
            }
            Console.WriteLine(result);
        }
    }
}
