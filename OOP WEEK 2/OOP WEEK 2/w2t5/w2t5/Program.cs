using System;
using System.Collections.Generic;
using System.Threading.Tasks;

class Product
{
    public int ID;
    public string Name;
    public double Price;
    public string Category;
    public string Brand;
    public string Country;

    public Product(int id, string name, double price, string category, string brand, string country)
    {
        ID = id;
        Name = name;
        Price = price;
        Category = category;
        Brand = brand;
        Country = country;
    }
}

class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>();

        products.Add(new Product(1, "Laptop", 80000, "Electronics", "HP", "USA"));
        products.Add(new Product(2, "Mobile", 50000, "Electronics", "Samsung", "Korea"));

        double totalWorth = 0;

        foreach (var p in products)
        {
            Console.WriteLine(p.Name + " - " + p.Price);
            totalWorth += p.Price;
        }

        Console.WriteLine("Total Store Worth: " + totalWorth);
    }
}
