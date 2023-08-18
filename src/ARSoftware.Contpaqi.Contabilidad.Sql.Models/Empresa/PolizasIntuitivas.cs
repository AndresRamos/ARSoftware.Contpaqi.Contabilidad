using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa;

public partial class PolizasIntuitivas
{
    public int Id { get; set; }

    public int? RowVersion { get; set; }

    public int TipoPol { get; set; }

    public int TipoXml { get; set; }

    public string RFC { get; set; } = null!;

    public int IdCuenta { get; set; }

    public int TipoMovto { get; set; }

    public int ImporteUsado { get; set; }

    public int IdDiario { get; set; }

    public int IdSegNeg { get; set; }

    public int? Frecuencia { get; set; }

    public int? CantidadUso { get; set; }

    public DateTime? FechaUltimoUso { get; set; }
}
