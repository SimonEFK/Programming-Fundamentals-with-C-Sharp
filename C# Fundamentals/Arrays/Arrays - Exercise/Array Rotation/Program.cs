using System;
using System.Linq;

namespace Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrOfNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();


            int rotation = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotation; i++)
            {
                int firstNum = arrOfNumbers[0];
                for (int j = 1; j < arrOfNumbers.Length; j++)
                {
                    arrOfNumbers[j - 1] = arrOfNumbers[j];
                }
                arrOfNumbers[arrOfNumbers.Length - 1] = firstNum;

            }
            foreach (int item in arrOfNumbers)
            {
                Console.Write(item + " ");
            }
        }
    }
}
