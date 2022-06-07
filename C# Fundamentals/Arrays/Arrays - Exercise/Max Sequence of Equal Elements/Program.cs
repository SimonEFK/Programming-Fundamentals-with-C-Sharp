using System;
using System.Linq;

namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrAlpha = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int maxSequances = 0;
            int maxSequancesNum = 0;
            for (int i = 0; i < arrAlpha.Length; i++)
            {

                int sequance = 1;
                for (int j = i + 1; j < arrAlpha.Length; j++)
                {
                    if (arrAlpha[j] == arrAlpha[i])
                    {
                        sequance++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (sequance > maxSequances)
                {
                    maxSequances = sequance;
                    maxSequancesNum = arrAlpha[i];
                }
            }
            for (int k = 0; k < maxSequances; k++)
            {
                Console.Write(maxSequancesNum + " ");
            }
        }
    }
}
