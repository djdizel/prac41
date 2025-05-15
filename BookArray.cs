using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac41
{
    public class BookArray
    {
        List<Book> books;
        public BookArray(List<Book> books)
        {
            this.books = books;
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void SortBooks(BookComparison book)
        {
            BookComparison comparer = new BookComparison(book);
            books.Sort(comparer);
        } 
    }
}
