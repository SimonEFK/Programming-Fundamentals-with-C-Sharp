using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace __Match_Full
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"[+][359]{3}( |-)[2]\1[0-9]{3}\1[0-9]{4}\b";
            string input = Console.ReadLine();

            var matchNames = Regex.Matches(input, regex);
            var matchedPhones = matchNames
                .Cast<Match>()
                .Select(x => x.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ", matchedPhones));

        }
    }
}
