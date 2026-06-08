using System;
using System.Collections.Generic;
using System.Security.Policy;

class Book
{
    public string Title;
    public double Price;

    public Book(string t, double p)
    {
        Title = t;
        Price = p;
    }
}

class Member
{
    public string Name;
    public int ID;

    public Member(string n, int id)
    {
        Name = n;
        ID = id;
    }
}

class Program
{
    static void Main()
    {
        List<Book> books = new List<Book>();
        List<Member> members = new List<Member>();

        books.Add(new Book("OOP", 500));
        members.Add(new Member("Ali", 1));

        Console.WriteLine("System Running");
    }
}