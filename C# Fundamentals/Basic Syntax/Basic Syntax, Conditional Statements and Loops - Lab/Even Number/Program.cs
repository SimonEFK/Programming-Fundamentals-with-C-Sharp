using System;

namespace eVENnUMbERS
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int num = int.Parse(Console.ReadLine());
                if (num%2==0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(num)}");
                    return;
                }
                else
                {
                    Console.WriteLine($"Please write an even number.");
                }
            }
        }
    }
}
