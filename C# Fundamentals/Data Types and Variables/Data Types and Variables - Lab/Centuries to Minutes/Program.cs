using System;

namespace Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());
            short years = (short)(centuries * 100);
            int days = (int)(365.2422 * years);
            long hours = (long)(days * 24);
            long minutes = (long)(hours * 60);

            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes", centuries, years, days, hours, minutes);

        }
    }
}
