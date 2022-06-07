using System;
using System.Collections.Generic;
using System.Linq;

namespace Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            VowelCount(input);
        }

        private static void VowelCount(string input)
        {
            int vowelsCount = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char currCharacter = char.Parse(input[i].ToString());
                bool isVowel = currCharacter == 'a' || currCharacter == 'u' || currCharacter == 'o' || currCharacter == 'e' || currCharacter == 'i' || currCharacter == 'y';
                if (isVowel)
                {
                    vowelsCount++;
                }
            }
            Console.WriteLine($"{vowelsCount}");
        }
    }
}
