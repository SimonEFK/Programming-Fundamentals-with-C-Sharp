using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToList();
            string[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);


            while (commands[0] != "end")
            {

                if (commands[0] == "exchange")
                {
                    input = RearangeList(input, commands);
                }
                else if (commands[0] == "max")
                {
                    if (commands[1] == "even")
                    {
                        GetMaxEven(input);

                    }
                    else if (commands[1] == "odd")
                    {
                        GetMaxOdd(input);
                    }
                }
                else if (commands[0] == "min")
                {
                    if (commands[1] == "even")
                    {
                        GetMinEven(input);

                    }
                    else if (commands[1] == "odd")
                    {
                        GetMinOdd(input);

                    }
                }
                else if (commands[0] == "first")
                {

                    if (commands[2] == "even")
                    {
                        int count = int.Parse(commands[1]);
                        if (count > input.Count)
                        {
                            Console.WriteLine($"Invalid count");
                            commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                            continue;

                        }
                        GetFirstEven(input, count);

                    }
                    else if (commands[2] == "odd")
                    {

                        int count = int.Parse(commands[1]);
                        if (count > input.Count)
                        {
                            Console.WriteLine($"Invalid count");
                            commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                            continue;

                        }
                        GetFirstOdd(input, count);

                    }



                }
                else if (commands[0]=="last")
                {

                
                
                    if (commands[2] == "even")
                    {
                        int count = int.Parse(commands[1]);
                        if (count > input.Count)
                        {
                            Console.WriteLine($"Invalid count");
                            commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                            continue;

                        }
                        GetLastEven(input, count);

                    }
                    else if (commands[2] == "odd")
                    {
                        int count = int.Parse(commands[1]);
                        if (count > input.Count)
                        {
                            Console.WriteLine($"Invalid count");
                            commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                            continue;

                        }
                        GetLastOdd(input, count);
                    }
                }






                commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            }
            Console.WriteLine($"[{string.Join(", ",input)}]");
        }

        private static void GetLastOdd(List<int> input, int count)
        {
            List<int> elements = new List<int>();
            for (int i = input.Count - 1; i >= 0; i--)
            {
                if (input[i] % 2 != 0)
                {
                    elements.Insert(0, input[i]);
                }
                if (elements.Count >= count)
                {
                    break;
                }
            }
            if (elements.Count == 0)
            {
                Console.WriteLine($"[]");
            }
            else
            {
                Console.WriteLine($"[{string.Join(", ", elements)}]");
            }
        }

        private static void GetLastEven(List<int> input, int count)
        {
            List<int> elements = new List<int>();
            for (int i = input.Count - 1; i >= 0; i--)
            {
                if (input[i] % 2 == 0)
                {
                    elements.Insert(0, input[i]);
                }
                if (elements.Count > count)
                {
                    break;
                }
            }
            if (elements.Count == 0)
            {
                Console.WriteLine($"[]");
            }
            else
            {
                Console.WriteLine($"[{string.Join(", ", elements)}]");
            }
        }

        private static void GetFirstOdd(List<int> input, int count)
        {
            List<int> elements = new List<int>();
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] % 2 != 0)
                {
                    elements.Add(input[i]);
                }
                if (elements.Count >= count)
                {
                    break;
                }
            }
            if (elements.Count == 0)
            {
                Console.WriteLine($"[]");
            }
            else
            {
                Console.WriteLine($"[{string.Join(", ", elements)}]");
            }
        }

        private static void GetFirstEven(List<int> input, int count)
        {
            List<int> elements = new List<int>();
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] % 2 == 0)
                {
                    elements.Add(input[i]);
                }
                if (elements.Count >= count)
                {
                    break;
                }
            }
            if (elements.Count == 0)
            {
                Console.WriteLine($"[]");
            }
            else
            {
                Console.WriteLine($"[{string.Join(", ", elements)}]");
            }
        }

        private static void GetMinOdd(List<int> input)
        {
            int currMinDigit = int.MaxValue;
            int maxIndex = -1;
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] % 2 != 0)
                {
                    if (currMinDigit >= input[i])
                    {
                        currMinDigit = input[i];
                        maxIndex = i;
                    }
                }
            }
            if (maxIndex == -1)
            {
                Console.WriteLine($"No matches");
            }
            else
            {
                Console.WriteLine($"{maxIndex}");
            }
        }

        private static void GetMinEven(List<int> input)
        {
            int currMinDigit = int.MaxValue;
            int maxIndex = -1;
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] % 2 == 0)
                {
                    if (currMinDigit >= input[i])
                    {
                        currMinDigit = input[i];
                        maxIndex = i;
                    }
                }
            }
            if (maxIndex == -1)
            {
                Console.WriteLine($"No matches");
            }
            else
            {
                Console.WriteLine($"{maxIndex}");
            }
        }

        private static void GetMaxOdd(List<int> input)
        {
            int currMaxDigit = int.MinValue;
            int maxIndex = -1;
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] % 2 != 0)
                {
                    if (currMaxDigit <= input[i])
                    {
                        currMaxDigit = input[i];
                        maxIndex = i;
                    }
                }
            }
            if (maxIndex == -1)
            {
                Console.WriteLine($"No matches");
            }
            else
            {
                Console.WriteLine($"{maxIndex}");
            }
        }

        private static void GetMaxEven(List<int> input)
        {
            int currMaxDigit = int.MinValue;
            int maxIndex = -1;
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] % 2 == 0)
                {
                    if (currMaxDigit <= input[i])
                    {
                        currMaxDigit = input[i];
                        maxIndex = i;
                    }
                }
            }
            if (maxIndex == -1)
            {
                Console.WriteLine($"No matches");
            }
            else
            {
                Console.WriteLine($"{maxIndex}");
            }
        }

        private static List<int> RearangeList(List<int> input, string[] commands)
        {
            int splitIndex = int.Parse(commands[1]);
            if (splitIndex >= 0 && splitIndex < input.Count)
            {
                List<int> leftList = new List<int>();
                List<int> rightList = new List<int>();

                for (int i = 0; i < splitIndex + 1; i++)
                {
                    leftList.Add(input[i]);
                }
                for (int i = leftList.Count; i < input.Count; i++)
                {
                    rightList.Add(input[i]);
                }
                input = new List<int>();
                input.AddRange(rightList);
                input.AddRange(leftList);

                //Console.WriteLine($"{string.Join(" ", input)}");
            }
            else
            {
                Console.WriteLine($"Invalid index");
            }

            return input;
        }
    }
}
