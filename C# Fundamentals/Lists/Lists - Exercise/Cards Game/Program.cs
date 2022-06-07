using System;
using System.Collections.Generic;
using System.Linq;
namespace Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> fpDeck = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> spDeck = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();


            for (int i = 0; i < fpDeck.Count; i += 0)
            {


                if (fpDeck[i] > spDeck[i])
                {
                    fpDeck.Insert(fpDeck.Count, fpDeck[i]);
                    fpDeck.Insert(fpDeck.Count, spDeck[i]);
                    fpDeck.RemoveAt(i);

                    spDeck.RemoveAt(i);



                }
                else if (fpDeck[i] == spDeck[i])
                {
                    fpDeck.RemoveAt(i);
                    spDeck.RemoveAt(i);


                }
                else
                {
                    spDeck.Insert(spDeck.Count, spDeck[i]);
                    spDeck.Insert(spDeck.Count, fpDeck[i]);
                    spDeck.RemoveAt(i);

                    fpDeck.RemoveAt(i);



                }
                if (fpDeck.Count == 0 || spDeck.Count == 0)
                {
                    break;
                }


            }

            if (fpDeck.Count >= spDeck.Count)
            {
                Console.WriteLine($"First player wins! Sum: {fpDeck.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {spDeck.Sum()}");
            }
        }
    }



}





