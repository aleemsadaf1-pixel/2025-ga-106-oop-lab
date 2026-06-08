using System.Collections.Generic;

class BookDL
{
    public static List<BookBL> books = new List<BookBL>();

    public static void AddBook(BookBL b)
    {
        books.Add(b);
    }

    public static List<BookBL> GetBooks()
    {
        return books;
    }

    public static BookBL SearchBook(string title)
    {
        foreach (var b in books)
        {
            if (b.Title == title)
                return b;
        }
        return null;
    }
}