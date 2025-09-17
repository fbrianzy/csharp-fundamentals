using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        using var http = new HttpClient();
        string html = await http.GetStringAsync("https://example.com");
        Console.WriteLine(html[..Math.Min(html.Length, 120)] + "...");
    }
}
