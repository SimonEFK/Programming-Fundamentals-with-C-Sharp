using System;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int divNum = 0;


            if (num % 10 == 0)
            {
                divNum = 10;
            }
            else if (num % 7 == 0)
            {
                divNum = 7;
            }
            else if (num % 6 == 0)
            {
                divNum = 6;
            }
            else if (num % 3 == 0)
            {
                divNum = 3;
            }
            else if (num % 2 == 0)
            {
                divNum = 2;
                if (num % 2 == 0 && num % 3 == 0)
                {
                    divNum = 6;
                }
                if (num % 2 == 0 && num % 10 == 0)
                {
                    divNum = 10;
                }
            }
            else
            {
                Console.WriteLine($"Not divisible");
                return;
            }

            Console.WriteLine($"The number is divisible by {divNum}");
        }
    }
}
