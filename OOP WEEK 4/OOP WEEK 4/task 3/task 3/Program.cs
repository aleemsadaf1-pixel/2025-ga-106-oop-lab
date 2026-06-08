using System;
using System.Collections.Generic;

class Product
{
    public string Name;
    public double Price;

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public double Tax()
    {
        return Price * 0.1;
    }
}

class Customer
{
    public string Name;
    public List<Product> products = new List<Product>();

    public Customer(string name)
    {
        Name = name;
    }

    public void AddProduct(Product p)
    {
        products.Add(p);
    }

    public double TotalTax()
    {
        double tax = 0;
        foreach (var p in products)
            tax += p.Tax();

        return tax;
    }
}

class Program
{
    static void Main()
    {
        Customer c = new Customer("Ali");

        c.AddProduct(new Product("Laptop", 100000));
        c.AddProduct(new Product("Mouse", 2000));

        Console.WriteLine("Total Tax: " + c.TotalTax());
    }
}