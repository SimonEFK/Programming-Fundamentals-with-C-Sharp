using System;

namespace Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int num01 = int.Parse(Console.ReadLine());
            int num02 = int.Parse(Console.ReadLine());
            int num03 = int.Parse(Console.ReadLine());
            int num04 = int.Parse(Console.ReadLine());
            int sum = (num01 + num02) / num03;
            Console.Write($"{sum * num04}");

        }
    }
}
