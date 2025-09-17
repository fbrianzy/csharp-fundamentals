using System;

public readonly struct Point
{
    public int X { get; }
    public int Y { get; }
    public Point(int x, int y) { X = x; Y = y; }
    public double DistanceToOrigin() => Math.Sqrt(X * X + Y * Y);
}

class Program
{
    static string GradeMessage(double score) => score switch
    {
        >= 85 => "Excellent",
        >= 70 => "Good",
        >= 60 => "Fair",
        _ => "Needs improvement"
    };

    static void Main()
    {
        var p = new Point(3, 4);
        Console.WriteLine(p.DistanceToOrigin());
        Console.WriteLine(GradeMessage(81));
    }
}
