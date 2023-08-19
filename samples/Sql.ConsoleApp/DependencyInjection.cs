using ARSoftware.Contpaqi.Contabilidad.Sql;
using ARSoftware.Contpaqi.Contabilidad.Sql.Interfaces;
using Sql.ConsoleApp.Ejemplos.Empresas;
using Sql.ConsoleApp.Ejemplos.TiposPoliza;
using Sql.ConsoleApp.Models;

namespace Sql.ConsoleApp;

public static class DependencyInjection
{
    public static IServiceCollection AddContpaqiContabilidadDbContexts(this IServiceCollection services, IConfiguration configuration)
    {
        // Agrega implementación de IEmpresaContabilidad
        services.AddSingleton<EmpresaSeleccionada>();
        services.AddSingleton<IEmpresaContabilidad>(provider => provider.GetRequiredService<EmpresaSeleccionada>());

        // Agrega Generales DbContext
        services.AddContpaqiContabilidadGeneralesDbContext(configuration.GetConnectionString("Contpaqi")!);

        // Agrega Empresa DbContext
        services.AddContpaqiContabilidadEmpresaDbContext(configuration.GetConnectionString("Contpaqi")!);

        return services;
    }

    public static IServiceCollection AddEjemplos(this IServiceCollection services)
    {
        // Empresas
        services.AddScoped<BuscarEmpresasConDbContext>();

        // Tipos de póliza
        services.AddScoped<BuscarTiposPolizaConDbContext>();

        return services;
    }
}
