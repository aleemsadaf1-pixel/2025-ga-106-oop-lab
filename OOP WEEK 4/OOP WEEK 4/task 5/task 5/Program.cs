using System;

class Member
{
    public string Name;
    public int ID;
    public int BooksBought;
    public double AmountSpent;

    public Member(string name, int id)
    {
        Name = name;
        ID = id;
    }

    public void BuyBook(double price)
    {
        BooksBought++;
        AmountSpent += price;
    }
}

class Program
{
    static void Main()
    {
        Member m = new Member("Ali", 1);
        m.BuyBook(500);

        Console.WriteLine(m.BooksBought);
        Console.WriteLine(m.AmountSpent);
    }
}