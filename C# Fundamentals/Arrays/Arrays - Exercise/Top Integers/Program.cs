using System;
using System.Linq;

namespace Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrAlpha = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int lastNumb = arrAlpha[arrAlpha.Length - 1];

            bool tpInteger = true;

            for (int i = 0; i < arrAlpha.Length; i++)
            {
                tpInteger = true;
                for (int j = i + 1; j < arrAlpha.Length; j++)
                {
                    if (arrAlpha[j] >= arrAlpha[i])
                    {
                        tpInteger = false;
                        break;
                    }
                    else
                    {
                        tpInteger = true;
                    }

                }
                if (tpInteger)
                {
                    int topNumber = arrAlpha[i];
                    Console.Write(topNumber + " ");
                }
            }


        }
    }
}
