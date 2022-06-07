using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{AddnSubtract()}");
        }

        private static int AddnSubtract()
        {
            List<int> list = new List<int>();
            for (int i = 0; i < 3; i++)
            {
                int number = int.Parse(Console.ReadLine());
                list.Add(number);
            }
            int result = list[0] + list[1] - list[2];
            return result;
        }
    }
}
