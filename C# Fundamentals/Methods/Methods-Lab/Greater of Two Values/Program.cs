using System;

namespace Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {

            string command = Console.ReadLine();

            string input = Console.ReadLine();
            string inputAlpha = Console.ReadLine();

            if (command=="int")
            {
                PrintGreaterNumber(input, inputAlpha);
            }
            else if (command=="char")
            {
                PrintGreaterChar(input, inputAlpha);
            }
            else
            {
                PrintGreaterString(input, inputAlpha);
            }
        }
        static void PrintGreaterNumber(string input,string inputAlpha)
        {
            int number = int.Parse(input);
            int numberAlpha = int.Parse(inputAlpha);

            int answer = 0;
            if (number>numberAlpha)
            {
                answer = number;
            }
            else if (number<numberAlpha)
            {
                answer = numberAlpha;
            }
            Console.WriteLine(answer);
        }
        static void PrintGreaterChar(string input,string inputAlpha)
        {
            char charInput = char.Parse(input);
            char charInputAlpha = char.Parse(inputAlpha);

            char answer = ' ';

            if (charInput> charInputAlpha)
            {
                 answer = charInput;
            }
            else if (charInput< charInputAlpha)
            {
                answer = charInputAlpha;
            }
            Console.WriteLine(answer);
        }
        static void PrintGreaterString(string input, string inputAlpha)
        {
            string answer = string.Empty;

            int result = string.Compare(input, inputAlpha);
            if (result==1)
            {
                answer = input;
            }
            else if (result==-1)
            {
                answer = inputAlpha;
            }
            Console.WriteLine(answer);
        }

    }
}
