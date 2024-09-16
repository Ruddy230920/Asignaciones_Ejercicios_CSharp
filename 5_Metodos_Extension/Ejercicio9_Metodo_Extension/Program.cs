using System;
using System.Security.Cryptography.X509Certificates;

public static class stringExtensions
{
    public static int ContarVocales(this string texto)
    {
        char[] vocales = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        int contador = 0;

        foreach (char letra in texto)
        {
            if (Array.Exists(vocales, v => v == letra))
            {
                contador++;
            }
        }
        return contador;
    }
}
public class Extensions
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un texto");
        string TextoIngresado = Convert.ToString(Console.ReadLine());

        int numerovocales = TextoIngresado.ContarVocales();
        Console.WriteLine("La cantidad de vocales que tiene el texto ingresado es " + numerovocales);
    }
}