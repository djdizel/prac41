using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac41
{
    public class Book
    {
        string NameBook;
        string Author;
        string Publishing;

        public Book(string nameBook, string author, string publishing)
        {
            NameBook1 = nameBook;
            Author1 = author;
            Publishing1 = publishing;
        }

        public string NameBook1 { get => NameBook; set => NameBook = value; }
        public string Author1 { get => Author; set => Author = value; }
        public string Publishing1 { get => Publishing; set => Publishing = value; }

        public override string ToString()
        {
            return $"Автор: {Author1}, название книги: {NameBook1}, издательство: {Publishing1}";
        }
    }
}
