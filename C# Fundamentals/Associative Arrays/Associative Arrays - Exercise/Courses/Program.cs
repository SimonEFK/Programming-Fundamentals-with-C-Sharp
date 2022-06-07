using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" : ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var cAndS = new Dictionary<string, List<string>>();

            while (input[0] != "end")
            {
                string course = input[0];
                string studentName = input[1];

                if (!(cAndS.ContainsKey(course)))
                {
                    cAndS.Add(course, new List<string>());
                    cAndS[course].Add(studentName);
                }
                else
                {
                    cAndS[course].Add(studentName);
                }
                cAndS[course].Sort();
                input = Console.ReadLine()
                .Split(" : ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }

            foreach (var course in cAndS.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");

                foreach (var item in course.Value)
                {
                    Console.WriteLine($"-- {item}");
                }

            }

        }
    }
}
