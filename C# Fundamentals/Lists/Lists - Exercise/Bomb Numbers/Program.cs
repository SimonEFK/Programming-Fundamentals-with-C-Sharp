using System;
using System.Collections.Generic;
using System.Linq;
namespace Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listAlpha = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string[] data = Console.ReadLine()
                .Split()
                .ToArray();
            int bomb = int.Parse(data[0]);
            int range = int.Parse(data[1]);

            for (int i = 0; i < listAlpha.Count; i++)
            {

                for (int j = 0; j < listAlpha.Count; j++)
                {
                    if (listAlpha[i] == bomb)
                    {
                        int startIndex = i - range;
                        int endIndex = i + range;
                        if (startIndex < 0)
                        {
                            startIndex = 0;
                        }
                        if (endIndex > listAlpha.Count - 1)
                        {
                            endIndex = listAlpha.Count - 1;
                        }
                        int Ziggs = endIndex - startIndex + 1;
                        listAlpha.RemoveRange(startIndex, Ziggs);
                        i = startIndex - 1;
                        if (i < 0)
                        {
                            i = 0;
                        }
                    }
                }



            }
            Console.WriteLine(listAlpha.Sum());
        }
    }
}
