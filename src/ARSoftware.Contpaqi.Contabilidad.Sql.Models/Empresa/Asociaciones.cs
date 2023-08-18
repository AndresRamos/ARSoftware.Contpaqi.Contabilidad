using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa;

public partial class Asociaciones
{
    public int Id { get; set; }

    public int? RowVersion { get; set; }

    public int IdCtaSup { get; set; }

    public int IdSubCtade { get; set; }

    public string CtaSup { get; set; } = null!;

    public string SubCtade { get; set; } = null!;

    public int TipoRel { get; set; }

    public string? TimeStamp { get; set; }
}
