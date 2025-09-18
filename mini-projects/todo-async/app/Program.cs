using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;
using System.Threading.Tasks;

record Todo(string Title, DateTime? Due, bool Done);

class Program
{
    static List<Todo> _todos = new();

    static async Task Main(string[] args)
    {
        Console.WriteLine("Todo Async");
        while (true)
        {
            Console.Write("cmd (add/list/due/sync/save/load/quit): ");
            var cmd = Console.ReadLine()?.Trim().ToLowerInvariant();
            if (cmd == "add")
            {
                Console.Write("title (optional: yyyy-MM-dd due): ");
                var line = Console.ReadLine() ?? "";
                var parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length == 2 && DateTime.TryParse(parts[1], out var due))
                    _todos.Add(new Todo(parts[0], due, false));
                else
                    _todos.Add(new Todo(line, null, false));
            }
            else if (cmd == "list")
            {
                foreach (var t in _todos) Console.WriteLine($"{t.Title} | due={t.Due?.ToShortDateString() ?? "-"} | done={t.Done}");
            }
            else if (cmd == "due")
            {
                Console.Write("YYYY-MM-DD: ");
                if (DateTime.TryParse(Console.ReadLine(), out var d))
                    foreach (var t in _todos.FindAll(t => t.Due.HasValue && t.Due.Value.Date == d.Date))
                        Console.WriteLine($"{t.Title} (due today)");
            }
            else if (cmd == "sync")
            {
                await Task.Delay(500); // simulate I/O
                Console.WriteLine("Synced!");
            }
            else if (cmd == "save")
            {
                File.WriteAllText("todos.json", JsonSerializer.Serialize(_todos, new JsonSerializerOptions { WriteIndented = true }));
                Console.WriteLine("Saved.");
            }
            else if (cmd == "load")
            {
                if (File.Exists("todos.json"))
                    _todos = JsonSerializer.Deserialize<List<Todo>>(File.ReadAllText("todos.json")) ?? new();
                Console.WriteLine("Loaded.");
            }
            else if (cmd == "quit") break;
        }
    }
}
