using System;

class Character
{
    public string Name;
    public int Health;
    public int Attack;

 
 public Character(string name, int health, int attack)
    {
        Name = name;
        Health = health;
        Attack = attack;
    }

    
    public Character(Character c)
    {
        Name = c.Name;
        Health = c.Health;
        Attack = c.Attack;
    }

    public void AttackOpponent(Character opponent)
    {
        opponent.Health -= Attack;
        Console.WriteLine(Name + " attacks " + opponent.Name +
            " → " + opponent.Name + " Health: " + opponent.Health);
    }
}

class Program
{
    static void Main()
    {
        Character warrior = new Character("Warrior", 100, 20);
        Character ninja = new Character("Ninja", 90, 15);

        Console.WriteLine("--- BATTLE STARTED ---");

        warrior.AttackOpponent(ninja);
        ninja.AttackOpponent(warrior);

        Character cloneWarrior = new Character(warrior);
        cloneWarrior.Name = "Clone Warrior";

        Console.WriteLine("Clone Warrior joins battle");

        while (ninja.Health > 0 && warrior.Health > 0)
        {
            cloneWarrior.AttackOpponent(ninja);
            if (ninja.Health <= 0)
            {
                Console.WriteLine(ninja.Name + " has been defeated!");
                break;
            }
        }

        Console.WriteLine("Winner: " + warrior.Name);
    }
}