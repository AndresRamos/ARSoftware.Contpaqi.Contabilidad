using ARSoftware.Contpaqi.Contabilidad.Sql.Models.Constants;
using Microsoft.Data.SqlClient;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Factories;

public static class ContpaqiContabilidadSqlConnectionStringFactory
{
    public static string CreateContpaqiContabilidadGeneralesConnectionString(string contpaqiConnectionString)
    {
        var sqlConnectionStringBuilder = new SqlConnectionStringBuilder(contpaqiConnectionString)
        {
            InitialCatalog = ContpaqiContabilidadSqlConstants.ContpaqiContabilidadGeneralesDatabaseName
        };
        return sqlConnectionStringBuilder.ConnectionString;
    }

    public static string CreateContpaqiContabilidadEmpresaConnectionString(string contpaqiConnectionString, string empresaDatabaseName)
    {
        var sqlConnectionStringBuilder = new SqlConnectionStringBuilder(contpaqiConnectionString) { InitialCatalog = empresaDatabaseName };
        return sqlConnectionStringBuilder.ConnectionString;
    }
}
