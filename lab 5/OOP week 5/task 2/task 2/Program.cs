using System;

class MyPoint
{
    public int x;
    public int y;

    public MyPoint()
    {
        x = 0;
        y = 0;
    }

    public MyPoint(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public double DistanceFromZero()
    {
        return Math.Sqrt(x * x + y * y);
    }

    public double Distance(MyPoint p)
    {
        return Math.Sqrt(Math.Pow(x - p.x, 2) + Math.Pow(y - p.y, 2));
    }
}

class MyLine
{
    public MyPoint begin;
    public MyPoint end;

    public MyLine(MyPoint b, MyPoint e)
    {
        begin = b;
        end = e;
    }

    public double Length()
    {
        return begin.Distance(end);
    }

    public double Gradient()
    {
        return (double)(end.y - begin.y) / (end.x - begin.x);
    }
}

class Program
{
    static void Main()
    {
        MyPoint p1 = new MyPoint(0, 0);
        MyPoint p2 = new MyPoint(3, 4);

        MyLine line = new MyLine(p1, p2);

        Console.WriteLine("Length: " + line.Length());
        Console.WriteLine("Gradient: " + line.Gradient());
    }
}