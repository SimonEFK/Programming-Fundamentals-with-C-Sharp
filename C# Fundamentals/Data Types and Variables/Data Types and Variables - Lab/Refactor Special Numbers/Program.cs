using System;

namespace Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int num = i;
                int sum = 0;

                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }

                bool isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", num, isSpecial);
                //sum = 0;
                i = num;
            }


        }
    }
}
