using System;

public class Student
{
    private double _gpa;
    public string Name { get; }
    public double GPA
    {
        get => _gpa;
        set
        {
            if (value >= 0 && value <= 4.0 && Math.Abs(_gpa - value) > 1e-9)
            {
                _gpa = value;
                OnGpaChanged?.Invoke(_gpa);
            }
        }
    }
    public event Action<double>? OnGpaChanged;
    public Student(string name, double gpa) { Name = name; _gpa = gpa; }
}

class Program
{
    static void Main()
    {
        var s = new Student("Bagus", 3.5);
        s.OnGpaChanged += gpa => Console.WriteLine($"New GPA: {gpa:F2}");
        s.GPA = 3.8;
    }
}
