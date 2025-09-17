using System;
using System.Threading;

public class Clock
{
    public event Action<DateTime>? Tick;
    public void Start(int times = 3)
    {
        for (int i = 0; i < times; i++)
        {
            Tick?.Invoke(DateTime.Now);
            Thread.Sleep(500);
        }
    }
}

class Program
{
    static void Main()
    {
        var c = new Clock();
        c.Tick += now => Console.WriteLine($"Tick: {now:T}");
        c.Start(5);
    }
}
