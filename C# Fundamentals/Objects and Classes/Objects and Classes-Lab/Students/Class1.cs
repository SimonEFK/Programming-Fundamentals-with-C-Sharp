using System;
using System.Collections.Generic;
using System.Text;

namespace Students
{
    class Dice
    {
        public int Sides { get; set; }
        public string Color { get; set; }
        

        public int  Roll()
        {
            Random rnd = new Random();
            int roll = rnd.Next(1,Sides+1);
            return roll;
        }
    }
}
