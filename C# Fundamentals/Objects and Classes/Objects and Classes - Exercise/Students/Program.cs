using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Student currStudent = new Student(input[0], input[1], double.Parse(input[2]));
                students.Add(currStudent);
            }
            students = students.OrderByDescending(x => x.Grade).ToList();

            Console.WriteLine($"{string.Join("\n", students)}");

        }

    }


    class Student
    {
        public Student(string name,string surname,double grade)
        {
            Name = name;
            Surname = surname;
            Grade = grade;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{Name} {Surname}: {Grade:f2}";
        }
    }
}
