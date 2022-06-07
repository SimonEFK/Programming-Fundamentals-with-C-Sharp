using System;
using System.Linq;

namespace ExerciseArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] wagons = new int[int.Parse(Console.ReadLine())];

            int sum = 0;

            for (int i = 0; i < wagons.Length; i++)
            {
                wagons[i] = int.Parse(Console.ReadLine());
                sum += wagons[i];
                if (i == wagons.Length - 1)
                {
                    foreach (int item in wagons)
                    {
                        Console.Write(item + " ");
                    }
                }
            }
            Console.WriteLine($"\n{sum}");



        }
    }
}
