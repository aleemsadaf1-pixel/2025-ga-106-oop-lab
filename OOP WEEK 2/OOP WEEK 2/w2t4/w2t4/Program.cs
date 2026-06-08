using System;
using System.Collections.Generic;

class Student
{
    public string Name;
    public double Marks;

    public Student(string name, double marks)
    {
        Name = name;
        Marks = marks;
    }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();

        students.Add(new Student("Ali", 80));
        students.Add(new Student("Ahmed", 90));

        Console.WriteLine("All Students:");
        foreach (var s in students)
        {
            Console.WriteLine(s.Name + " - " + s.Marks);
        }

        double total = 0;
        foreach (var s in students)
        {
            total += s.Marks;
        }

        Console.WriteLine("Average: " + total / students.Count);
    }
}
