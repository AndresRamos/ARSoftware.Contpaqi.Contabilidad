using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa;

public partial class CuentasChequesAlias
{
    public int Id { get; set; }

    public int? RowVersion { get; set; }

    public string NumeroCuenta { get; set; } = null!;

    public int TipoCuenta { get; set; }

    public string? Descripcion { get; set; }

    public int IdCuentaCheques { get; set; }
}
