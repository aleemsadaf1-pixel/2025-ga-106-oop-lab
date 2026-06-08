using System;
using System.Collections.Generic;

class Product
{
    public string Name;
    public double Price;
    public int Stock;
    public double TaxRate;

    public Product(string name, double price, int stock, double taxRate)
    {
        Name = name;
        Price = price;
        Stock = stock;
        TaxRate = taxRate;
    }

    public double CalculateTax()
    {
        return Price * TaxRate;
    }
}

class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>()
        {
            new Product("Milk", 200, 5, 0.1),
            new Product("Bread", 150, 8, 0.1),
            new Product("Laptop", 120000, 3, 0.15),
            new Product("Mouse", 2000, 20, 0.1),
            new Product("Keyboard", 5000, 0, 0.1)
        };

        Console.WriteLine("--- STORE SYSTEM STARTED ---");

        double totalTax = 0;
        Product expensive = products[0];

        foreach (var p in products)
        {
            if (p.Stock > 0)
                totalTax += p.CalculateTax();

            if (p.Price > expensive.Price)
                expensive = p;
        }

        Console.WriteLine("Total Store Tax: " + totalTax);

        Console.WriteLine("Low Stock Products:");
        foreach (var p in products)
        {
            if (p.Stock < 10 && p.Stock > 0)
                Console.WriteLine(p.Name + " (Stock: " + p.Stock + ")");
        }

        Console.WriteLine("Most Expensive Product:");
        Console.WriteLine(expensive.Name + " → Price: " + expensive.Price);

        Console.WriteLine("--- STORE REPORT GENERATED ---");
    }
}