﻿using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa;

public partial class ActivosFijos
{
    public int Id { get; set; }

    public int? RowVersion { get; set; }

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public bool? DepContable { get; set; }

    public bool? DepFiscal { get; set; }

    public int? IdCuenta { get; set; }

    public int? EstadoDeprecC { get; set; }

    public DateTime? FecAdqui { get; set; }

    public double? ValorOrig { get; set; }

    public DateTime? FecIniUsoC { get; set; }

    public double? PorDeprecC { get; set; }

    public double? PorDeducC { get; set; }

    public double? DeprecAcumC { get; set; }

    public DateTime? FecDeprecC { get; set; }

    public int? IdCtaDeprecC { get; set; }

    public int? IdCtaGastosC { get; set; }

    public int? IdCtaNoDedC { get; set; }

    public bool? EsBajaC { get; set; }

    public DateTime? FecBajaC { get; set; }

    public int? CptoBajaC { get; set; }

    public int? IdPolizaC { get; set; }

    public int? IdSegNegC { get; set; }

    public int? EstadoDeprecF { get; set; }

    public DateTime? FecIniUsoF { get; set; }

    public double? PorDeprecF { get; set; }

    public double? PorDeducF { get; set; }

    public double? DeprecAcumF { get; set; }

    public DateTime? FecDeprecF { get; set; }

    public int? IdCtaDeprecF { get; set; }

    public int? IdCtaGastosF { get; set; }

    public int? IdCtaNoDedF { get; set; }

    public bool? DeducInmedF { get; set; }

    public double? PorDeducInmedF { get; set; }

    public bool? EsBajaF { get; set; }

    public DateTime? FecBajaF { get; set; }

    public int? CptoBajaF { get; set; }

    public int? IdPolizaF { get; set; }

    public int? IdSegNegF { get; set; }

    public string? TimeStamp { get; set; }

    public double? PorDeducInmediata { get; set; }
}
