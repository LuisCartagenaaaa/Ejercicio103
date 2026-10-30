public class Revista : IMaterial
{
    public string Titulo { get; }
    public string Codigo { get; }
    public Revista(string titulo, string codigo)
    {
        Titulo = titulo;
        Codigo = codigo;
    }
    public void Aceptar(IVisitanteMaterial visitante)
    {
        visitante.Visitar(this);
    }
}