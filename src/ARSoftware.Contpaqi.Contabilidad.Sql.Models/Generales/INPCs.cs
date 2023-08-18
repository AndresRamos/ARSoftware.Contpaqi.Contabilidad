using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Generales;

public partial class INPCs
{
    public int Id { get; set; }

    public int? RowVersion { get; set; }

    public string Codigo { get; set; } = null!;

    public double? Indices1 { get; set; }

    public double? Indices2 { get; set; }

    public double? Indices3 { get; set; }

    public double? Indices4 { get; set; }

    public double? Indices5 { get; set; }

    public double? Indices6 { get; set; }

    public double? Indices7 { get; set; }

    public double? Indices8 { get; set; }

    public double? Indices9 { get; set; }

    public double? Indices10 { get; set; }

    public double? Indices11 { get; set; }

    public double? Indices12 { get; set; }

    public string? TimeStamp { get; set; }
}
