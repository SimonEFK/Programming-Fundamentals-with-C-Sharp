using System;
using System.Linq;

namespace Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrAlpha = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int rSum = 0;
            int lSum = 0;

            for (int i = 0; i < arrAlpha.Length; i++)
            {
                rSum = 0;
                lSum = 0;
                for (int h = i + 1; h < arrAlpha.Length; h++)
                {
                    rSum += arrAlpha[h];
                }



                for (int k = i - 1; k < arrAlpha.Length; k--)
                {

                    if (k < 0)
                    {
                        lSum += 0;
                        break;
                    }
                    else
                    {
                        lSum += arrAlpha[k];
                    }


                }
                if (lSum == rSum)
                {
                    Console.WriteLine(i);
                    return;
                }

            }
            Console.WriteLine("no");

        }
    }
}
