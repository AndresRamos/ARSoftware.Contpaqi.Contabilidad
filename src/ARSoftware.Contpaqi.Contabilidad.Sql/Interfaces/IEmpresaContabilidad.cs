namespace ARSoftware.Contpaqi.Contabilidad.Sql.Interfaces;

/// <summary>
///     Implementa esta interface para hacer uso de Dependency Injection y poder registrar
///     ContpaqiContabilidadEmpresaDbContext
/// </summary>
public interface IEmpresaContabilidad
{
    /// <summary>
    ///     Nombre de la base de datos del SQL de la empresa de CONTPAQi Contabilidad.
    /// </summary>
    string BaseDatos { get; }
}
