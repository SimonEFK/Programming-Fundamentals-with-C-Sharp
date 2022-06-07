using System;

namespace Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char inputAlpha = char.Parse(Console.ReadLine());
            char inputBeta = char.Parse(Console.ReadLine());
            char inputGamma = char.Parse(Console.ReadLine());
            Console.Write("{0}{1}{2}", inputAlpha, inputBeta, inputGamma);
        }
    }
}
