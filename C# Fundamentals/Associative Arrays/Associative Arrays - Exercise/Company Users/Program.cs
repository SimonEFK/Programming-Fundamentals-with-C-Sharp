using System;
using System.Collections.Generic;
using System.Linq;

namespace Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeList = new SortedDictionary<string, List<string>>();

            string[] input = Console.ReadLine()
                .Split("->", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (input[0] != "End")
            {
                string company = input[0];
                string employeeId = input[1];

                if (!(employeList.ContainsKey(company)))
                {
                    employeList.Add(company, new List<string>() { employeeId });
                }
                else
                {
                    if (!(employeList[company].Contains(employeeId)))
                    {
                        employeList[company].Add(employeeId);

                    }
                }



                input = Console.ReadLine()
                .Split("->", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }
            foreach (var company in employeList)
            {
                Console.WriteLine($"{company.Key}");
                foreach (var item in company.Value)
                {
                    Console.WriteLine($"--{item}");
                }
            }
        }
    }
}
