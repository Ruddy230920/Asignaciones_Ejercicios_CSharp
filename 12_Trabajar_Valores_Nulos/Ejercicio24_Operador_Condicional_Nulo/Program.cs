using System;

public class Persona
{

    public string? Apellido { get; set; }
}

class Program
{
    static void Main()
    {
        Persona persona1 = new Persona();

        Persona persona2 = new Persona { Apellido = "Perez" };

        string? apellido1 = persona1.Apellido?.ToUpper();
        string? apellido2 = persona2.Apellido?.ToUpper();


        Console.WriteLine($"Apellido 1: {apellido1 ?? "No disponible"}");
        Console.WriteLine($"Apellido 2: {apellido2 ?? "No disponible"}");
    }
}