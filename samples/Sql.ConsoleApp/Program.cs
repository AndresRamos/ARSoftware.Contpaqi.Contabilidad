using ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa;
using ARSoftware.Contpaqi.Contabilidad.Sql.Models.Generales;
using Serilog;
using Serilog.Events;
using Sql.ConsoleApp;
using Sql.ConsoleApp.Ejemplos.Empresas;
using Sql.ConsoleApp.Ejemplos.TiposPoliza;
using Sql.ConsoleApp.Models;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((context, services) =>
    {
        services.AddContpaqiContabilidadDbContexts(context.Configuration);
        services.AddEjemplos();
    })
    .ConfigureLogging(builder => { builder.ClearProviders(); })
    .UseSerilog((_, loggerConfiguration) =>
    {
        loggerConfiguration.MinimumLevel.Information()
            .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
            .MinimumLevel.Override("Microsoft.Hosting.Lifetime", LogEventLevel.Information);
        loggerConfiguration.WriteTo.Console(LogEventLevel.Information);
    })
    .Build();

await host.StartAsync();

using IServiceScope scope = host.Services.CreateScope();

var logger = host.Services.GetRequiredService<ILogger<Program>>();

try
{
    // Busca y selecciona una empresa
    var buscarEmpresasConDbContext = scope.ServiceProvider.GetRequiredService<BuscarEmpresasConDbContext>();
    List<ListaEmpresas> empresas = await buscarEmpresasConDbContext.BuscarTodo();

    foreach (ListaEmpresas empresa in empresas) Console.WriteLine($"{empresas.IndexOf(empresa) + 1}. {empresa.Nombre}");

    string empresaIndexInput = Console.ReadLine();
    int empresaIndex = int.Parse(empresaIndexInput) - 1;

    // Actualiza la empresa seleccionada
    ListaEmpresas empresaContpaqi = empresas.ElementAt(empresaIndex);
    var empresaSeleccionada = scope.ServiceProvider.GetRequiredService<EmpresaSeleccionada>();
    empresaSeleccionada.Actualizar(empresaContpaqi);

    // Busca los tipos de póliza de la empresa seleccionada
    var buscarTiposPolizaConDbContext = scope.ServiceProvider.GetRequiredService<BuscarTiposPolizaConDbContext>();
    List<TiposPolizas> tiposPoliza = await buscarTiposPolizaConDbContext.BuscarTodo();
}
catch (Exception e)
{
    logger.LogCritical(e, "Ocurrio un error.");
}

await host.StopAsync();
