using ARSoftware.Contpaqi.Contabilidad.Sql.Contexts;
using ARSoftware.Contpaqi.Contabilidad.Sql.Models.Generales;
using Microsoft.EntityFrameworkCore;

namespace Sql.ConsoleApp.Ejemplos.Empresas;

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
