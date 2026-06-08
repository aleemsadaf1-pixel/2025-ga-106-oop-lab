using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1.Add Book");
            Console.WriteLine("2.View Books");
            Console.WriteLine("3.Search Book");
            Console.WriteLine("4.Exit");

            int op = int.Parse(Console.ReadLine());

            if (op == 1)
            {
                BookBL b = BookUI.TakeInput();
                BookDL.AddBook(b);
            }
            else if (op == 2)
            {
                BookUI.ShowBooks();
            }
            else if (op == 3)
            {
                Console.Write("Enter Title: ");
                string t = Console.ReadLine();

                BookBL b = BookDL.SearchBook(t);

                if (b != null)
                    Console.WriteLine("Found: " + b.Title);
                else
                    Console.WriteLine("Not Found");
            }
            else if (op == 4)
            {
                break;
            }
        }
    }
}