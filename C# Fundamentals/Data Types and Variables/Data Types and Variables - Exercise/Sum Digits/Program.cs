using System;

namespace Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sumOfDigits = 0;
            for (int i = 0; i <= input.Length - 1; i++)
            {
                char currDigit = input[i];
                int converted = int.Parse(currDigit.ToString());
                sumOfDigits += converted;
            }
            Console.Write($"{sumOfDigits}");

        }
    }
}
