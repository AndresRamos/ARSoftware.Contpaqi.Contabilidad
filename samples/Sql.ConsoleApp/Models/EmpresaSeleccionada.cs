using ARSoftware.Contpaqi.Contabilidad.Sql.Interfaces;
using ARSoftware.Contpaqi.Contabilidad.Sql.Models.Generales;

namespace Sql.ConsoleApp.Models;

public sealed class EmpresaSeleccionada : IEmpresaContabilidad
{
    public int Id { get; private set; }
    public string Nombre { get; private set; } = string.Empty;
    public string BaseDatos { get; private set; } = string.Empty;

    public void Actualizar(ListaEmpresas empresaContpaqi)
    {
        Id = empresaContpaqi.Id;
        Nombre = empresaContpaqi.Nombre;
        BaseDatos = empresaContpaqi.AliasBDD;
    }
}
