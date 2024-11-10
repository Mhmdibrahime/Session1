namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();
            book.SetTitle("Book1");
            book.SetAuthor("author");

            Console.WriteLine(book.Title + book.Author);
        }
    }
}
