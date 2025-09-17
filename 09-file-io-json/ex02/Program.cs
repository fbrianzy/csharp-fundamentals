using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

record Student(string Name, double GPA);

class Program
{
    static void Main()
    {
        var list = new List<Student> { new("Bagus", 3.9), new("Naufal", 3.6) };
        var json = JsonSerializer.Serialize(list, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText("students.json", json);

        var read = JsonSerializer.Deserialize<List<Student>>(File.ReadAllText("students.json"));
        Console.WriteLine($"Loaded {read?.Count} students");
    }
}
