using System;
class Program
{
    static void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
            string s = "";
            if (i % 3 == 0) s += "Fizz";
            if (i % 5 == 0) s += "Buzz";
            Console.WriteLine(string.IsNullOrEmpty(s) ? i.ToString() : s);
        }
    }
}
