using System;
using System.Collections.Generic;

class MUser
{
    public string Username;
    public string Password;
    public string Role;

    public MUser(string username, string password, string role)
    {
        Username = username;
        Password = password;
        Role = role;
    }
}

class Program
{
    static void Main()
    {
        List<MUser> users = new List<MUser>();
        users.Add(new MUser("admin", "1234", "Admin"));
        Console.Write("Enter Username: ");
        string u = Console.ReadLine();

        Console.Write("Enter Password: ");
        string p = Console.ReadLine();

        bool found = false;

        foreach (var user in users)
        {
            if (user.Username == u && user.Password == p)
            {
                Console.WriteLine("Login Successful. Role: " + user.Role);
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Invalid Credentials");
        }
    }
}