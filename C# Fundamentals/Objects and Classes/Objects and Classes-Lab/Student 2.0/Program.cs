using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<StudentInfo> studentsInfo = new List<StudentInfo>();

            string input = Console.ReadLine();
            while (input != "end")
            {


                string[] info = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = info[0];
                string lastName = info[1];
                int age = int.Parse(info[2]);
                string city = info[3];

                if (StudentExist(studentsInfo, name, lastName))
                {
                    StudentInfo currstudent = GetStudent(studentsInfo, name, lastName);
                    currstudent.Name = name;
                    currstudent.LastName = lastName;

                    currstudent.Age = age;
                    currstudent.City = city;
                    //studentsInfo.Add(currstudent);
                }
                else
                {


                    StudentInfo student = new StudentInfo();
                    student.Name = name;
                    student.LastName = lastName;

                    student.Age = age;
                    student.City = city;
                    studentsInfo.Add(student);
                }
                input = Console.ReadLine();
            }
            string cityFilter = Console.ReadLine();

            foreach (var item in studentsInfo.Where(x => x.City == cityFilter))
            {
                Console.WriteLine($"{item.Name} {item.LastName} is {item.Age} years old.");
            }

        }

        private static StudentInfo GetStudent(List<StudentInfo> studentsInfo, string name, string lastName)
        {
            StudentInfo existingStudent = null;

            foreach (var item in studentsInfo)
            {
                if (item.Name == name && item.LastName == lastName)
                {
                    existingStudent = item;


                }

            }
            return existingStudent;
        }

        private static bool StudentExist(List<StudentInfo> studentsInfo, string name, string lastName)
        {
            bool studentExist = false;
            foreach (var item in studentsInfo)
            {
                if (item.Name == name && item.LastName == lastName)
                {
                    studentExist = true;
                    return studentExist;
                }
            }
            return false;
        }
    }

    class StudentInfo
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }


    }
}
