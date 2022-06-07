using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string currNum = string.Empty;

            double result = 0.0;
            string abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";




            for (int i = 0; i < input.Length; i++)
            {
                char firstChar = '0';
                char secondChar = '0';

                for (int k = 0; k < input[i].Length; k++)
                {
                    char currChar = input[i][k];
                    if (k == 0)
                    {
                        firstChar = currChar;
                        continue;
                    }
                    else if (char.IsLetter(currChar))
                    {

                        secondChar = currChar;
                        continue;
                    }

                    if (char.IsDigit(currChar))
                    {
                        currNum += currChar;
                    }
                }
                double number = double.Parse(currNum);


                int indexOfFirstChar = abc.IndexOf(char.ToUpper(firstChar)) + 1;
                int indexOfSecondChar = abc.IndexOf(char.ToUpper(secondChar)) + 1;
                


                if (char.IsUpper(firstChar))
                {

                    result += number / indexOfFirstChar;
                }
                else
                {

                    result += number * indexOfFirstChar;
                }

                if (char.IsUpper(secondChar))
                {

                    result -= indexOfSecondChar;
                }
                else
                {

                    result += indexOfSecondChar;
                }
                currNum = string.Empty;

            }
            Console.WriteLine($"{result:f2}");
        }
    }
}
