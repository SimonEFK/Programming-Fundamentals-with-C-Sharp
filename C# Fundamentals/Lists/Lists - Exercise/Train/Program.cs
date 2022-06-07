using System;
using System.Collections.Generic;
using System.Linq;

namespace TrainLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int wagonsCap = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] cmd = input.Split();
                if (cmd[0] == "Add")
                {
                    wagons.Add(int.Parse(cmd[1]));
                }
                else
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        int passangers = int.Parse(cmd[0]);
                        if (wagons[i] + passangers <= wagonsCap)
                        {
                            wagons[i] += passangers;
                            break;

                        }
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
