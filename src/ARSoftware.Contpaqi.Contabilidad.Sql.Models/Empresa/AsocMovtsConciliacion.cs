using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa;

public partial class AsocMovtsConciliacion
{
    public int Id { get; set; }

    public int? RowVersion { get; set; }

    public int IdEdoCuentaContable { get; set; }

    public int IdMovtoPoliza { get; set; }

    public int IdDocumento { get; set; }
}
