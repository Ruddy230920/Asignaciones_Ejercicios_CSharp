using System;

class Program
{
    static void Main()
    {
        int? numero = null;

        int resultado = numero ?? 23;

        Console.WriteLine($"El valor es: {resultado}");
    }
}