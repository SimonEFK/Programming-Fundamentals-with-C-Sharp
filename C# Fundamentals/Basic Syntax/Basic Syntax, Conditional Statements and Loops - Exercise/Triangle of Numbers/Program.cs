using System;

namespace Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int nToWrite = 0;
            int row = 0;
            for (int i = 1; i <= n; i++)
            {
                nToWrite++;
                row++;
                for (int j = 1; j <=row; j++)
                {
                    Console.Write($"{nToWrite} ");
                }
                Console.WriteLine();
            }

        }
    }
}
