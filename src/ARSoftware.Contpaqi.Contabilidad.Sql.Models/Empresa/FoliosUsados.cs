using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa;

public partial class FoliosUsados
{
    public int Id { get; set; }

    public int? RowVersion { get; set; }

    public string Codigo { get; set; } = null!;

    public int? IdDocumentoDe { get; set; }

    public string? TipoDocumento { get; set; }

    public string Serie { get; set; } = null!;

    public string Folio { get; set; } = null!;

    public int? Estado { get; set; }
}
