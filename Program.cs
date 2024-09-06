using System;

namespace powtorka
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            library.AddItem(new Book("Harry Potter", "J.K. Rowling", 500));
            library.AddItem(new Book("The Hobbit", "J.R.R. Tolkien", 310));
            library.AddItem(new Book("1984", "George Orwell", 328));

            Console.WriteLine("All books in the library:");
            library.DisplayAllItems();

            Console.WriteLine("\nEnter the title of the book you want to search for:");
            string userQuery = Console.ReadLine();
            IMediaItem foundItem = library.FindItemByTitle(userQuery);

            if (foundItem != null)
            {
                Console.WriteLine("\nBook found:");
                foundItem.DisplayInfo();
            }
            else
            {
                Console.WriteLine("\nBook not found.");
            }
        }
    }
}