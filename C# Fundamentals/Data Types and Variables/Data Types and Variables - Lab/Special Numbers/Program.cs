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
                int sum = 0;
                int num = i;
                while (num > 0)
                {
                    int lastDigit = num % 10;
                    sum += lastDigit;
                    num /= 10;

                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine("{0} -> True", i);
                }
                else
                {
                    Console.WriteLine("{0} -> False", i);
                }

            }

        }
    }
}
