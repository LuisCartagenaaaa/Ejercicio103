public interface IMaterial
{
    string Titulo { get; }
    string Codigo { get; }
    void Aceptar(IVisitanteMaterial visitante);
}