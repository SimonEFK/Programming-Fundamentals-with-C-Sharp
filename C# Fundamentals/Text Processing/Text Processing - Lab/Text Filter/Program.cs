using System;
using System.Linq;

namespace Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string input = Console.ReadLine();

            while (input.Contains(bannedWords[0]) || input.Contains(bannedWords[1]))
            {
                if (input.Contains(bannedWords[0]))
                {
                    input = input.Replace(bannedWords[0], new string('*', bannedWords[0].Length));
                }
                else if (input.Contains(bannedWords[1]))
                {

                    input = input.Replace(bannedWords[1], new string('*', bannedWords[1].Length));
                }
            }
            Console.WriteLine(input);

        }
    }
}
