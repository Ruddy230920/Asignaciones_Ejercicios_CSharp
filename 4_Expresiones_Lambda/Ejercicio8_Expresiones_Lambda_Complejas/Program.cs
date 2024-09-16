using System;

public class Estudiantes
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
   
}

public class ListaEstianates
{
    public static void Main(string[] args)
    {
        List<Estudiantes> estudiantes = new List<Estudiantes>
        {
            new Estudiantes { Nombre= "Ruddy", Edad= 14 } ,
            new Estudiantes { Nombre="Carlos", Edad= 19},
            new Estudiantes{ Nombre="Pedro", Edad =17} ,
            new Estudiantes { Nombre="Maria", Edad=18},
            new Estudiantes {Nombre= "Luisa", Edad=22} ,
        };

        List<Estudiantes> Mayores18 = estudiantes.Where(e => e.Edad >= 18).ToList();

        Mayores18.ForEach(e => Console.WriteLine($"Nombre= {e.Nombre}, Edad= {e.Edad} años"));





    }
}