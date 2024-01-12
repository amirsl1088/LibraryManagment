using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_managment
{
    public class Scientific:Book
    {
        public Scientific(string name,string writer,string subject):base(name,writer)
        {
            Subject = subject;
        }
        public string Subject { get; set; }

        public override void AddBook(Book book)
        {
            Console.WriteLine($"{book.Name} academic book is added succesfully...");
        }

        public override void ReamoveBook(Book book)
        {
            Console.WriteLine($"{book.Name} academic book is reamoved succesfully...");
        }

        public override void ShowDetails(Book book)
        {
            Console.WriteLine($"scientific name={book.Name}, writername={book.Writer}, subject={Subject}");
        }
    }
}
