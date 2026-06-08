using System;
using System.Collections.Generic;

class Book
{
    public string Title;
    public string Author;
    public string Genre;
    public float Rating;
    public Book(string title, string author, string genre, float rating)
    {
        Title = title;
        Author = author;
        Genre = genre;
        Rating = rating;
    }
    public Book(Book b)
    {
        Title = b.Title;
        Author = b.Author;
        Genre = b.Genre;
        Rating = b.Rating;
    }

    public void Display()
    {
        Console.WriteLine(Title + " | " + Author + " | " + Genre + " | Rating: " + Rating);
    }
}

class Program
{
    static void Main()
    {
        List<Book> books = new List<Book>()
        {
            new Book("Atomic Habits", "James Clear", "Self Help", 4.8f),
            new Book("Deep Work", "Cal Newport", "Self Help", 4.7f),
            new Book("Mindset", "Carol Dweck", "Self Help", 4.4f),
            new Book("Clean Code", "Robert Martin", "Programming", 4.6f),
            new Book("The Hobbit", "Tolkien", "Fantasy", 4.3f)
        };

        Console.WriteLine("--- LIBRARY SYSTEM STARTED ---");

        Console.WriteLine("Top Rated Books:");
        float highest = 0;

        foreach (var b in books)
        {
            if (b.Rating > 4.5)
            {
                Console.WriteLine(b.Title + " (Rating: " + b.Rating + ")");
            }

            if (b.Rating > highest)
                highest = b.Rating;
        }

        Console.WriteLine("\nSearch Genre: Self Help");
        foreach (var b in books)
        {
            if (b.Genre == "Self Help")
                Console.WriteLine(b.Title);
        }

        List<Book> recommended = new List<Book>();

        foreach (var b in books)
        {
            if (b.Rating == highest)
            {
                recommended.Add(new Book(b)); 
                Console.WriteLine("\nRecommended Book Added:");
                Console.WriteLine(b.Title);
            }
        }

        Console.WriteLine("\n--- LIBRARY REPORT COMPLETE ---");
    }
}