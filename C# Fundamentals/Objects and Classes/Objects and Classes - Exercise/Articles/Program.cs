using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            int count = int.Parse(Console.ReadLine());

            string title = input[0];
            string content = input[1];
            string author = input[2];

            Articles artical = new Articles(title, content, author);

            for (int i = 0; i < count; i++)
            {
                string[] info = Console.ReadLine()
                    .Split(": ", StringSplitOptions.RemoveEmptyEntries);
                string command = info[0];
                if (command == "Edit")
                {
                    string newContent = info[1];

                    artical.EditContent(newContent);
                }
                else if (command== "ChangeAuthor")
                {
                    string newAuthor = info[1];
                    artical.ChangeAuthor(newAuthor);
                }
                else//Rename
                {
                    string newATitle = info[1];
                    artical.RenameTitle(newATitle);
                }
            }
            Console.WriteLine(artical);



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

        public void EditContent(string newContent)
        {
            Content = newContent;
        }
        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }
        public void RenameTitle(string newTitle)
        {
            Title = newTitle;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
