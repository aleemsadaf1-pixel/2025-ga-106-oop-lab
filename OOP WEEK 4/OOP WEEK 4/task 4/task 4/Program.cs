using System;
using System.Collections.Generic;

class Book
{
    public string Title;
    public string ISBN;
    public int Stock;

    public Book(string t, string i, int s)
    {
        Title = t;
        ISBN = i;
        Stock = s;
    }
}

class Program
{
    static void Main()
    {
        List<Book> books = new List<Book>();

        while (true)
        {
            Console.WriteLine("1.Add 2.Search 3.Exit");
            int op = int.Parse(Console.ReadLine());

            if (op == 1)
            {
                books.Add(new Book(Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine())));
            }
            else if (op == 2)
            {
                string t = Console.ReadLine();
                foreach (var b in books)
                    if (b.Title == t)
                        Console.WriteLine("Found");
            }
            else break;
        }
    }
}
