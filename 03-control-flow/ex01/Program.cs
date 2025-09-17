using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter a,b,op (e.g., 5 3 +): ");
        var parts = Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        if (parts is null || parts.Length < 3) { Console.WriteLine("Invalid input"); return; }
        if (!double.TryParse(parts[0], out var a) || !double.TryParse(parts[1], out var b)) { Console.WriteLine("Invalid numbers"); return; }
        var op = parts[2];

        double result = op switch
        {
            "+" => a + b,
            "-" => a - b,
            "*" => a * b,
            "/" => b != 0 ? a / b : double.NaN,
            _ => double.NaN
        };
        Console.WriteLine($"Result: {result}");
    }
}
