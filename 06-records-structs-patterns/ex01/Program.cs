using System;

public record Book(string Title, string Author, int Year);

class Program
{
    static void Main()
    {
        var b1 = new Book("Clean Code", "Robert C. Martin", 2008);
        var b2 = b1 with { Year = 2009 };
        Console.WriteLine(b1);
        Console.WriteLine(b2);
        Console.WriteLine($"Equal by value? {b1 == b2}");
    }
}
