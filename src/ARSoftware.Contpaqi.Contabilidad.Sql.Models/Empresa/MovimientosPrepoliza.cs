using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa;

public partial class MovimientosPrepoliza
{
    public int Id { get; set; }

    public int? RowVersion { get; set; }

    public int IdPrepoliza { get; set; }

    public int NumMovto { get; set; }

    public string Cuenta { get; set; } = null!;

    public string? CtaFinal { get; set; }

    public bool? TipoMovto { get; set; }

    public string Importe { get; set; } = null!;

    public string? ImporteME { get; set; }

    public string? Referencia { get; set; }

    public string? Concepto { get; set; }

    public string? Diario { get; set; }

    public string? SegNeg { get; set; }

    public string? TimeStamp { get; set; }

    public string? CodigoPrepoliza { get; set; }

    public int? Base { get; set; }

    public double? ClaveBaseIVA { get; set; }

    public double? ClaveBaseISR { get; set; }
}
