using System;
class Program
{
    static void Main()
    {
        Console.WriteLine(Sum(2,3));
        Console.WriteLine(Sum(2.5,3.2));
        Greet("Bagus");
        Greet();
    }
    static int Sum(int a, int b) => a + b;
    static double Sum(double a, double b) => a + b;
    static void Greet(string who = "there") => Console.WriteLine($"Hi, {who}!");
}
