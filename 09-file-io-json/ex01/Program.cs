using System;
using System.IO;

class Program
{
    static void Main()
    {
        File.WriteAllText("notes.txt", "Hello from C#\nLine 2");
        string txt = File.ReadAllText("notes.txt");
        Console.WriteLine(txt);
    }
}
