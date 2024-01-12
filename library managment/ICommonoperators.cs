using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_managment
{
    public interface ICommonoperators
    {
        void AddBook(Book book);
        void ReamoveBook(Book book);
        void ShowDetails(Book book);
    }
}
