using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
               
               
                
            int bombStrenght = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]=='>')
                {
                    bombStrenght = int.Parse(input[i + 1].ToString())+bombStrenght;
                    continue;
                }
                if (bombStrenght>0)
                {
                    input = input.Remove(i, 1);
                    bombStrenght--;
                    i--;
                }
                
                
            }
            
           
            Console.WriteLine(input);

        }
    }
}
