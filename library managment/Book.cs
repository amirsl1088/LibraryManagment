using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_managment
{
    public abstract class Book:ICommonoperators
    {
        public Book(string name,string writer)
        {
            Name = name;
            Writer = writer;
        }
        public string? Name { get; set; }
        public string? Writer { get; set; }

        public abstract void AddBook(Book book);


        public abstract void ReamoveBook(Book book);


        public abstract void ShowDetails(Book book);
        
    }
}
