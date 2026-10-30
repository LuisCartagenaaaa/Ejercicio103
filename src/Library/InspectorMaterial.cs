using System;
public class InspectorMaterial : IVisitanteMaterial
{
    public void Visitar(Libro libro)
    {
        Console.WriteLine("Libro: revisando estado de las páginas.");
    }
    public void Visitar(Revista revista)
    {
        Console.WriteLine("Revista: revisando estado de la tapa.");
    }
    public void Visitar(DVD dvd)
    {
        Console.WriteLine("DVD: verificando lectura del disco.");
    }
}