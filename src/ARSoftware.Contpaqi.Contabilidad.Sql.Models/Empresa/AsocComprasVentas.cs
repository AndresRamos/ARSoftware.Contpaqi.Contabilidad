using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa;

public partial class AsocComprasVentas
{
    public int Id { get; set; }

    public int? RowVersion { get; set; }

    public int? IdDocumento { get; set; }

    public int IdDocumentoDe { get; set; }

    public string TipoDocumento { get; set; } = null!;

    public int IdCuentaCheques { get; set; }

    public string Folio { get; set; } = null!;

    public string? CodigoConceptoAdmin { get; set; }

    public string? ConceptoAdmin { get; set; }

    public string? SerieAdminPAQ { get; set; }

    public string? FolioAdminPAQ { get; set; }

    public string? CodigoConceptoPago { get; set; }

    public string? FechaAdminPAQ { get; set; }

    public string? CodigoCteProvAdminPAQ { get; set; }
}
