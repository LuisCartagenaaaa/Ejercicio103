public class DVD : IMaterial
{
    public string Titulo { get; }
    public string Codigo { get; }
    public DVD(string titulo, string codigo)
    {
        Titulo = titulo;
        Codigo = codigo;
    }
    public void Aceptar(IVisitanteMaterial visitante)
    {
        visitante.Visitar(this);
    }
}