using ARSoftware.Contpaqi.Contabilidad.Sql.Contexts;
using ARSoftware.Contpaqi.Contabilidad.Sql.Factories;
using ARSoftware.Contpaqi.Contabilidad.Sql.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ARSoftware.Contpaqi.Contabilidad.Sql;

public static class DependencyInjection
{
    /// <summary>
    ///     Agrega el DbContext para ContpaqiContabilidadGenerales a la colección de servicios especificados.
    /// </summary>
    /// <param name="services">La colección de servicios especificados.</param>
    /// <param name="contpaqiConnectionString">La cadena de conexión al servidor de Contpaqi Contabilidad.</param>
    /// <param name="contextLifetime">El tiempo de vida de DbContext.</param>
    /// <param name="optionsLifetime">El tiempo de vida de las opciones de DbContext.</param>
    /// <returns>La colección de servicios especificados.</returns>
    public static IServiceCollection AddContpaqiContabilidadGeneralesDbContext(this IServiceCollection services,
        string contpaqiConnectionString, ServiceLifetime contextLifetime = ServiceLifetime.Scoped,
        ServiceLifetime optionsLifetime = ServiceLifetime.Scoped)
    {
        services.AddDbContext<ContpaqiContabilidadGeneralesDbContext>(builder =>
        {
            string connectionString =
                ContpaqiContabilidadSqlConnectionStringFactory
                    .CreateContpaqiContabilidadGeneralesConnectionString(contpaqiConnectionString);

            builder.UseSqlServer(connectionString);
        }, contextLifetime, optionsLifetime);

        return services;
    }

    /// <summary>
    ///     Agrega el DbContext para ContpaqiContabilidadEmpresas a la colección de servicios especificados.
    /// </summary>
    /// <param name="services">La colección de servicios especificados.</param>
    /// <param name="contpaqiConnectionString">La cadena de conexión al servidor de Contpaqi Contabilidad.</param>
    /// <param name="contextLifetime">El tiempo de vida de DbContext.</param>
    /// <param name="optionsLifetime">El tiempo de vida de las opciones de DbContext.</param>
    /// <returns>La colección de servicios especificados.</returns>
    public static IServiceCollection AddContpaqiContabilidadEmpresaDbContext(this IServiceCollection services,
        string contpaqiConnectionString, ServiceLifetime contextLifetime = ServiceLifetime.Scoped,
        ServiceLifetime optionsLifetime = ServiceLifetime.Scoped)
    {
        services.AddDbContext<ContpaqiContabilidadEmpresaDbContext>((provider, builder) =>
        {
            var empresa = provider.GetRequiredService<IEmpresaContabilidad>();

            string connectionString =
                ContpaqiContabilidadSqlConnectionStringFactory.CreateContpaqiContabilidadEmpresaConnectionString(contpaqiConnectionString,
                    empresa.BaseDatos);

            builder.UseSqlServer(connectionString);
        }, contextLifetime, optionsLifetime);

        return services;
    }
}
