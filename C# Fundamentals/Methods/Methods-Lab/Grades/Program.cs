using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            PrintGrade(grade);
        }

        static void PrintGrade(double grade)
        {
            string answer = string.Empty;

            if (grade >= 2.00&&grade<=2.99)
            {
                answer = "Fail";
            }
            else if (grade >= 3.00 && grade <=3.49)
            {
                answer = "Poor";
            }
            else if (grade >= 3.50 && grade <= 4.49)
            {
                answer = "Good";
            }
            else if (grade >= 4.50 && grade <= 5.49)
            {
                answer = "Very good";
            }0
            else if (grade >= 5.50 && grade <= 6.00)
            {
                answer = "Excellent";
            }
            Console.Write(answer);

        }
    }
}
