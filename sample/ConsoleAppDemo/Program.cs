using ARSoftware.Contpaqi.Contabilidad.Sql.Contexts;
using ARSoftware.Contpaqi.Contabilidad.Sql.Factories;
using ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa;
using ARSoftware.Contpaqi.Contabilidad.Sql.Models.Generales;
using ConsoleAppDemo;
using Microsoft.EntityFrameworkCore;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((context, services) =>
    {
        // Registrar modelo para guardar la informacion de la base de datos seleccionada
        services.AddSingleton<EmpresaSeleccionada>();

        // Registrar DbContext de tablas generales
        services.AddDbContext<ContpaqiContabilidadGeneralesDbContext>((provider, builder) =>
        {
            builder.UseSqlServer(ContpaqiContabilidadSqlConnectionStringFactory.CreateContpaqiContabilidadGeneralesConnectionString(
                context.Configuration.GetConnectionString("Contpaqi")));
        });

        // Registrar DbContext de tablas de la empresa
        services.AddDbContext<ContpaqiContabilidadEmpresaDbContext>((provider, builder) =>
        {
            var empresaSeleccionada = provider.GetRequiredService<EmpresaSeleccionada>();
            builder.UseSqlServer(ContpaqiContabilidadSqlConnectionStringFactory.CreateContpaqiContabilidadEmpresaConnectionString(
                context.Configuration.GetConnectionString("Contpaqi"),
                empresaSeleccionada.AliasBDD));
        });
    })
    .Build();

await host.StartAsync();

using IServiceScope scope = host.Services.CreateScope();

// Buscar y seleccionar una empresa
var generalesDbContext = scope.ServiceProvider.GetRequiredService<ContpaqiContabilidadGeneralesDbContext>();

List<ListaEmpresas> empresas = await generalesDbContext.ListaEmpresas.ToListAsync();

foreach (ListaEmpresas empresa in empresas)
{
    Console.WriteLine($"{empresas.IndexOf(empresa) + 1} {empresa.Nombre}");
}

string? empresaIndexInput = Console.ReadLine();
int empresaIndex = int.Parse(empresaIndexInput) - 1;

// Guardar datos de empresa seleecionada
ListaEmpresas empresaContpaqi = empresas.ElementAt(empresaIndex);
var empresaSeleccionada = scope.ServiceProvider.GetRequiredService<EmpresaSeleccionada>();
empresaSeleccionada.Actualizar(empresaContpaqi);

// Listar los tipos de poliza de la empresa seleccionada
var empresaDbContext = scope.ServiceProvider.GetRequiredService<ContpaqiContabilidadEmpresaDbContext>();
List<TiposPolizas> tiposPoliza = await empresaDbContext.TiposPolizas.ToListAsync();
foreach (TiposPolizas tipoPoliza in tiposPoliza)
{
    Console.WriteLine($"{tipoPoliza.Codigo} {tipoPoliza.Nombre}");
}

await host.StopAsync();
