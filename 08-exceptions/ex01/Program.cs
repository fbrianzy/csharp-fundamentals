using System;
class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter integer: ");
            var s = Console.ReadLine();
            if (!int.TryParse(s, out int n)) throw new FormatException("Input must be integer.");
            Console.WriteLine(100 / n);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Done.");
        }
    }
}
