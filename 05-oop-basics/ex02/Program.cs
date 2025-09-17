using System;

class Account
{
    public string Owner { get; }
    public decimal Balance { get; private set; }

    public Account(string owner, decimal initial = 0m)
    {
        Owner = owner;
        Balance = initial;
    }

    public void Deposit(decimal amount) { if (amount > 0) Balance += amount; }
    public bool Withdraw(decimal amount)
    {
        if (amount <= 0 || amount > Balance) return False("Invalid withdraw.");
        Balance -= amount; return true;
    }
    bool False(string msg) { Console.WriteLine(msg); return false; }

    public override string ToString() => $"{Owner} | Balance: {Balance:C}";
}

class Program
{
    static void Main()
    {
        var acc = new Account("Bagus", 100m);
        acc.Deposit(50m);
        acc.Withdraw(30m);
        Console.WriteLine(acc);
    }
}
