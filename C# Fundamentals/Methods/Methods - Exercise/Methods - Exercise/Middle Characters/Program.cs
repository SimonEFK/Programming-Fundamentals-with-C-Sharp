using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            ExtractMiddleCharacter(input);

        }

        private static void ExtractMiddleCharacter(string input)
        {
            int index = 0;
            if ((double)input.Length % 2.0 == 0)
            {
                index = input.Length / 2;
                string midCharacter = input[index - 1].ToString();
                midCharacter += input[index].ToString();
                Console.WriteLine($"{midCharacter}");
            }
            else
            {
                index = input.Length / 2;
                string midCharacter = input[index].ToString();
                Console.WriteLine($"{midCharacter}");
            }
        }
    }
}
