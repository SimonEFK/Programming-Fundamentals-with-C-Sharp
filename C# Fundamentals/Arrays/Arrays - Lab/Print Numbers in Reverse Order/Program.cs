using System;
using System.Linq;

namespace Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            int[] num = new int[range];

            for (int i = 0; i < range; i++)
            {
                int newNum = int.Parse(Console.ReadLine());
                num[i] = newNum;
            }
            for (int i = num.Length - 1; i >= 0; i--)
            {
                Console.Write(num[i] + " ");
            }

        }
    }
}
