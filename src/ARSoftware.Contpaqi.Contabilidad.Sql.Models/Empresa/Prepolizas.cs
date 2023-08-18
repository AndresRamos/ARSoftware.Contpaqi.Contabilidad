using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa;

public partial class Prepolizas
{
    public int Id { get; set; }

    public int? RowVersion { get; set; }

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string? TipoPol { get; set; }

    public string? Folio { get; set; }

    public int? Clase { get; set; }

    public string? Concepto { get; set; }

    public string? Diario { get; set; }

    public string? CveFecha { get; set; }

    public int? DiaDelMes { get; set; }

    public string? Acceso { get; set; }

    public string? EsquemaDatos { get; set; }

    public string? TimeStamp { get; set; }

    public int? SistOrig { get; set; }

    public string? Variable1 { get; set; }

    public string? Variable2 { get; set; }

    public string? Variable3 { get; set; }

    public string? Variable4 { get; set; }

    public string? Variable5 { get; set; }

    public string? Variable6 { get; set; }

    public string? Variable7 { get; set; }

    public string? Variable8 { get; set; }

    public string? Variable9 { get; set; }

    public string? Variable10 { get; set; }
}
