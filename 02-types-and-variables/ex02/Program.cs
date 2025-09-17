using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter a birthdate (yyyy-MM-dd): ");
        var s = Console.ReadLine();
        if (DateTime.TryParse(s, out var date))
        {
            var age = (int)((DateTime.Today - date).TotalDays / 365.25);
            Console.WriteLine($"Approx age: {age} years");
        }
        else
        {
            Console.WriteLine("Invalid date.");
        }
    }
}
