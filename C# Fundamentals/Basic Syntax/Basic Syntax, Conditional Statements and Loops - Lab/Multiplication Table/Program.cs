using System;

namespace Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            if (numTwo > 10)
            {
                Console.WriteLine($"{num} X {numTwo} = {num * numTwo}");
                return;
            }
            for (int i = numTwo; i <= 10; i++)
            {
                Console.WriteLine($"{num} X {i} = {num * i}");
            }
        }
    }
}
