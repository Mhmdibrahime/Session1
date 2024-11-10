using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class Library
    {
        public delegate bool BookFilterDelegate(Book book);

        public List<Book> books = new List<Book>();
        public Library()
        {
            books.Add(new Book("A Game of Thrones", "George R.R. Martin", 694));
            books.Add(new Book("A Clash of Kings", "George R.R. Martin", 768));
            books.Add(new Book("A Storm of Swords", "George R.R. Martin", 973));
            books.Add(new Book("A Feast for Crows", "George R.R. Martin", 753));
            books.Add(new Book("A Dance with Dragons", "George R.R. Martin", 1016));


            books.Add(new Book("Harry Potter and the Sorcerer's Stone ", "J.K. Rowling", 309));
            books.Add(new Book("Harry Potter and the Chamber of Secrets", "J.K. Rowling", 341));
            books.Add(new Book("Harry Potter and the Prisoner of Azkaban", "J.K. Rowling", 435));
            books.Add(new Book("Harry Potter and the Goblet of Fire", "J.K. Rowling", 734));
            books.Add(new Book("Harry Potter and the Order of the Phoenix", "J.K. Rowling", 870));
            books.Add(new Book("Harry Potter and the Half-Blood Prince", "J.K. Rowling", 652));
            books.Add(new Book("Harry Potter and the Deathly Hallows", "J.K. Rowling", 759));
        }

        public void BookFilter(BookFilterDelegate filterDelegate)
        {
            foreach(Book book in books)
            {
                if(filterDelegate(book))
                {
                    Console.WriteLine(book.Title);
                }
            }
        }
        public void BooksThathavemorethan500Pages()
        {
            int count = 0;
            foreach(var book in books)
            {
                if (book.Pages > 500)
                {
                    Console.WriteLine(book.Title);
                    count++;
                }

                
            }
            Console.WriteLine(count);
        }
        public void BooksThathavemorethan800Pages()
        {
            int count = 0;
            foreach (var book in books)
            {
                if (book.Pages > 800)
                {
                    Console.WriteLine(book.Title);
                    count++;
                }


            }
            Console.WriteLine(count);
        }
        public void BooksWithAuthorName()
        {
            int count = 0;
            foreach (var book in books)
            {
                if (book .Author == "George R.R. Martin")
                {
                    Console.WriteLine(book.Title);
                    count++;
                }


            }
            Console.WriteLine(count);
        }
    }
}
