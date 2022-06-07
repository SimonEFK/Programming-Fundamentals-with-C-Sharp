using System;
using System.Collections.Generic;

namespace Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {

            Masseges phrases = new Masseges(new List<string>()  { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." });
            Masseges events = new Masseges(new List<string>() { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" });
            Masseges authors = new Masseges(new List<string>() { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" });
            Masseges cities = new Masseges(new List<string>() { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" });
            Console.WriteLine($"{phrases.GetRandomPhrase()} {events.GetRandomPhrase()} {authors.GetRandomPhrase()} - {cities.GetRandomPhrase()}");






        }
    }


    public class Masseges
    {
        public Masseges(List<string> input)
        {
            Phrases = input;

        }
        public List<string> Phrases { get; set; }
        public string GetRandomPhrase()
        {
            Random random = new Random();
            return Phrases[random.Next(0, Phrases.Count)];
        }
    }
}
