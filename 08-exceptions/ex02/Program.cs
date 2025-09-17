using System;

class InvalidTransactionException : Exception
{
    public InvalidTransactionException(string message) : base(message) {}
}

class Program
{
    static void Main()
    {
        try
        {
            Withdraw(100m, 150m);
        }
        catch (InvalidTransactionException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    static void Withdraw(decimal balance, decimal amount)
    {
        if (amount <= 0 || amount > balance)
            throw new InvalidTransactionException("Invalid withdraw amount.");
        Console.WriteLine("OK");
    }
}
