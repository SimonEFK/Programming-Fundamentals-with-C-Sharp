using System;
using System.Numerics;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int snowballs = int.Parse(Console.ReadLine());
            BigInteger theBestValue = 0;

            int theBestSnowballSnow = 0;
            int theBestBallTime = 0;
            int theBestQuality = 0;

            for (int i = 1; i <= snowballs; i++)
            {

                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger currValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                if (currValue >= theBestValue)
                {
                    theBestValue = currValue;
                    theBestSnowballSnow = snowballSnow;
                    theBestBallTime = snowballTime;
                    theBestQuality = snowballQuality;
                }
            }
            Console.WriteLine("{0} : {1} = {2} ({3})", theBestSnowballSnow, theBestBallTime, theBestValue, theBestQuality);
        }
    }
}
