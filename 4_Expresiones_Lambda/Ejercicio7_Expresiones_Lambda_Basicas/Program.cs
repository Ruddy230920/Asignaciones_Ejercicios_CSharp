using System;

public class ListaDeNumeros
{
    public static void Main(string[] args)
    {
        List<int> numeros = new List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

        List<int> numerosPares= numeros.Where(x => x % 2==0).ToList();

        numerosPares.ForEach(n => Console.WriteLine(n));
    }
}