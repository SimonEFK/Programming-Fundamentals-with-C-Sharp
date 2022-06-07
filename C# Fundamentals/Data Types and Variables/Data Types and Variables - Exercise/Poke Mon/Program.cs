using System;

namespace Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int targetDistance = int.Parse(Console.ReadLine());
            int exhaustion = int.Parse(Console.ReadLine());

            double fiftyPercent = pokePower / 2;
            int pokes = 0;

            while (pokePower >= targetDistance)
            {
                pokePower -= targetDistance;
                if (pokePower == fiftyPercent && exhaustion > 0)
                {
                    pokePower = (int)(pokePower / exhaustion);
                }

                pokes++;
            }
            Console.WriteLine($"{pokePower}\n{pokes}");


        }
    }
}
