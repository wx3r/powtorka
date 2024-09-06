using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace powtorka
{
    public class Book : IMediaItem
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int NumberOfPages { get; set; }

        public Book(string title, string author, int numberOfPages)
        {
            Title = title;
            Author = author;
            NumberOfPages = numberOfPages;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, Number of Pages: {NumberOfPages}");
        }
    }
}