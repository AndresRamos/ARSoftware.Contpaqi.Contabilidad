using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa;

public partial class PorcentajesPresupuesto
{
    public int Id { get; set; }

    public int? RowVersion { get; set; }

    public string Codigo { get; set; } = null!;

    public double? Porcentaje1 { get; set; }

    public double? Porcentaje2 { get; set; }

    public double? Porcentaje3 { get; set; }

    public double? Porcentaje4 { get; set; }

    public double? Porcentaje5 { get; set; }

    public double? Porcentaje6 { get; set; }

    public double? Porcentaje7 { get; set; }

    public double? Porcentaje8 { get; set; }

    public double? Porcentaje9 { get; set; }

    public double? Porcentaje10 { get; set; }

    public double? Porcentaje11 { get; set; }

    public double? Porcentaje12 { get; set; }

    public double? Porcentaje13 { get; set; }

    public string? TimeStamp { get; set; }
}
