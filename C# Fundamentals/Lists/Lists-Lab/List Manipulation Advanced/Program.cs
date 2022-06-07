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
            bool isChanged = false;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                string[] data = input.Split();
                string command = data[0];

                if (command == "Add")
                {
                    int value = int.Parse(data[1]);
                    numbers.Add(value);
                    isChanged = true;
                }
                else if (command == "Remove")
                {
                    int value = int.Parse(data[1]);
                    numbers.Remove(value);
                    isChanged = true;
                }
                else if (command == "RemoveAt")
                {
                    int value = int.Parse(data[1]);
                    numbers.RemoveAt(value);
                    isChanged = true;
                }
                else if (command == "Insert")
                {
                    int value = int.Parse(data[1]);
                    int index = int.Parse(data[2]);
                    numbers.Insert(index, value);
                    isChanged = true;
                }
                else if (command == "Contains")
                {
                    int value = int.Parse(data[1]);
                    Console.WriteLine(numbers.Contains(value) ? "Yes" : "No such number");

                }
                else if (command == "PrintEven")
                {
                    Console.WriteLine(string.Join(" ", numbers.Where(n => n % 2 == 0)));
                }
                else if (command == "PrintOdd")
                {
                    Console.WriteLine(string.Join(" ", numbers.Where(n => n % 2 != 0)));
                }
                else if (command == "GetSum")
                {
                    Console.WriteLine(numbers.Sum());
                }
                else if (command == "Filter")
                {
                    string type = data[1];
                    int value = int.Parse(data[2]);
                    if (type == "<")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(n => n < value)));
                    }
                    else if (type == ">")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(n => n > value)));
                    }
                    else if (type == ">=")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(n => n >= value)));
                    }
                    else if (type == "<=")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(n => n <= value)));
                    }
                }
            }
            if (isChanged)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }




        }
    }
}
