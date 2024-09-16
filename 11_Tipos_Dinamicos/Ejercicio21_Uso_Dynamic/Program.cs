using System;
using System.Dynamic;

public class CustomObject
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public void PrintInfo()
    {
        Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");
    }
}

class Program
{
    static void Main()
    {
        dynamic dynamicObject = new ExpandoObject();

        dynamicObject.IntegerProperty = 13;
        dynamicObject.StringProperty = "La vida es una";
        dynamicObject.CustomObjectProperty = new CustomObject { Nombre = "Ramon Tolentino", Edad = 40 };

        Console.WriteLine(dynamicObject.IntegerProperty);
        Console.WriteLine(dynamicObject.StringProperty);
        dynamicObject.CustomObjectProperty.PrintInfo();
    }
}