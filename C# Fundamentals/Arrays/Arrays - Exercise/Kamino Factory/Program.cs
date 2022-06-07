using System;
using System.Linq;

namespace Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int sequancesLenght = int.Parse(Console.ReadLine());

            bool isDna = true;

            int goodSequanceCounter = 1;
            int bestSequanceCounter = 0;

            int goodGenseCounter = 0;
            int goodGenesMax = 0;

            int sample = 0;
            int bestSample = 0;

            int startIndex = int.MaxValue;
            int bestIndex = 0;

            string[] bestDna = new string[sequancesLenght];

            while (isDna)
            {
                string sequances = Console.ReadLine();
                if (sequances == "Clone them!")
                {
                    isDna = false;
                    break;
                }

                string[] dnaSamples = sequances
                    .Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                sample++;


                goodSequanceCounter = 1;


                goodGenseCounter = 0;





                for (int i = 0; i < dnaSamples.Length; i++)
                {

                    if (dnaSamples[i] == "1")
                    {
                        goodGenseCounter++;

                        for (int j = i + 1; j < dnaSamples.Length; j++)
                        {
                            if (dnaSamples[j] == "1")
                            {
                                goodSequanceCounter++;
                                startIndex = i;
                            }
                            else
                            {
                                break;
                            }

                        }

                    }


                }
                if (goodSequanceCounter == bestSequanceCounter && startIndex < bestIndex && startIndex != -1)
                {
                    bestSequanceCounter = goodSequanceCounter;
                    bestDna = dnaSamples;
                    goodGenesMax = goodGenseCounter;
                    bestSample = sample;
                    bestIndex = startIndex;

                }
                else if (goodSequanceCounter > bestSequanceCounter && startIndex != -1)
                {
                    bestSequanceCounter = goodSequanceCounter;
                    bestDna = dnaSamples;
                    goodGenesMax = goodGenseCounter;
                    bestSample = sample;
                    bestIndex = startIndex;
                }


            }
            Console.Write($"Best DNA sample {bestSample} with sum: {goodGenesMax}.\n");
            foreach (string item in bestDna)
            {
                Console.Write(item + " ");
            }



        }

    }
}
