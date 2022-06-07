using System;
using System.Collections.Generic;
using System.Linq;

namespace Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Song> music = new List<Song>();
            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine()
                    .Split("_",StringSplitOptions.RemoveEmptyEntries);

                string type = input[0];
                string name = input[1];
                string time = input[2];

                Song song = new Song();
                song.TypeList = type;
                song.Name = name;
                song.Time = time;
                music.Add(song);
                
            }
            string typeList = Console.ReadLine();
            if (typeList=="all")
            {
                foreach (var item in music)
                {
                    Console.WriteLine($"{item.Name}");
                    Console.WriteLine($"{item.TypeList}");
                    Console.WriteLine($"{item.Time}");
                }
                
            }
            else
            {
                foreach (var item in music.Where(x=>x.TypeList==typeList))
                {
                    Console.WriteLine($"{item.Name}");
                }
            }


        }
    }
    class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}
