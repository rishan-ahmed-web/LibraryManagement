using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace LibraryManagement
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

        public Book(string title, string author, string iSBN)
        {
            Title = title;
            Author = author;
            ISBN = iSBN;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Title} | Author: {Author} | ISBN : {ISBN} ");
        }
    }
}
