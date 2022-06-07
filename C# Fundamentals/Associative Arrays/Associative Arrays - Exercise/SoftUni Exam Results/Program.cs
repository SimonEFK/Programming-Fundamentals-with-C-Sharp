using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var bestResultStorage = new Dictionary<string, int>();
            var languageSubmissions = new Dictionary<string, int>();
            //int bestPoints = int.MinValue;

            while (input != "exam finished")
            {
                string[] cmdArg = input.Split("-", StringSplitOptions.RemoveEmptyEntries);
                string studentName = cmdArg[0];

                if (cmdArg.Contains("banned"))
                {
                    bestResultStorage.Remove(studentName);
                }
                else
                {
                    string language = cmdArg[1];
                    int points = int.Parse(cmdArg[2]);

                    if (!(bestResultStorage.ContainsKey(studentName)))
                    {
                        bestResultStorage.Add(studentName, points);
                    }
                    else
                    {
                        if (bestResultStorage[studentName] < points)
                        {
                            bestResultStorage[studentName] = points;
                        }
                    }

                    if (!(languageSubmissions.ContainsKey(language)))
                    {
                        languageSubmissions.Add(language, 1);
                    }
                    else
                    {
                        languageSubmissions[language]++;
                    }
                }

                input = Console.ReadLine();
            }

            Print(bestResultStorage, languageSubmissions);
        }
        static void Print(Dictionary<string, int> bestResultStorage, Dictionary<string, int> languageSubmissions)
        {
            Console.WriteLine($"Results:");
            foreach (var item in bestResultStorage
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} | {item.Value}");
            }
            Console.WriteLine($"Submissions:");
            foreach (var item in languageSubmissions
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
