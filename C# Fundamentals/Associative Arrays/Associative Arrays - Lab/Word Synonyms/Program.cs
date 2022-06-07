using System;
using System.Collections.Generic;
using System.Linq;

namespace Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine()
                .Split()
                .ToArray();

            var dicOfSynonyms = new Dictionary<string, List<string>>();

            for (int i = 0; i < input.Length; i++)
            {
                if (dicOfSynonyms.ContainsKey(input[i]) == false)
                {
                    dicOfSynonyms.Add(input[i],new List<string>());

                }
               
            }
            









        }
    }
}
