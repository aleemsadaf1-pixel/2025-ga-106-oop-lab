using System;
using System.Collections.Generic;

class MenuItem
{
    public string Name;
    public string Type;
    public double Price;

    public MenuItem(string name, string type, double price)
    {
        Name = name;
        Type = type;
        Price = price;
    }
}

class CoffeeShop
{
    public List<MenuItem> menu = new List<MenuItem>();
    public Queue<MenuItem> orders = new Queue<MenuItem>();

    public void AddMenuItem(MenuItem item)
    {
        menu.Add(item);
    }

    public void PlaceOrder(string name)
    {
        foreach (var item in menu)
        {
            if (item.Name == name)
            {
                orders.Enqueue(item);
                Console.WriteLine("Order Placed: " + name);
                return;
            }
        }
        Console.WriteLine("Item not found");
    }

    public void ServeOrder()
    {
        if (orders.Count > 0)
        {
            Console.WriteLine("Serving: " + orders.Dequeue().Name);
        }
        else
        {
            Console.WriteLine("No Orders");
        }
    }
}

class Program
{
    static void Main()
    {
        CoffeeShop shop = new CoffeeShop();

        shop.AddMenuItem(new MenuItem("Coffee", "Drink", 300));
        shop.AddMenuItem(new MenuItem("Burger", "Food", 500));

        shop.PlaceOrder("Coffee");
        shop.PlaceOrder("Burger");

        shop.ServeOrder();
        shop.ServeOrder();
    }
}
