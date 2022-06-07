using System;

using System.Linq;

namespace Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arrAlpha = new int[n];
            int[] arrBeta = new int[n];

            int counter = 0;

            for (int i = 0; i < n; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int numOne = numbers[0];
                int numbTwo = numbers[1];
                while (true)
                {
                    if (i % 2 == 0)
                    {
                        arrAlpha[counter] = numOne;
                        arrBeta[counter] = numbTwo;

                    }
                    else
                    {
                        arrAlpha[counter] = numbTwo;
                        arrBeta[counter] = numOne;
                    }
                    break;

                }
                counter++;

            }
            Console.WriteLine(string.Join(" ", arrAlpha));
            Console.Write(string.Join(" ", arrBeta));


        }
    }
}
