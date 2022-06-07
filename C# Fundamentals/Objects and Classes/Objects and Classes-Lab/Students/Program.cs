using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {

            Dice diceOne = new Dice();
            diceOne.Color = "Red";
            diceOne.Sides = 1000;

            Dice diceTwo = new Dice();
            diceTwo.Color = "Blue";
            diceTwo.Sides = 1000;
            int attempt = LuckyBoy(diceOne, diceTwo);
            Console.WriteLine($"Attempt {attempt}");
            

















            //        List<StudentInfo> studentsInfo = new List<StudentInfo>();

            //        string input = Console.ReadLine();
            //        while (input != "end")
            //        {


            //            string[] info = input
            //                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            //            string name = info[0];
            //            string lastName = info[1];
            //            int age = int.Parse(info[2]);
            //            string city = info[3];

            //            StudentInfo student = new StudentInfo();
            //            student.Name = name;
            //            student.LastName = lastName;

            //            student.Age = age;
            //            student.City = city;
            //            studentsInfo.Add(student);

            //            input = Console.ReadLine();
            //        }
            //        string cityFilter = Console.ReadLine();

            //        foreach (var item in studentsInfo.Where(x => x.City == cityFilter))
            //        {
            //            Console.WriteLine($"{item.Name} {item.LastName} is {item.Age} years old.");
            //        }

            //    }
            //}

            //class StudentInfo
            //{
            //    public string Name { get; set; }
            //    public string LastName { get; set; }
            //    public int Age { get; set; }
            //    public string City { get; set; }
        }

        private static int LuckyBoy(Dice diceOne, Dice diceTwo)
        {
            int redDiceRoll = diceOne.Roll();
            int blueDiceRoll = diceTwo.Roll();
            int counter = 0;
            bool jackpot = false;
            do
            {
                redDiceRoll = diceOne.Roll();
                blueDiceRoll = diceTwo.Roll();
                counter++;

                if (redDiceRoll == 666 && blueDiceRoll == 666)
                {
                    jackpot = true;
                    return counter;
                }

            } while (jackpot == false);
            return counter;
        }
    }
}
