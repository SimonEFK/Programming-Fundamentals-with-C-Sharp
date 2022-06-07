using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string removeThisWord = Console.ReadLine().ToLower();
            string input = Console.ReadLine();
           
            while (input.Contains(removeThisWord))
            {
                int index = input.IndexOf(removeThisWord);

                input = input.Remove(index, removeThisWord.Length);
            }
            Console.WriteLine(input);
        }
    }
}
