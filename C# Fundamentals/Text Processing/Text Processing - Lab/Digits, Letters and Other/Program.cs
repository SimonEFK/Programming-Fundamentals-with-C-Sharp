using System;
using System.Linq;

namespace Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] cmdArg = input.ToCharArray();



            for (int i = 0; i < cmdArg.Length; i++)
            {
                if (char.IsDigit(cmdArg[i]))
                {
                    Console.Write(cmdArg[i]);
                }                                
            }
            Console.WriteLine();

            for (int i = 0; i < cmdArg.Length; i++)
            {
                if (char.IsLetter(cmdArg[i]))
                {
                    Console.Write(cmdArg[i]);
                }

            }
            Console.WriteLine();
            for (int i = 0; i < cmdArg.Length; i++)
            {
                if (!(char.IsLetter(cmdArg[i])) && (!(char.IsDigit(cmdArg[i]))))
                {
                    Console.Write(cmdArg[i]);
                }

            }


        }
    }
}
