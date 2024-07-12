using System;
using System.Collections.Generic;

public class MaterialBibliografico
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public virtual void MostrarInfo() => Console.WriteLine($"{Titulo} por {Autor}");
}

public class Libro : MaterialBibliografico
{
    public int NumeroDePaginas { get; set; }
    public override void MostrarInfo() => Console.WriteLine($"{Titulo} por {Autor}, {NumeroDePaginas} páginas");
}

public class Revista : MaterialBibliografico
{
    public int NumeroDeEdicion { get; set; }
    public override void MostrarInfo() => Console.WriteLine($"{Titulo} por {Autor}, Edición {NumeroDeEdicion}");
}

public class Biblioteca
{
    private List<MaterialBibliografico> materiales = new List<MaterialBibliografico>();
    public void AgregarMaterial(MaterialBibliografico material) => materiales.Add(material);
    public void MostrarTodos() => materiales.ForEach(m => m.MostrarInfo());
}

class Program
{
    static void Main()
    {
        var biblioteca = new Biblioteca();
        biblioteca.AgregarMaterial(new Libro { Titulo = "La casa rodante", Autor = "Diego A. Castillo", NumeroDePaginas = 28 });
        biblioteca.AgregarMaterial(new Revista { Titulo = "LA QUEMACION", Autor = "Diego A. Castillo", NumeroDeEdicion = 92 });
        biblioteca.MostrarTodos();
    }
}