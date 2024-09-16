using System;
using System.Diagnostics;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Stopwatch stopwatch = Stopwatch.StartNew();

        Task task1 = DownloadFileAsync("Archivo1.txt", 1500);
        Task task2 = DownloadFileAsync("Archivo2.txt", 3000);
        Task task3 = DownloadFileAsync("Archivo3.txt", 4000);

        await Task.WhenAll(task1, task2, task3);

        stopwatch.Stop();

        Console.WriteLine($"Tiempo tomado: {stopwatch.ElapsedMilliseconds} ms");
    }

    static async Task DownloadFileAsync(string fileName, int delayInMilliseconds)
    {
        await Task.Delay(delayInMilliseconds);
        Console.WriteLine($"Desargado {fileName}");
    }
}