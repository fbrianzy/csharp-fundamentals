using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Log file path: ");
        var path = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(path) || !File.Exists(path))
        {
            Console.WriteLine("File not found.");
            return;
        }

        var lines = File.ReadAllLines(path);
        var errorLines = lines.Where(l => l.Contains("ERROR", StringComparison.OrdinalIgnoreCase)).ToList();
        Console.WriteLine($"Total lines: {lines.Length} | Errors: {errorLines.Count}");

        var endpointRegex = new Regex(@"GET\s+(\S+)|POST\s+(\S+)", RegexOptions.IgnoreCase);
        var endpoints = new Dictionary<string,int>();
        foreach (var line in lines)
        {
            var m = endpointRegex.Match(line);
            if (m.Success)
            {
                var ep = m.Groups[1].Success ? m.Groups[1].Value : m.Groups[2].Value;
                endpoints[ep] = endpoints.GetValueOrDefault(ep, 0) + 1;
            }
        }
        foreach (var kv in endpoints.OrderByDescending(kv => kv.Value).Take(5))
            Console.WriteLine($"{kv.Key} -> {kv.Value} hits");
    }
}
