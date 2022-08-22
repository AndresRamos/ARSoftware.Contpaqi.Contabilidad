using ARSoftware.Contpaqi.Contabilidad.Sql.Models.Generales;

namespace ConsoleAppDemo;

public class EmpresaSeleccionada
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string AliasBDD { get; set; }

    public void Actualizar(ListaEmpresas empresaContpaqi)
    {
        Id = empresaContpaqi.Id;
        Nombre = empresaContpaqi.Nombre;
        AliasBDD = empresaContpaqi.AliasBDD;
    }
}
