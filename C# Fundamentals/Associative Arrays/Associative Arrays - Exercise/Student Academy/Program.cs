using System;
using System.Collections.Generic;
using System.Linq;

namespace Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var grades = new Dictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!(grades.ContainsKey(name)))
                {
                    grades.Add(name, new List<double>() { grade });

                }
                else
                {
                    grades[name].Add(grade);
                }
            }
            foreach (var item in grades)
            {
                if (item.Value.Average()<4.50)
                {
                    grades.Remove(item.Key);
                }
            }
            foreach (var item in grades.OrderByDescending(x=>x.Value.Average()))
            {
                Console.WriteLine($"{item.Key} -> {item.Value.Average():f2}");
            }

        }
    }
}
