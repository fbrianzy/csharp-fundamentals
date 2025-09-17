using System;
using System.Collections.Generic;

interface IRepository<T>
{
    void Add(T item);
    IEnumerable<T> GetAll();
    IEnumerable<T> Find(Predicate<T> predicate);
}

class MemoryRepo<T> : IRepository<T>
{
    private readonly List<T> _data = new();
    public void Add(T item) => _data.Add(item);
    public IEnumerable<T> GetAll() => _data;
    public IEnumerable<T> Find(Predicate<T> predicate) => _data.FindAll(predicate);
}

class Program
{
    static void Main()
    {
        var repo = new MemoryRepo<string>();
        repo.Add("alpha"); repo.Add("beta"); repo.Add("gamma");
        foreach (var x in repo.Find(s => s.Contains('a'))) Console.WriteLine(x);
    }
}
