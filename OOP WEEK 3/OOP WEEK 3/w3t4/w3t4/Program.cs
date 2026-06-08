using System;
using System.Collections.Generic;

class Astronaut
{
    public string Name;
    public int Oxygen = 100;
    public int Stamina = 60;
    public bool IsConscious = true;

    Random rand = new Random();

    public Astronaut(string name)
    {
        Name = name;
    }

    public void RandomEvent()
    {
        int e = rand.Next(1, 6);

        if (!IsConscious) return;

        switch (e)
        {
            case 1:
                Oxygen = Math.Min(100, Oxygen + 15);
                Console.WriteLine(Name + " refilled oxygen.");
                break;
            case 2:
                Oxygen -= 25;
                Console.WriteLine(Name + " meteor hit.");
                break;
            case 3:
                Stamina += 10;
                Console.WriteLine(Name + " took break.");
                break;
            case 4:
                Stamina -= 15;
                Console.WriteLine(Name + " equipment failure.");
                break;
            case 5:
                Console.WriteLine(Name + " smooth cycle.");
                break;
        }

        if (Oxygen <= 0)
        {
            IsConscious = false;
            Oxygen = 0;
        }
    }
}

class Program
{
    static void Main()
    {
        List<Astronaut> crew = new List<Astronaut>()
        {
            new Astronaut("Ali"),
            new Astronaut("Sara"),
            new Astronaut("Ahmed"),
            new Astronaut("Zara")
        };

        Console.WriteLine("--- SPACE MISSION STARTED ---");

        for (int cycle = 1; cycle <= 10; cycle++)
        {
            Console.WriteLine("Cycle " + cycle);
            foreach (var a in crew)
            {
                a.RandomEvent();
            }
        }

        Console.WriteLine("--- FINAL RESULTS ---");

        foreach (var a in crew)
        {
            Console.WriteLine(a.Name + " -> Oxygen: " + a.Oxygen +
                " Stamina: " + a.Stamina +
                (a.IsConscious ? " Conscious" : " Unconscious"));
        }
    }
}