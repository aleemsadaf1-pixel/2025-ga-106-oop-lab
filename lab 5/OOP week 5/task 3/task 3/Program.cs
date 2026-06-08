using System;
using System.Collections.Generic;

class Product
{
    public string Name;
    public string Category;
    public double Price;
    public int Stock;
    public int Threshold;

    public Product(string n, string c, double p, int s, int t)
    {
        Name = n;
        Category = c;
        Price = p;
        Stock = s;
        Threshold = t;
    }

    public double Tax()
    {
        if (Category == "Grocery") return Price * 0.1;
        else if (Category == "Fruit") return Price * 0.05;
        else return Price * 0.15;
    }
}

class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>();

        products.Add(new Product("Milk", "Grocery", 200, 5, 10));
        products.Add(new Product("Apple", "Fruit", 300, 20, 10));
        products.Add(new Product("Laptop", "Other", 100000, 2, 5));

        foreach (var p in products)
        {
            Console.WriteLine(p.Name + " Tax: " + p.Tax());
        }
    }
}