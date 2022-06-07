using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;

namespace EmailExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"(?<=\s)([A-Za-z0-9]+([\._\-]*)[A-Za-z0-9]*)@([A-z]+\-*[A-Za-z]+[.\-]*[A-Za-z]+)\.{1}[a-z]+");
            string input = Console.ReadLine();

            MatchCollection matches = pattern.Matches(input);
            foreach (Match item in matches)
            {
                Console.WriteLine($"{item.Value}");
            }
        }
    }
}
