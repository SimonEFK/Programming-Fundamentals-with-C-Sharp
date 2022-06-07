using System;
using System.Collections.Generic;
using System.Linq;
namespace Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .ToLower()
                .Split(" ")
                .ToList();

            string material = string.Empty;
            int amount = 0;

            var keyMats = new Dictionary<string, int>();
            keyMats.Add("motes", 0);
            keyMats.Add("shards", 0);
            keyMats.Add("fragments", 0);
            var trash = new SortedDictionary<string, int>();

            while (true)
            {


                for (int i = 1; i < input.Count; i += 2)
                {

                    material = input[i];
                    amount = int.Parse(input[i - 1]);

                    if (material == "motes" || material == "shards" || material == "fragments")
                    {

                        keyMats[material] += amount;


                        foreach (var item in keyMats)
                        {
                            if (item.Key == "motes" && item.Value >= 250)
                            {
                                Console.WriteLine($"Dragonwrath obtained!");
                                keyMats[item.Key] -= 250;
                                goto loopsEnd;
                            }
                            else if (item.Key == "fragments" && item.Value >= 250)
                            {
                                Console.WriteLine($"Valanyr obtained!");
                                keyMats[item.Key] -= 250;
                                goto loopsEnd;
                            }
                            else if (item.Key == "shards" && item.Value >= 250)
                            {
                                Console.WriteLine($"Shadowmourne obtained!");
                                keyMats[item.Key] -= 250;
                                goto loopsEnd;
                            }
                        }

                    }
                    else
                    {
                        if (!(trash.ContainsKey(material)))
                        {
                            trash.Add(material, amount);
                        }
                        else
                        {
                            trash[material] += amount;
                        }
                    }



                }

                input = Console.ReadLine()
                .ToLower()
                .Split(" ")
                .ToList();
            }


        loopsEnd:

            //keyMats.OrderByDescending(x => x.Value).ThenBy(x => x.Key);

            foreach (var item in keyMats.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in trash)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }




        }
    }
}
