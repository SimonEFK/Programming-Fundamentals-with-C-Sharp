using System;

namespace Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string longestWord = input[0];
            string shortestWord = input[1];

            if (longestWord.Length < shortestWord.Length)
            {
                longestWord = input[1];
                shortestWord = input[0];
            }
            Console.WriteLine(CalcChars(longestWord, shortestWord));

              static int CalcChars(string longestWord,string shortestWord)
              {
                int result = 0;
                for (int i = 0; i < shortestWord.Length; i++)
                {
                    result += longestWord[i] * shortestWord[i];
                }
                for (int i = shortestWord.Length; i < longestWord.Length; i++)
                {
                    result += longestWord[i];
                }
                return result;
              }
        }
    }
}
