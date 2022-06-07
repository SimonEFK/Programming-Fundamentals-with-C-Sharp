using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                string[] data = input.Split();
                string command = data[0];
                int value = int.Parse(data[1]);
                if (command == "Add")
                {
                    numbers.Add(value);
                }
                else if (command == "Remove")
                {
                    numbers.Remove(value);
                }
                else if (command == "RemoveAt")
                {
                    numbers.RemoveAt(value);
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(data[2]);
                    numbers.Insert(index, value);
                }

            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
