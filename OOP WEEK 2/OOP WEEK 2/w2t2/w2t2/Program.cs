using System;

class Calculator
{
    public double num1;
    public double num2;

    public Calculator(double n1, double n2)
    {
        num1 = n1;
        num2 = n2;
    }

    public double Add()
    {
        return num1 + num2;
    }

    public double Subtract()
    {
        return num1 - num2;
    }

    public double Multiply()
    {
        return num1 * num2;
    }

    public double Divide()
    {
        if (num2 != 0)
            return num1 / num2;
        else
            return 0;
    }
}

class Program
{
    static void Main()
    {
        Calculator c = new Calculator(10, 5);
        Console.WriteLine("Add: " + c.Add());
        Console.WriteLine("Subtract: " + c.Subtract());
        Console.WriteLine("Multiply: " + c.Multiply());
        Console.WriteLine("Divide: " + c.Divide());
    }
}