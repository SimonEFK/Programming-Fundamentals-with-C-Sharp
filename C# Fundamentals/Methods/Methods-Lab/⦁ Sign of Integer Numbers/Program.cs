using System;

namespace __Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintSign(number);


        }



        static void PrintSign(int number)
        {
             string answer = string.Empty;

            if (number<0)
            {
                answer = ($"The number {number} is negative.");
            }

            else if  (number > 0)
            {
                answer = ($"The number {number} is positive.");
            }
            else
            {
                answer = ($"The number {number} is zero.");
            }
            Console.WriteLine(answer);


        }
    }
}
