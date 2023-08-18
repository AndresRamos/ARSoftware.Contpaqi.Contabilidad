using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa;

public partial class AsignacionesDigitos
{
    public int Id { get; set; }

    public int? RowVersion { get; set; }

    public int IdCuenta { get; set; }

    public int? IdDigito1 { get; set; }

    public int? IdDigito2 { get; set; }

    public string? TimeStamp { get; set; }
}
