using System;

public abstract class Animal
{

    public abstract void Hablar();
}

public class Perro : Animal
{

    public override void Hablar()
    {
        Console.WriteLine("El perro dice: ¡Guau!");
    }
}


public class Gato : Animal
{
    public override void Hablar()
    {
        Console.WriteLine("El gato dice: ¡Miau!");
    }
}


public class Herencia
{
    public static void Main()
    {

        Animal miPerro = new Perro();
        Animal miGato = new Gato();


        miPerro.Hablar();
        miGato.Hablar();
    }
}
