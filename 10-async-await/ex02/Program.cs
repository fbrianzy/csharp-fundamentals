using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        var urls = new[] { "https://example.com", "https://www.iana.org/domains/reserved" };
        using var http = new HttpClient();
        var tasks = new Task<string>[urls.Length];
        for (int i = 0; i < urls.Length; i++)
        {
            string u = urls[i];
            tasks[i] = http.GetStringAsync(u);
        }
        var results = await Task.WhenAll(tasks);
        for (int i = 0; i < results.Length; i++)
        {
            Console.WriteLine($"{urls[i]} -> {results[i].Length} bytes");
        }
    }
}
