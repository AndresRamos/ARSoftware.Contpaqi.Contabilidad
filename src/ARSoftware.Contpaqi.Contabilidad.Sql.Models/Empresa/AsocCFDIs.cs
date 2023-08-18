using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa;

public partial class AsocCFDIs
{
    public int Id { get; set; }

    public int? RowVersion { get; set; }

    public string GuidRef { get; set; } = null!;

    public string UUID { get; set; } = null!;

    public string Referencia { get; set; } = null!;

    public string AppType { get; set; } = null!;

    public bool? Reconstruir { get; set; }
}
