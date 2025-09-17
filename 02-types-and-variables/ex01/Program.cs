using System;
class Program
{
    static void Main()
    {
        int age = 20;
        double gpa = 3.75;
        bool isActive = true;
        char initial = 'B';
        string name = "Bagus";
        DateTime now = DateTime.Now;
        int? lucky = null;

        Console.WriteLine($"{name} | age={age} | gpa={gpa:F2} | now={now} | isActive={isActive} | initial={initial} | lucky={lucky}");
    }
}
