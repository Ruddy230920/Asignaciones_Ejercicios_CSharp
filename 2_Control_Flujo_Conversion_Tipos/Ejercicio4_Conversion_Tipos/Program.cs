using System;

public class conversiones
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ingresar un numero entero");
        int numeroEntero= Convert.ToInt32(Console.ReadLine());

        
        double numeroDecimal = Convert.ToDouble(numeroEntero);
        Console.WriteLine("El numero entero convertido a decimal es " + numeroDecimal);

        int numeroEntero2= Convert.ToInt32(numeroDecimal);
        Console.WriteLine("El numero decimal convertido a un numero entero de nuevo "+ numeroEntero2);
    }
}