using System;

class Transaction
{
    public int TransactionId;
    public string ProductName;
    public double Amount;
    public DateTime Date;
    public Transaction()
    {
        TransactionId = 0;
        ProductName = "Unknown";
        Amount = 0;
        Date = DateTime.Now;
    }
    public Transaction(int id, string name, double amount, DateTime date)
    {
        TransactionId = id;
        ProductName = name;
        Amount = amount;
        Date = date;
    }
    public Transaction(Transaction t)
    {
        TransactionId = t.TransactionId;
        ProductName = t.ProductName;
        Amount = t.Amount;
        Date = t.Date;
    }
    public void ShowTransaction()
    {
        Console.WriteLine("ID: " + TransactionId);
        Console.WriteLine("Product: " + ProductName);
        Console.WriteLine("Amount: " + Amount);
        Console.WriteLine("Date: " + Date);
        Console.WriteLine("------------------------");
    }
}

class Program
{
    static void Main(string[] args)
    {
       
        Transaction t1 = new Transaction(1, "Laptop", 85000, DateTime.Now);

        
        Transaction t2 = new Transaction(t1);

      
        t2.ProductName = "Mobile";
        t2.Amount = 45000;

        Console.WriteLine("Original Transaction:");
        t1.ShowTransaction();

        Console.WriteLine("Copied Transaction:");
        t2.ShowTransaction();
    }
}