using System;

namespace Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            string result = PrintInputLoop(input,count);
            Console.WriteLine(result);
        }

        private static string PrintInputLoop(string input,int count)
        {

            string resultt = string.Empty;
            for (int i = 0; i < count; i++)
            {
                resultt += input;
            }
            return resultt;
        }
    }
}
