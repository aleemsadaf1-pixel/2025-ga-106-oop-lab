using System;
using System.Collections.Generic;

class Author
{
    public string Name;

    public Author(string name)
    {
        Name = name;
    }
}

class Book
{
    public string Title;
    public Author author;

    public Book(string title)
    {
        Title = title;
    }

    public void AssignAuthor(Author a)
    {
        author = a;
    }

    public void Display()
    {
        Console.WriteLine(Title + " by " + author.Name);
    }
}

class Program
{
    static void Main()
    {
        Author a = new Author("Ali");
        Book b = new Book("OOP");

        b.AssignAuthor(a);
        b.Display();
    }
}