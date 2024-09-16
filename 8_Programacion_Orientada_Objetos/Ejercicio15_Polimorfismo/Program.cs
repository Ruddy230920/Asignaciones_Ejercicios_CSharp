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


public class Animales
{
    public static void Main()
    {
        List<Animal> animales = new List<Animal>();
        animales.Add(new Perro());
        animales.Add(new Gato());

        foreach (var animal in animales)
        {
            animal.Hablar();
        }
    }
}