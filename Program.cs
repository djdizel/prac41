using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac41
{
    public delegate int BookComparison(Book book1, Book book2);

    internal class Program
    {
        public static int CompareByName(Book book1, Book book2)
        {
            return book1.NameBook1.CompareTo(book2.NameBook1);
        }

        public static int CompareByAuthor(Book book1, Book book2)
        {
            return book1.Author1.CompareTo(book2.Author1);
        }

        public static int CompareByPublishing(Book book1, Book book2)
        {
            return book1.Publishing1.CompareTo(book2.Publishing1);
        }

        static void Main(string[] args)
        {
            List<Book> bookList = new List<Book>();
            BookArray bookArray = new BookArray(bookList);

            while (true)
            {
                Console.WriteLine("1. Добавить книгу");
                Console.WriteLine("2. Показать список книг");
                Console.WriteLine("3. Сортировать книги по названию");
                Console.WriteLine("4. Сортировать книги по автору");
                Console.WriteLine("5. Сортировать книги по издательству");
                Console.WriteLine("6. Выход");
                Console.Write("Введите число: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Неверный ввод. Пожалуйста, введите число от 1 до 6.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Введите название книги: ");
                        string name = Console.ReadLine();
                        Console.Write("Введите автора книги: ");
                        string author = Console.ReadLine();
                        Console.Write("Введите издательство книги: ");
                        string publishing = Console.ReadLine();
                        bookArray.AddBook(new Book(name, author, publishing));
                        Console.WriteLine("Книга добавлена.");
                        break;
                    case 2:
                        if (bookArray.books.Count == 0)
                        {
                            Console.WriteLine("Список книг пуст.");
                        }
                        else
                        {
                            Console.WriteLine("Список книг:");
                            foreach (var book in bookArray.books)
                            {
                                Console.WriteLine(book);
                            }
                        }

                        break;
                    case 3:
                        if (bookArray.books.Count > 0)
                        {
                            BookComparison sortByName = new BookComparison(CompareByName);
                            bookArray.SortBooks(sortByName);
                            Console.WriteLine("Книги отсортированы по названию.");
                        }
                        else
                        {
                            Console.WriteLine("Список книг пуст. Сортировать нечего.");
                        }

                        break;
                    case 4:
                        if (bookArray.books.Count > 0)
                        {
                            BookComparison sortByAuthor = new BookComparison(CompareByAuthor);
                            bookArray.SortBooks(sortByAuthor);
                            Console.WriteLine("Книги отсортированы по автору.");
                        }
                        else
                        {
                            Console.WriteLine("Список книг пуст. Сортировать нечего.");
                        }

                        break;
                    case 5:
                        if (bookArray.books.Count > 0)
                        {
                            BookComparison sortByPublishing = new BookComparison(CompareByPublishing);
                            bookArray.SortBooks(sortByPublishing);
                            Console.WriteLine("Книги отсортированы по издательству.");
                        }
                        else
                        {
                            Console.WriteLine("Список книг пуст. Сортировать нечего.");
                        }

                        break;
                    case 6:
                        Console.WriteLine("Выход из программы...");
                        return;
                    default:
                        Console.WriteLine("Неверный выбор. Пожалуйста, введите число от 1 до 6.");
                        break;
                }

                Console.WriteLine(); 
            }
        }
    }
}
