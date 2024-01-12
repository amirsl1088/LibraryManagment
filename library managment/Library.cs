using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_managment
{
    public static class Library
    {
        private static List<Book> _books = new();
        public static void AddBook(string name,string writer,int type,int spredingyear,string subject)
        {
            if (type == 1)
            {
                var book = new Novel(name, writer, spredingyear);
                _books.Add(book);
                book.AddBook(book);
            }
            if (type == 2)
            {
                var book = new Scientific(name, writer, subject);
                _books.Add(book);
                book.AddBook(book);
            }
        }
        public static void ReamoveBook(string name)
        {
            var book = _books.Find(_ => _.Name == name);
            if(book is Novel)
            {
                _books.Remove(book);
                book.ReamoveBook(book);
            }
            if(book is Scientific)
            {
                _books.Remove(book);
                book.ReamoveBook(book);
            }
            if(book is null)
            {
                Console.WriteLine("wrong book");
            }
        }
        public static List<Book> GetBooks()
        {
            return _books;
        }
    }
}
