using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Generales;

public partial class PermisosUsuario
{
    public int Id { get; set; }

    public int? RowVersion { get; set; }

    public int IdUsuario { get; set; }

    public int IdProceso { get; set; }

    public int Permisos { get; set; }

    public int? Uso { get; set; }

    public string? TimeStamp { get; set; }
}
