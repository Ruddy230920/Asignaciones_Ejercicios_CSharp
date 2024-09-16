using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce la edad de la persona (deja en blanco para nulo): ");
        string? input = Console.ReadLine();

        int? edad = string.IsNullOrWhiteSpace(input) ? (int?)null : int.Parse(input);

        if (edad.HasValue)
        {
            Console.WriteLine($"La edad introducida es: {edad.Value}");
        }
        else
        {
            Console.WriteLine("La edad no fue proporcionada.");
        }
    }
}