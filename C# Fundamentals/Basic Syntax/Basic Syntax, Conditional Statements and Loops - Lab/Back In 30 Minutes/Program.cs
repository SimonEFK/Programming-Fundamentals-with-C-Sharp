using System;

namespace Back_in_30_minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine())*60;
            int minutes = int.Parse(Console.ReadLine());
            int totalHours = (minutes+hours+30) /60;
            int totalMinutes = (hours + minutes+30)%60;
            if (totalHours>23)
            {
                totalHours = 0;
            }
            Console.WriteLine("{0}:{1:d2}",totalHours,totalMinutes);
        }
    }
}
