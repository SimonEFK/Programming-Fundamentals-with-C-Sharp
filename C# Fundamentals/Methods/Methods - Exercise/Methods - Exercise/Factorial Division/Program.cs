using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            FactorialDivision(number, numberTwo);
        }

        private static void FactorialDivision(int number, int numberTwo)
        {
            double nOneFactorial = 1.0;
            double nTwoFactorial = 1.0;
            for (int i = 1; i <= number; i++)
            {
                nOneFactorial *= i;
            }
            for (int i = 1; i <= numberTwo; i++)
            {
                nTwoFactorial *= i;
            }
            double result = (nOneFactorial / nTwoFactorial);
            Console.WriteLine($"{result:f2}");
        }
    }
}
