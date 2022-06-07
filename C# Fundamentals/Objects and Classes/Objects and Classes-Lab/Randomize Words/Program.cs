using System;

namespace Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            RandomizeArrey(input);
            Console.WriteLine($"{string.Join("\n", input)}");

        }

        private static void RandomizeArrey(string[] input)
        {
            Random rnd = new Random();

            for (int i = 0; i < input.Length; i++)
            {

                int randomNum = rnd.Next(0, input.Length);
                string tempWord = input[i];
                input[i] = input[randomNum];
                input[randomNum] = tempWord;


            }
        }
    }
}
