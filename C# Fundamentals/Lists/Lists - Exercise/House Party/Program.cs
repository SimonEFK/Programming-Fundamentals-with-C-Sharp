using System;
using System.Collections.Generic;
using System.Linq;
namespace House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int guestCap = int.Parse(Console.ReadLine());
            List<string> guestList = new List<string>();


            for (int i = 0; i < guestCap; i++)
            {
                string[] data = Console.ReadLine()
                    .Split()
                    .ToArray();
                string GuestName = data[0];
                if (data.Length <= 3)
                {
                    if (!guestList.Contains(GuestName))
                    {
                        guestList.Add(GuestName);
                    }
                    else
                    {
                        Console.WriteLine($"{ GuestName} is already in the list!");
                    }
                }
                else
                {
                    if (guestList.Contains(GuestName))
                    {
                        guestList.Remove(GuestName);
                    }
                    else
                    {
                        Console.WriteLine($"{ GuestName} is not in the list!");

                    }
                }





            }
            Console.WriteLine(string.Join(Environment.NewLine, guestList));
        }
    }
}
