using System;
class Program
{
    static void Main(string[] args)
    {
        // Obtener la instancia única del registro
        RegistroDeBiblioteca registro = RegistroDeBiblioteca.ObtenerInstancia();
        // Crear los materiales
        Libro libro1 = new Libro("Cien años de soledad", "L001");
        Libro libro2 = new Libro("El Principito", "L002");
        Revista revista1 = new Revista("National Geographic", "R001");
        DVD dvd1 = new DVD("Inception", "D001");
        // Agregar materiales al registro
        registro.AgregarMaterial(libro1);
        registro.AgregarMaterial(libro2);
        registro.AgregarMaterial(revista1);
        registro.AgregarMaterial(dvd1);
        // Crear el inspector (Visitor)
        InspectorMaterial inspector = new InspectorMaterial();
        Console.WriteLine("=== INSPECCIÓN DE MATERIALES ===");
        // Recorrer los materiales haciendo que cada uno acepte al visitante
        foreach (IMaterial material in registro.ObtenerMateriales())
        {
            material.Aceptar(inspector);
        }
        Console.WriteLine();
        // Verificación del patrón Singleton
        RegistroDeBiblioteca registro1 = RegistroDeBiblioteca.ObtenerInstancia();
        RegistroDeBiblioteca registro2 = RegistroDeBiblioteca.ObtenerInstancia();
        Console.WriteLine($"¿Es el mismo registro?: {ReferenceEquals(registro1, registro2)}");
    }
}