using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa;

public partial class AsocCuentasGrupos
{
    public int Id { get; set; }

    public int? RowVersion { get; set; }

    public int IdGrupoCuenta { get; set; }

    public int IdCuentaCheque { get; set; }
}
