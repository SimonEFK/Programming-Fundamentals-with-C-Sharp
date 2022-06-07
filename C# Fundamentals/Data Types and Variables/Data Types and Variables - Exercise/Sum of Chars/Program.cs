using System;

namespace Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                char input = char.Parse(Console.ReadLine());
                int charToASCII = (int)input;
                sum += charToASCII;
            }
            Console.Write($"The sum equals: {sum}");
        }
    }
}
