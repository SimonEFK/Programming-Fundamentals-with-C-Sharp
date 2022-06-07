using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().TrimStart('0');
            int multiplayer = int.Parse(Console.ReadLine());

            StringBuilder result = new StringBuilder();
            int currResult = 0;
            int currFirstDigit = 0;

            if (input == "" || multiplayer == 0)
            {
                Console.WriteLine("0");
                return;
            }
            for (int i = input.Length - 1; i >= 0; i--)
            {

                int currDigit = int.Parse(input[i].ToString());

                currResult = multiplayer * currDigit + currFirstDigit;
                int currResultLastDigit = currResult % 10;

                currFirstDigit = currResult / 10;
                result.Insert(0, currResultLastDigit);

            }

            if (currFirstDigit > 0)
            {

                result.Insert(0, currFirstDigit);
            }
            Console.WriteLine($"{result}");
        }
    }
}
