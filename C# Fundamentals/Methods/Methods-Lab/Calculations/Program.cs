using System;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            int numOne = int.Parse(Console.ReadLine());

            if (command== "add")
            {
                CalcAdd(num, numOne);
            }
            else if (command == "multiply")
            {
                CalcMultiply(num, numOne);
            }
            else if (command == "subtract")
            {
                CalcSub(num, numOne);
            }
            else if (command == "divide")
            {
                CalcDivide(num, numOne);
            }
        }

        static void CalcAdd(int num, int numOne)
        {
            Console.Write(num + numOne);

        }
        static void CalcMultiply(int num, int numOne)
        {
            Console.Write(num * numOne);

        }
        static void CalcSub(int num, int numOne)
        {
            Console.Write(num - numOne);

        }
        static void CalcDivide(int num, int numOne)
        {
            Console.Write(num / numOne);

        }
    }
}
