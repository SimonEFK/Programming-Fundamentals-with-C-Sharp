using System;
using System.Collections.Generic;
using System.Linq;


namespace List_Operations
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

            while (input != "End")
            {
                string[] data = input.Split();

                if (data[0] == "Add")
                {
                    int value = int.Parse(data[1]);
                    listAlpha.Add(value);
                }
                else if (data[0] == "Remove")
                {
                    int index = int.Parse(data[1]);
                    if (index < 0 || index > listAlpha.Count - 1)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        listAlpha.RemoveAt(index);
                    }
                }
                else if (data[0] == "Insert")
                {
                    int index = int.Parse(data[2]);
                    if (index < 0 || index > listAlpha.Count - 1)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        int value = int.Parse(data[1]);

                        listAlpha.Insert(index, value);
                    }
                }
                else if (data[0] == "Shift")
                {
                    if (data[1] == "left")
                    {
                        int rotations = int.Parse(data[2]);
                        for (int i = 0; i < rotations; i++)
                        {
                            int firstElement = listAlpha[0];

                            for (int j = 0; j < listAlpha.Count - 1; j++)
                            {
                                listAlpha[j] = listAlpha[j + 1];
                            }
                            listAlpha[listAlpha.Count - 1] = firstElement;
                        }
                    }
                    else if (data[1] == "right")
                    {
                        int rotations = int.Parse(data[2]);
                        for (int i = 0; i < rotations; i++)
                        {
                            int lastElement = listAlpha[listAlpha.Count - 1];

                            for (int j = listAlpha.Count - 1; j > 0; j--)
                            {
                                listAlpha[j] = listAlpha[j - 1];
                            }
                            listAlpha[0] = lastElement;
                        }
                    }
                }
                input = Console.ReadLine();

            }
            Console.WriteLine(string.Join(" ", listAlpha));
        }
    }
}
