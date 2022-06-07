using System;

namespace Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                for (int j = i + 1; j < i + 1; j++)
                {
                    Console.Write(j + " ");
                }
            }
            Console.WriteLine();



        }
        static void PrintLine(int start, int end)​

{​

           for (int i = start; i <= end; i++)​

  {​

               Console.Write(i + " ");​

  }​

          Console.WriteLine();​
    }
}
