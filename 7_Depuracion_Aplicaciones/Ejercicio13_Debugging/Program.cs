using System;

public class debugging
{
    public static void Main()
    {
        Random random = new Random();
        int cantidadDeNumeros = 10; 

        for (int i = 0; i < cantidadDeNumeros; i++)
        {
            int numeroAleatorio = random.Next(1, 101); 
            Console.WriteLine(numeroAleatorio); 
        }
        
    }
}