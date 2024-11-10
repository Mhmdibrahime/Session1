using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    internal static class BookExtensions
    {
        public static void SetTitle(this Book book ,string title )
        {
            book.Title = title;
        }
        public static void SetAuthor(this Book book, string author)
        {
            book.Author = author;
        }

    }
}
