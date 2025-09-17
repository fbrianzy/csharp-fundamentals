using System;
using System.Collections.Generic;

class Student
{
    public string Name { get; set; }
    public double GPA { get; private set; }
    public List<string> Courses { get; } = new();

    public Student(string name, double gpa)
    {
        Name = name;
        UpdateGpa(gpa);
    }

    public void UpdateGpa(double newGpa)
    {
        if (newGpa >= 0 && newGpa <= 4.0) GPA = newGpa;
    }

    public override string ToString() => $"{Name} (GPA: {GPA:F2}) | Courses: {string.Join(", ", Courses)}";
}

class Program
{
    static void Main()
    {
        var s = new Student("Bagus", 3.8);
        s.Courses.AddRange(new[] { "Math", "CS101" });
        s.UpdateGpa(3.9);
        Console.WriteLine(s);
    }
}
