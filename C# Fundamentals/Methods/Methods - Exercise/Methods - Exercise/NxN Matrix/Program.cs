using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            NxNMatrix(number);
        }

        private static void NxNMatrix(int number)
        {
            for (int i = 0; i < number; i++)
            {
                
                
                    Console.WriteLine();

                

                for (int k = 0; k < number; k++)
                {
                    Console.Write(number + " ");
                }


            }
        }
    }
}
