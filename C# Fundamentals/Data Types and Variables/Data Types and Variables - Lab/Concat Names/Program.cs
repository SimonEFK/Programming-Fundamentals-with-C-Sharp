using System;

namespace Concat_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputAlpha = Console.ReadLine();
            string inputBeta = Console.ReadLine();
            string inputGamma = Console.ReadLine();
            Console.WriteLine("{0}{1}{2}", inputAlpha, inputGamma, inputBeta);
        }
    }
}
