using System;
using System.Collections.Generic;

class Set
{
    public int Reps;
    public double Weight;

    public Set(int r, double w)
    {
        Reps = r;
        Weight = w;
    }
}

class Exercise
{
    public string Name;
    public List<Set> sets = new List<Set>();

    public Exercise(string name)
    {
        Name = name;
    }

    public void AddSet(Set s)
    {
        sets.Add(s);
    }
}

class WorkoutRoutine
{
    public List<Exercise> exercises = new List<Exercise>();

    public void AddExercise(Exercise e)
    {
        exercises.Add(e);
    }

    public void Show()
    {
        foreach (var e in exercises)
        {
            Console.WriteLine(e.Name);
            foreach (var s in e.sets)
            {
                Console.WriteLine("Reps: " + s.Reps + " Weight: " + s.Weight);
            }
        }
    }
}

class Program
{
    static void Main()
    {
        WorkoutRoutine w = new WorkoutRoutine();

        Exercise e = new Exercise("Pushups");
        e.AddSet(new Set(10, 0));
        e.AddSet(new Set(15, 0));

        w.AddExercise(e);

        w.Show();
    }
}
