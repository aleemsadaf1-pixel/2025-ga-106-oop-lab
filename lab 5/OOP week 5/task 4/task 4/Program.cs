using System;
using System.Collections.Generic;

class StudentBL
{
    public string Name;

    public StudentBL(string name)
    {
        Name = name;
    }
}

class StudentDL
{
    public static List<StudentBL> students = new List<StudentBL>();

    public static void AddStudent(StudentBL s)
    {
        students.Add(s);
    }

    public static List<StudentBL> GetStudents()
    {
        return students;
    }
}

class StudentUI
{
    public static StudentBL InputStudent()
    {
        Console.Write("Enter Name: ");
        return new StudentBL(Console.ReadLine());
    }

    public static void ShowStudents()
    {
        foreach (var s in StudentDL.GetStudents())
        {
            Console.WriteLine(s.Name);
        }
    }
}

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1.Add Student");
            Console.WriteLine("2.View Students");
            Console.WriteLine("3.Exit");

            int op = int.Parse(Console.ReadLine());

            if (op == 1)
            {
                StudentBL s = StudentUI.InputStudent();
                StudentDL.AddStudent(s);
            }
            else if (op == 2)
            {
                StudentUI.ShowStudents();
            }
            else
            {
                break;
            }
        }
    }
}