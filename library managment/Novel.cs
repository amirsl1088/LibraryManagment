using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_managment
{
    public class Novel:Book
    {
        public Novel(string name,string writer,int spreadingyear):base(name,writer)
        {
            SpreadingYear = spreadingyear;
        }
        public int SpreadingYear { get; set; }

        public override void AddBook(Book book)
        {
            Console.WriteLine($"{book.Name} novel is added succesfully...");
        }

        public override void ReamoveBook(Book book)
        {
            Console.WriteLine($"{book.Name} novel is reamoved succesfully...");
        }

        public override void ShowDetails(Book book)
        {
            Console.WriteLine($"novel name={book.Name}, writername={book.Writer}, spreadingyear={SpreadingYear}");
        }
    }
}
