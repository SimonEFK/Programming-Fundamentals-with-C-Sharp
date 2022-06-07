using System;

namespace __Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());;

            double result = PrintRectArea(width,height);

            Console.WriteLine(result);
        }

         static double PrintRectArea(double width, double heigh)
         {
            return  width * heigh;
         }
    }
}
