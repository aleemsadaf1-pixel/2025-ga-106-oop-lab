using System;
using System.Collections.Generic;
using System.Threading.Tasks;

class ClockType
{
    public int Hours;
    public int Minutes;
    public int Seconds;

    public ClockType(int h, int m, int s)
    {
        Hours = h;
        Minutes = m;
        Seconds = s;
    }

    public int ElapsedSeconds()
    {
        return Hours * 3600 + Minutes * 60 + Seconds;
    }

    public int RemainingSeconds()
    {
        return 86400 - ElapsedSeconds();
    }

    public int Difference(ClockType other)
    {
        return Math.Abs(this.ElapsedSeconds() - other.ElapsedSeconds());
    }

    public void Display()
    {
        Console.WriteLine(Hours.ToString("00") + ":" +
                          Minutes.ToString("00") + ":" +
                          Seconds.ToString("00"));
    }
}

class Program
{
    static void Main()
    {
        ClockType c1 = new ClockType(9, 15, 20);
        ClockType c2 = new ClockType(14, 40, 10);
        ClockType c3 = new ClockType(22, 10, 5);

        Console.WriteLine("--- CLOCK ANALYZER STARTED ---");

        c1.Display();
        Console.WriteLine("Elapsed Seconds: " + c1.ElapsedSeconds());
        Console.WriteLine("Remaining Seconds: " + c1.RemainingSeconds());

        Console.WriteLine("Difference with Clock 1: " + c2.Difference(c1));

        c3.Display();
        Console.WriteLine("Remaining Seconds: " + c3.RemainingSeconds());

        Console.WriteLine("--- ANALYSIS COMPLETE ---");
    }
}
