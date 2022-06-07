using System;

namespace Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double biggest = 0;

            string biggestKeg = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                string model = Console.ReadLine();
                float r = float.Parse(Console.ReadLine());
                int h = int.Parse(Console.ReadLine());

                double volume = Math.PI * (Math.Pow(r, 2)) * h;

                double currentVolue = volume;

                if (currentVolue >= biggest)
                {
                    biggest = currentVolue;
                    biggestKeg = model;
                }
            }
            Console.WriteLine(biggestKeg);
        }
    }
}
