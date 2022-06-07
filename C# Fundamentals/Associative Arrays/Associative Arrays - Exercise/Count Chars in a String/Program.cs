using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string data = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                data += input[i];
            }

            var dictionary = new Dictionary<char, int>();

            for (int i = 0; i < data.Length; i++)
            {

                if (!(dictionary.ContainsKey(data[i])))
                {
                    dictionary.Add(data[i], 1);
                }
                else
                {

                    dictionary[data[i]]++;
                }


            }
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }


        }
    }
}
