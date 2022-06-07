using System;

namespace Print_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = startNum; i <= endNum; i++)
            {
                sum += i;
                Console.Write("{0} ",i);
            }
            Console.WriteLine();
            Console.Write($"Sum: {sum}");
        }
    }
}
