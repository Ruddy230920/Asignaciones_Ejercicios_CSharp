using System;

public class Flujo
{

    public static void Main(string[] args)

    {
        Console.WriteLine("Ingrese el numero");
        int Numero = Convert.ToInt32(Console.ReadLine());

        if (Numero % 2 == 0)
        {
            Console.WriteLine("El numero es par");

        }
        else
        {
            Console.WriteLine("El numero es impar");

        }
    }
}

