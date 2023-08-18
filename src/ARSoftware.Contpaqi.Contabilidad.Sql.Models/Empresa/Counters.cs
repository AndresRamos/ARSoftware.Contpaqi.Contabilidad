using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa;

public partial class Counters
{
    public int Id { get; set; }

    public int? RowVersion { get; set; }

    public string Name { get; set; } = null!;

    public int Next { get; set; }
}
