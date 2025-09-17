using System;
class Program
{
    static void Main()
    {
        for (int i = 2; i <= 30; i++)
        {
            if (IsPrime(i)) Console.Write($"{i} ");
        }
        Console.WriteLine();
    }

    static bool IsPrime(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i * i <= n; i++)
            if (n % i == 0) return false;
        return true;
    }
}
