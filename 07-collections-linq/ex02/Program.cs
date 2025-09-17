using System;
using System.Linq;
using System.Collections.Generic;

record Student(string Name, double GPA);

class Program
{
    static void Main()
    {
        var students = new List<Student> {
            new("A", 3.7), new("B", 3.2), new("C", 2.8), new("D", 3.9), new("E", 3.0)
        };

        string Band(double gpa) => gpa >= 3.5 ? "High" : gpa >= 3.0 ? "Mid" : "Low";

        var grouped = students.GroupBy(s => Band(s.GPA))
                              .OrderByDescending(g => g.Key);
        foreach (var g in grouped)
        {
            Console.WriteLine($"{g.Key}: {string.Join(", ", g.Select(s => s.Name))}");
        }
    }
}
