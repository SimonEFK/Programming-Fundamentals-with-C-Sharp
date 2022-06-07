using System;
using System.Collections.Generic;
using System.Linq;

namespace Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = Console.ReadLine();
            string merged = string.Empty;

            while (input != "3:1")
            {
                string[] cmdArg = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArg[0];

                if (command == "merge")
                {
                    int startIndex = int.Parse(cmdArg[1]);
                    int endIndex = int.Parse(cmdArg[2]);

                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (endIndex >= names.Count)
                    {
                        endIndex = names.Count - 1;
                    }
                    if (startIndex > names.Count || endIndex < 0)
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    for (int j = startIndex; j <= endIndex; j++)
                    {
                        merged += names[j];

                    }

                    names.RemoveRange(startIndex, endIndex - startIndex + 1);
                    names.Insert(startIndex, merged);
                    merged = string.Empty;
                }
                else if (command == "divide")
                {

                    int index = int.Parse(cmdArg[1]);
                    int parts = int.Parse(cmdArg[2]);
                    string element = names[index];
                    string currPart = string.Empty;
                    List<string> result = new List<string>();
                    int divider = element.Length / parts;
                    int sIndex = 0;
                    for (int i = 0; i < parts; i++)
                    {
                        if (element.Length % parts != 0)
                        {
                            if (i == parts - 1)
                            {
                                string lastElement = element.Substring(sIndex, element.Length - sIndex);
                                result.Add(lastElement);
                                break;

                            }
                        }
                        currPart = element.Substring(sIndex, divider);
                        result.Add(currPart);
                        currPart = string.Empty;
                        sIndex += divider;

                    }

                    names.RemoveAt(index);
                    names.InsertRange(index, result);

                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", names));
        }
    }
}
