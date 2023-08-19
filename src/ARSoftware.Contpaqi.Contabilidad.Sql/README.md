# AR SOFTWARE CONTPAQI CONTABILIDAD SQL

Este proyecto contiene los DbContext para consultar las bases de datos de CONTPAQi Contabilidad. Podras consultar las bases de datos de Generales y de Empresas.

## Instalación

Puedes instalar el proyecto utilizando [NuGet](https://www.nuget.org/packages/ARSoftware.Contpaqi.Contabilidad.Sql):

```
dotnet add package ARSoftware.Contpaqi.Contabilidad.Sql
```

# Uso

## Dependency Injection

Si utilizas Dependency Injection puedes agregar los DbContext con el contenedor de dependencias de tu proyecto. Para ello, puedes utilizar el siguiente código:

```csharp
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
```

## Consulta las tablas generales

Para consultar la base de datos de tablas generales de CONTPAQi Contabilidad utiliza el DbContext ContpaqiContabilidadGeneralesDbContext.

```csharp

```csharp
public sealed class BuscarEmpresasConDbContext
{
    private readonly ContpaqiContabilidadGeneralesDbContext _context;
    private readonly ILogger _logger;

    public BuscarEmpresasConDbContext(ContpaqiContabilidadGeneralesDbContext context, ILogger logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task<List<ListaEmpresas>> BuscarTodo()
    {
        List<ListaEmpresas> empresas = await _context.ListaEmpresas.OrderBy(empresa => empresa.Nombre).ToListAsync();

        _logger.LogInformation("{@Empresas}", empresas);

        return empresas;
    }
}
```

## Consulta las tablas de la empresa

Para consultar la base de datos de tablas de la empresa de CONTPAQi Contabilidad utiliza el DbContext ContpaqiContabilidadEmpresaDbContext.

```csharp
public sealed class BuscarTiposPolizaConDbContext
{
    private readonly ContpaqiContabilidadEmpresaDbContext _context;
    private readonly ILogger _logger;

    public BuscarTiposPolizaConDbContext(ContpaqiContabilidadEmpresaDbContext context, ILogger logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task<List<TiposPolizas>> BuscarTodo()
    {
        List<TiposPolizas> tiposPoliza = await _context.TiposPolizas.OrderBy(tipo => tipo.Nombre).ToListAsync();

        _logger.LogInformation("{@TiposPoliza}", tiposPoliza);

        return tiposPoliza;
    }
}
```