using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.IO;

record Student(string Name, double GPA);

class Program
{
    static List<Student> _students = new();

    static void Main()
    {
        Console.WriteLine("Grade Manager");
        while (true)
        {
            Console.Write("cmd (add/list/top/save/load/quit): ");
            var cmd = Console.ReadLine()?.Trim().ToLowerInvariant();
            if (cmd == "add")
            {
                Console.Write("name gpa: ");
                var parts = Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (parts?.Length == 2 && double.TryParse(parts[1], out var gpa))
                    _students.Add(new Student(parts[0], gpa));
            }
            else if (cmd == "list")
            {
                foreach (var s in _students) Console.WriteLine($"{s.Name} {s.GPA:F2}");
            }
            else if (cmd == "top")
            {
                foreach (var s in _students.OrderByDescending(s => s.GPA).Take(5))
                    Console.WriteLine($"{s.Name} {s.GPA:F2}");
            }
            else if (cmd == "save")
            {
                File.WriteAllText("students.json", JsonSerializer.Serialize(_students, new JsonSerializerOptions { WriteIndented = true }));
                Console.WriteLine("Saved.");
            }
            else if (cmd == "load")
            {
                if (File.Exists("students.json"))
                    _students = JsonSerializer.Deserialize<List<Student>>(File.ReadAllText("students.json")) ?? new();
                Console.WriteLine("Loaded.");
            }
            else if (cmd == "quit") break;
        }
    }
}
