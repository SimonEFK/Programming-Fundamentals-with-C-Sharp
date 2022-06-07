using System;

namespace Lab_Data_Types_and_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal n = decimal.Parse(Console.ReadLine()) / 1000;
            Console.WriteLine($"{n:f2}");

        }
    }
}
