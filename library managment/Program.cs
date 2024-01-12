using library_managment;

while (true)
{
    Console.WriteLine("choose an option:\n1.add book \n2.remove book \n3.show books with details ");
    var input = int.Parse(Console.ReadLine()!);
    switch (input)
    {
        case 1:
            {
                Console.WriteLine("enter bookname");
                var bookName = Console.ReadLine()!;
                Console.WriteLine("1.novel    2.scientific");
                var type = int.Parse(Console.ReadLine()!);
                Console.WriteLine("enter writer name");
                var writerName = Console.ReadLine()!;
                Console.WriteLine("enter subject");
                var subject = Console.ReadLine()!;
                Console.WriteLine("enter spreading year");
                var spreadingYear = int.Parse(Console.ReadLine()!);
                Library.AddBook(bookName, writerName, type, spreadingYear, subject);
                break;
            }
        case 2:
            {
                Console.WriteLine("enter bookname");
                var bookName = Console.ReadLine();
                Library.ReamoveBook(bookName);
                break;
            }
        case 3:
            {
                foreach(var book in Library.GetBooks())
                {
                    if(book is Novel)
                    {
                        book.ShowDetails(book);
                    }
                    if(book is Scientific)
                    {
                        book.ShowDetails(book);
                    }
                }
                break;
            }
    }

}
