using System.Collections.Generic;

public class RegistroDeBiblioteca
{
    private static RegistroDeBiblioteca _instancia;
    private readonly List<IMaterial> _materiales;
    private RegistroDeBiblioteca()
    {
        _materiales = new List<IMaterial>();
    }
    public static RegistroDeBiblioteca ObtenerInstancia()
    {
        if (_instancia == null)
        {
            _instancia = new RegistroDeBiblioteca();
        }
        return _instancia;
    }
    public void AgregarMaterial(IMaterial material)
    {
        _materiales.Add(material);
    }
    public List<IMaterial> ObtenerMateriales()
    {
        return _materiales;
    }
}