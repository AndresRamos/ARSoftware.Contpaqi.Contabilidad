using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa;

public partial class Digitos
{
    public int Id { get; set; }

    public int? RowVersion { get; set; }

    public string Codigo { get; set; } = null!;

    public string? Naturaleza { get; set; }

    public string Nombre { get; set; } = null!;

    public string? TipoCtas { get; set; }

    public string? TimeStamp { get; set; }
}
