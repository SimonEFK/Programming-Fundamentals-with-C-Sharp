using System;
using System.Numerics;
namespace Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger input = BigInteger.Parse(Console.ReadLine());
            FactorialSum(input);
            Console.WriteLine($"{FactorialSum(input).ToString()}");
        }

        private static BigInteger FactorialSum(BigInteger input)
        {
            BigInteger number = 1;

            for (int i = 1; i <= input; i++)
            {
                number *= i;
            }
            return number;
        }
    }
}
