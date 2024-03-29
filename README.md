# AR SOFTWARE CONTPAQI CONTABILIDAD

En este repositorio contiene proyectos que te permiten consultar las bases de datos del sistema de CONTPAQi Contabilidad con Entity Framework.

# Proyectos

## ARSoftware.Contpaqi.Contabilidad.Sql

Este proyecto contiene los DbContext para consultar las bases de datos de CONTPAQi Contabilidad. Podras consultar las bases de datos de Generales y de Empresas.

## Instalaci�n

Puedes instalar el proyecto utilizando [NuGet](https://www.nuget.org/packages/ARSoftware.Contpaqi.Contabilidad.Sql):

```
dotnet add package ARSoftware.Contpaqi.Contabilidad.Sql
```

## ARSoftware.Contpaqi.Contabilidad.Sql.Models

Este proyecto contiene las clases mapeadas por Entity Framework que representan las tablas de las bases de datos de CONTPAQi Contabilidad.

## Instalaci�n

Puedes instalar el proyecto utilizando [NuGet](https://www.nuget.org/packages/ARSoftware.Contpaqi.Contabilidad.Sql.Models):

```
dotnet add package ARSoftware.Contpaqi.Contabilidad.Sql.Models
```

# Uso

## Dependency Injection

Si utilizas Dependency Injection puedes agregar los DbContext con el contenedor de dependencias de tu proyecto. Para ello, puedes utilizar el siguiente c�digo:

```csharp
public static IServiceCollection AddContpaqiContabilidadDbContexts(this IServiceCollection services, IConfiguration configuration)
{
    // Agrega implementaci�n de IEmpresaContabilidad
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

# Consultoria
Si lo que buscas es contratar a un desarrollador para crear tu aplicaci�n o interfaz para trabajar con los sistema de CONTPAQi, puedes contactarme directamente desde mi [p�gina web](https://www.arsoft.net/).

Me especializo en el desarrollo de aplicaciones e interfaces para los sistemas de CONTPAQi y me gustar�a agendar una reuni�n contigo para platicar m�s sobre tus necesidades y requerimientos.

# Como me puedes ayudar?

## Dame Una Estrella
Si estas utilizando alguno de los proyectos dentro de este repositorio y es de beneficio para ti o tu organizacion dame una estrella. Te lo agradeceria!