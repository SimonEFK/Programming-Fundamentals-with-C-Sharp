using System;
using System.Collections.Generic;
using System.Linq;

namespace Articals_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Articles> listArticals = new List<Articles>();
            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);
                Articles currArticle = new Articles(input[0], input[1], input[2]);
                listArticals.Add(currArticle);

            }
            string sortBy = Console.ReadLine();
            if (sortBy=="title")
            {
                listArticals = listArticals.OrderBy(x => x.Title).ToList();
            }
            else if (sortBy=="content")
            {
                listArticals = listArticals.OrderBy(x => x.Content).ToList();
            }
            else//author
            {
                listArticals = listArticals.OrderBy(x => x.Author).ToList();
            }
            foreach (var item in listArticals)
            {
                Console.WriteLine($"{item.Title} - {item.Content}: {item.Author}");
            }
        }
    }






    class Articles
    {
        public Articles(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }



        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        //public void EditContent(string newContent)
        //{
        //    Content = newContent;
        //}
        //public void ChangeAuthor(string newAuthor)
        //{
        //    Author = newAuthor;
        //}
        //public void RenameTitle(string newTitle)
        //{
        //    Title = newTitle;
        //}
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
