using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa;

public partial class EFOS
{
    public int Id { get; set; }

    public int? RowVersion { get; set; }

    public string RFC { get; set; } = null!;

    public string? Nombre { get; set; }

    public string? Situacion { get; set; }
}
