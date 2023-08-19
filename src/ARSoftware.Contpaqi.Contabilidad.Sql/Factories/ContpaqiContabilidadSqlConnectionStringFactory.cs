using ARSoftware.Contpaqi.Contabilidad.Sql.Models.Constants;
using Microsoft.Data.SqlClient;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Factories;

/// <summary>
///     Clase que permite crear las cadenas de conexión a las bases de datos de CONTPAQi Contabilidad.
/// </summary>
public static class ContpaqiContabilidadSqlConnectionStringFactory
{
    /// <summary>
    ///     Crea la cadena de conexión a la base de datos Generales de Contpaqi Contabilidad.
    /// </summary>
    /// <param name="contpaqiConnectionString">ConnectionString de del servidor de SQL de CONTPAQi Contabilidad.</param>
    /// <returns>Cadena de conexión a la base de datos Generales de Contpaqi Contabilidad.</returns>
    public static string CreateContpaqiContabilidadGeneralesConnectionString(string contpaqiConnectionString)
    {
        var sqlConnectionStringBuilder = new SqlConnectionStringBuilder(contpaqiConnectionString)
        {
            InitialCatalog = ContpaqiContabilidadSqlConstants.ContpaqiContabilidadGeneralesDatabaseName
        };
        return sqlConnectionStringBuilder.ConnectionString;
    }

    /// <summary>
    ///     Crea la cadena de conexión a la base de datos de la Empresas de Contpaqi Contabilidad.
    /// </summary>
    /// <param name="contpaqiConnectionString">ConnectionString de del servidor de SQL de CONTPAQi Contabilidad.</param>
    /// <param name="empresaDatabaseName">
    ///     Nombre de la base de datos de la empresa de CONTPAQi Contabilidad a la que se desea
    ///     conectar.
    /// </param>
    /// <returns>Cadena de conexión a la base de datos de la Empresas de Contpaqi Contabilidad.</returns>
    public static string CreateContpaqiContabilidadEmpresaConnectionString(string contpaqiConnectionString, string empresaDatabaseName)
    {
        var sqlConnectionStringBuilder = new SqlConnectionStringBuilder(contpaqiConnectionString) { InitialCatalog = empresaDatabaseName };
        return sqlConnectionStringBuilder.ConnectionString;
    }
}
