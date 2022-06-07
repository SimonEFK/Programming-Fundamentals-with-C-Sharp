using System;

namespace Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal gBP = decimal.Parse(Console.ReadLine());
            gBP = gBP * 1.31M;
            Console.WriteLine($"{gBP:f3}");

        }
    }
}
