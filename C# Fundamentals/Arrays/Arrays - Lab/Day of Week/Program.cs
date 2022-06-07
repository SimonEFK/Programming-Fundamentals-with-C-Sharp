using System;
using System.Linq;

namespace Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWEEK = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int n = int.Parse(Console.ReadLine());
            if (n > 7 || n <= 0)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(daysOfWEEK[n - 1]);

            }
        }
    }
}
