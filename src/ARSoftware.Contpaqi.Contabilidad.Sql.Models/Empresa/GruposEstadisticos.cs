using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa;

public partial class GruposEstadisticos
{
    public int Id { get; set; }

    public int? RowVersion { get; set; }

    public string Codigo { get; set; } = null!;

    public int PosSeg { get; set; }

    public int? LongSeg { get; set; }

    public string Patron { get; set; } = null!;

    public string CuentaDel { get; set; } = null!;

    public string CuentaAl { get; set; } = null!;

    public string? TimeStamp { get; set; }
}
