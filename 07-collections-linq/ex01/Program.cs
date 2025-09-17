using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var scores = new List<int> { 90, 67, 85, 92, 70, 75 };
        var top3 = scores.OrderByDescending(s => s).Take(3).ToList();
        double avg = scores.Average();
        var pass = scores.Where(s => s >= 70);
        Console.WriteLine($"Top3: {string.Join(", ", top3)}");
        Console.WriteLine($"Avg: {avg:F2}");
        Console.WriteLine($"Pass: {string.Join(", ", pass)}");
    }
}
