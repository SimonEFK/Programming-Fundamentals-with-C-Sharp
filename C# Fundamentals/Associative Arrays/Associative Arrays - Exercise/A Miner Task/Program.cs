using System;
using System.Collections.Generic;
using System.Linq;

namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new Dictionary<string, int>();

            string loot = Console.ReadLine();
            int amount = 0;

            while (loot != "stop")
            {
                amount = int.Parse(Console.ReadLine());

                if (!(container.ContainsKey(loot)))
                {
                    container.Add(loot, amount);
                }
                else
                {
                    container[loot] += amount;
                }

                loot = Console.ReadLine();
            }
            foreach (var item in container)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
