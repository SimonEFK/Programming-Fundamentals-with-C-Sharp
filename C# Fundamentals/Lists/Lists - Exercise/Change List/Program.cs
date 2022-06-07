using System;
using System.Collections.Generic;
using System.Linq;

namespace Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listAlpha = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] cmd = input.Split();
                int value = int.Parse(cmd[1]);

                if (cmd[0] == "Delete")
                {
                    listAlpha.RemoveAll(n => n == value);
                }
                else if (cmd[0] == "Insert")
                {
                    int index = int.Parse(cmd[2]);
                    listAlpha.Insert(index, value);
                }
                input = Console.ReadLine();

            }
            Console.WriteLine(string.Join(" ", listAlpha));
        }
    }
}
