using ARSoftware.Contpaqi.Contabilidad.Sql.Contexts;
using ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa;
using Microsoft.EntityFrameworkCore;

namespace Sql.ConsoleApp.Ejemplos.TiposPoliza;

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
