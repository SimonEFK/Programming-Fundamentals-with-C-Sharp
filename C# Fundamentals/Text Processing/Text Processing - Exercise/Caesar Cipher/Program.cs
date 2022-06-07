using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> input = Console.ReadLine()
                .Select(x => x = (char)(x + 3))
                .ToList();

            //StringBuilder result = new StringBuilder();

            //foreach (char character in input)
            //{
            //    var currChar = (char)(character + 3);
            //    result.Append(currChar.ToString());
            //}
            Console.WriteLine($"{string.Join("",input)}");
        }
    }
}
