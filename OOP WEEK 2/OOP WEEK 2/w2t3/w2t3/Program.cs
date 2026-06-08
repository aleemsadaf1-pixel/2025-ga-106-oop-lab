using System;
using System.Collections.Generic;
using System.Threading.Tasks;

class ATM
{
    private double balance;
    private List<string> history = new List<string>();

    public ATM(double initialBalance)
    {
        balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        balance += amount;
        history.Add("Deposited: " + amount);
    }

    public void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            history.Add("Withdrawn: " + amount);
        }
        else
        {
            Console.WriteLine("Insufficient Balance");
        }
    }

    public void CheckBalance()
    {
        Console.WriteLine("Current Balance: " + balance);
    }

    public void ShowHistory()
    {
        foreach (var item in history)
        {
            Console.WriteLine(item);
        }
    }
}

class Program
{
    static void Main()
    {
        ATM a = new ATM(1000);
        a.Deposit(500);
        a.Withdraw(300);
        a.CheckBalance();
        a.ShowHistory();
    }
}