using System;
using System.ComponentModel.Design;
using System.Net.Security;

public class Calculator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ingresar primer numero");
        double Numero1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingresar Segundo numero");
        double Numero2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Elegir una de las opciones");
        Console.WriteLine("1.Suma");
        Console.WriteLine("2.Resta");
        Console.WriteLine("3.Multiplicacion");
        Console.WriteLine("4.Division");

        int Opciones = Convert.ToInt32(Console.ReadLine());

        double resultado = Convert.ToDouble(Console.ReadLine());


        switch (Opciones)
        {
            case 1:
                resultado = Numero1 + Numero2;
                Console.WriteLine("El resulatdo de la suma es " + resultado);
                break;

            case 2:
                resultado = Numero1 - Numero2;
                Console.WriteLine("El resulatdo de la resta es " + resultado);
                break;

            case 3:
                resultado = Numero1 * Numero2;
                Console.WriteLine("El resulatdo de la multiplicacion es " + resultado);
                break;

            case 4:

                { if (Numero2 == 0)

          Console.WriteLine("El numero no puede ser dividido entre 0");
                
                else
                    
                     
                        resultado = Numero1 / Numero2;
                    Console.WriteLine("El resulatdo de la division es " + resultado);
                    break;
                }
            default:
                Console.WriteLine("La opcion seleccionada no es correcta");
                break;

        }


    } 
}
