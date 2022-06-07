using System;
using System.Collections.Generic;
using System.Linq;

namespace __Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listAlpha = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> listBeta = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int shorterList = Math.Min(listAlpha.Count, listBeta.Count);
            int longerList = Math.Max(listAlpha.Count, listBeta.Count);

            List<int> mergedList = new List<int>();

            for (int i = 0; i < Math.Min(listAlpha.Count, listBeta.Count); i++)
            {
                if (listAlpha.Count >= listBeta.Count - 1)
                {
                    mergedList.Add(listAlpha[i]);
                    mergedList.Add(listBeta[i]);
                }
                else if (listAlpha.Count < listBeta.Count)
                {
                    mergedList.Add(listAlpha[i]);
                    mergedList.Add(listBeta[i]);
                }
            }
            for (int i = Math.Min(listBeta.Count, listAlpha.Count); i < Math.Max(listBeta.Count, listAlpha.Count); i++)
            {
                if (listAlpha.Count >= listBeta.Count)
                {
                    mergedList.Add(listAlpha[i]);
                }
                else if (listAlpha.Count < listBeta.Count)
                {
                    mergedList.Add(listBeta[i]);
                }
            }

            Console.WriteLine(string.Join(" ", mergedList));

        }
    }
}
