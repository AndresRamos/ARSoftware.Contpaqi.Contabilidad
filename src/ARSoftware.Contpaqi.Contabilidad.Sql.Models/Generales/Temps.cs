using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Generales;

public partial class Temps
{
    public int Id { get; set; }

    public int? RowVersion { get; set; }

    public DateTime? TStamp { get; set; }

    public int Local { get; set; }

    public int? Definition { get; set; }

    public string? Replace { get; set; }

    public string? Async { get; set; }

    public int? Sys { get; set; }

    public int? Func { get; set; }

    public string? Stream { get; set; }

    public int? Repeat { get; set; }

    public string? Fix { get; set; }

    public string? Demo { get; set; }

    public string? Reference { get; set; }

    public int? Count1 { get; set; }

    public int? Count2 { get; set; }

    public int? Count3 { get; set; }

    public int? Count4 { get; set; }

    public string? End1 { get; set; }

    public string? End2 { get; set; }

    public string? End3 { get; set; }

    public string? End4 { get; set; }
}
