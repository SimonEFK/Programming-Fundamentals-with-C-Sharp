using System;

namespace Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double numberOne = double.Parse(Console.ReadLine());
            double result = MathPower(number, numberOne);
            Console.WriteLine(result);
        }

        static double MathPower(double number,double numberOne)
        {
            double result = Math.Pow(number, numberOne);
            return result;

        }
    }
}
