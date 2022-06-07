using System;
using System.Linq;

namespace Strong_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 1;
            string num = Console.ReadLine();
            int numConverted = int.Parse(num);
            double factorial = 0;
            double multiply = 1;
            for (int i =0; i <= num.Length-1; i++)
            {
                char currDigit = num[i];
                int converted = int.Parse(currDigit.ToString());
                for (int j = converted; j >=1; j--)
                {
                    sum *= j;
                    
                }
                factorial += sum;
                sum = 1;
                
            }
            if (factorial==numConverted)
            {
                Console.WriteLine($"yes");
            }
            else
            {
                Console.WriteLine($"no");
            }

        }
    }
}
