using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa;

public partial class SegmentosNegocio
{
    public int Id { get; set; }

    public int? RowVersion { get; set; }

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string? TimeStamp { get; set; }

    public string? SegContSegmento1 { get; set; }

    public string? SegContSegmento2 { get; set; }

    public string? SegContSegmento3 { get; set; }

    public string? SegContSegmento4 { get; set; }

    public string? SegContSegmento5 { get; set; }

    public string? SegContSegmento6 { get; set; }

    public string? SegContSegmento7 { get; set; }
}
