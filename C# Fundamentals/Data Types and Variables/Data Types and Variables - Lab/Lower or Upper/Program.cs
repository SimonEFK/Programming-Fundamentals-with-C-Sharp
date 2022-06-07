using System;

namespace Lower_or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            char inputAlpha = char.Parse(Console.ReadLine());
            bool isItUpper;
            isItUpper = char.IsUpper(inputAlpha);
            if (isItUpper == true)
            {
                Console.WriteLine("upper-case");

            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
