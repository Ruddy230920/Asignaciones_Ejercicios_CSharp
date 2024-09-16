using System;

class Caja<T>
{
    private T contenido;

    public void Añadir(T objeto)
    {
        contenido = objeto;
    }

    public T Obtener()
    {
        return contenido;
    }
}

class Program
{
    static void Main()
    {
        Caja<int> cajaDeEntero = new Caja<int>();
        cajaDeEntero.Añadir(56);
        int valorEntero = cajaDeEntero.Obtener();
        Console.WriteLine($"Valor en la caja de enteros: {valorEntero}");

        Caja<string> cajaDeCadena = new Caja<string>();
        cajaDeCadena.Añadir("Como estas?");
        string valorCadena = cajaDeCadena.Obtener();
        Console.WriteLine($"Valor en la caja de cadenas: {valorCadena}");

        Caja<Persona> cajaDePersona = new Caja<Persona>();
        Persona persona = new Persona { Nombre = "Carlos", Edad = 23 };
        cajaDePersona.Añadir(persona);
        Persona valorPersona = cajaDePersona.Obtener();
        Console.WriteLine($"Nombre de la persona en la caja: {valorPersona.Nombre}, Edad: {valorPersona.Edad}");
    }
}

class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
}