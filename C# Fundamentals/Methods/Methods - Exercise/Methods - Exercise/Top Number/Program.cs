using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            TopNumber(number);
        }

        private static void TopNumber(int number)
        {
            for (int i = 10; i <= number; i++)
            {
                string currNumber = i.ToString();
                double currResult = 0;
                bool digitIsOdd = false;
                bool isDivisibleBy8 = false;
                for (int k = 0; k < currNumber.Length; k++)
                {
                    currResult += int.Parse(currNumber[k].ToString());
                    int currDigit = int.Parse(currNumber[k].ToString());
                    if (currDigit == 1 || currDigit == 3 || currDigit == 5 || currDigit == 7 || currDigit == 9)
                    {
                        digitIsOdd = true;
                    }
                }
                if (currResult % 8 == 0)
                {
                    isDivisibleBy8 = true;
                }
                if (isDivisibleBy8 && digitIsOdd)
                {
                    Console.WriteLine($"{i}");
                }

            }
        }
    }
}
