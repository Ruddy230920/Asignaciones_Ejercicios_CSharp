using System;


class Program
{
    static async Task Main()
    {
        Console.WriteLine("Comenzando operaciones");

        try
        {
            Task<int> tarea1 = OperacionLargaAsync();
            Task<int> tarea2 = OperacionLargaAsync();

            int[] resultados = await Task.WhenAll(tarea1, tarea2);

            Console.WriteLine($"Resultado de la primera operación: {resultados[0]}");
            Console.WriteLine($"Resultado de la segunda operación: {resultados[1]}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Se produjo una excepción: {ex.Message}");
        }
    }

    static async Task<int> OperacionLargaAsync()
    {
        try
        {
            await Task.Delay(2000);
            Random random = new Random();
            return random.Next(1, 101);
        }
        catch (Exception ex)
        {

            Console.WriteLine($"Se produjo una excepción en OperacionLargaAsync: {ex.Message}");
            throw;
        }
    }
}