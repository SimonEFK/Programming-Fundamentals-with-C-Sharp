using System;

namespace Math_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            int numberAlpha = int.Parse(Console.ReadLine());

            Console.WriteLine($"{MathOperation(number,command,numberAlpha)}");
        }

        static double MathOperation(int number,string command,int numberAlpha)
        {
            if (command=="/")
            {
                return number / numberAlpha;
            }
            else if (command=="*")
            {
                return number * numberAlpha;
            }
            else if (command=="+")
            {
                return number + numberAlpha;
            }
            else
            {
                return number - numberAlpha;
            }

        }
    }
}
