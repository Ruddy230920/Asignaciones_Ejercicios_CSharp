using System;


public class Producto
{
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
    public string Categoria { get; set; }
}

public class Productos
{
    public static void Main()
    {
      
        List<Producto> productos = new List<Producto>
        {
            new Producto { Nombre = "Producto1", Precio = 10, Categoria = "Electrónica" },
            new Producto { Nombre = "Producto2", Precio = 15, Categoria = "Electrónica" },
            new Producto { Nombre = "Producto3", Precio = 7, Categoria = "Ropa" },
            new Producto { Nombre = "Producto4", Precio = 20, Categoria = "Ropa" },
            new Producto { Nombre = "Producto5", Precio = 25, Categoria = "Alimento" },
            new Producto { Nombre = "Producto6", Precio = 5, Categoria = "Electrónica" }
        };

        var precioPromedioPorCategoria = productos
            .GroupBy(p => p.Categoria) 
            .Select(g => new
            {
                Categoria = g.Key,
                PrecioPromedio = g.Average(p => p.Precio) 
            });

        foreach (var grupo in precioPromedioPorCategoria)
        {
            Console.WriteLine($"Categoría: {grupo.Categoria}, Precio Promedio: {grupo.PrecioPromedio:C}");
        }
    }
}
