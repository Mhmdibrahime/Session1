using System.Net.Http.Headers;

namespace Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            //Console.WriteLine(library.books
            //    .Count);
            
            //library.BooksThathavemorethan500Pages();

            library.BookFilter(IsGreaterThan500);
            Console.WriteLine("-----------------------");
            library.BookFilter(delegate(Book book) { return book.Pages > 700; });
            Console.WriteLine("-----------------------");
            library.BookFilter((Book book) =>  book.Author == "George R.R. Martin"); 
            Console.WriteLine("-----------------------");
            library.BookFilter(book => book.Author == "J.K. Rowling");

        }
        public static bool IsGreaterThan500(Book book) => book.Pages > 500;
    }
}
