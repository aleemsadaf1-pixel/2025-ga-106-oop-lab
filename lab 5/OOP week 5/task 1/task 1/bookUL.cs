using System;

class BookUI
{
    public static BookBL TakeInput()
    {
        Console.Write("Enter Title: ");
        string t = Console.ReadLine();

        Console.Write("Enter Author: ");
        string a = Console.ReadLine();

        return new BookBL(t, a);
    }

    public static void ShowBooks()
    {
        foreach (var b in BookDL.GetBooks())
        {
            Console.WriteLine(b.Title + " - " + b.Author);
        }
    }
}