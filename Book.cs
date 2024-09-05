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
       int NumberOfPages { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public void DisplayInfo(string Title, string Description, int NumberOfPages)
        {
            Console.WriteLine("Title: ", Title, "\rDescription:", Description, "\rNumber of pages:",NumberOfPages);
        }

    }
}
