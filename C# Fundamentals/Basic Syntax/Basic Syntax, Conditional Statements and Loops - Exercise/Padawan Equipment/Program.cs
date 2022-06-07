using System;

namespace Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int padawans = int.Parse(Console.ReadLine());
            double lightSabersCost = double.Parse(Console.ReadLine());
            double robesCost = double.Parse(Console.ReadLine());
            double beltsCost = double.Parse(Console.ReadLine());

            int lightSCount = (int)Math.Ceiling(padawans * 1.1);
            int beltsCount = padawans - padawans / 6;
            double robesCount = padawans;

            double total = lightSCount * lightSabersCost + beltsCost * beltsCount + robesCost * robesCount;
            if (money >= total)
            {
                Console.WriteLine($"The money is enough - it would cost {total:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {total - money:f2}lv more.");
            }

        }
    }
}
