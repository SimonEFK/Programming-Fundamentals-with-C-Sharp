using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            input = ReverseString(input);
        }

        private static string ReverseString(string input)
        {
            while (input != "END")
            {
                string inputMirror = string.Empty;
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    inputMirror += input[i];
                }

                if (inputMirror == input)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                input = Console.ReadLine();

            }

            return input;
        }
    }
}
