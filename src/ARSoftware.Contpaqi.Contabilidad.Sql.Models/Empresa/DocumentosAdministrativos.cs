using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa;

public partial class DocumentosAdministrativos
{
    public int Id { get; set; }

    public int? RowVersion { get; set; }

    public string UUID { get; set; } = null!;

    public string? CodigoPersona { get; set; }

    public string? CodigoAsiento { get; set; }

    public string? CodigoTipoOperacion { get; set; }

    public string? CodigoResponsableGasto { get; set; }

    public string? CodigoSegmentoNegocio { get; set; }
}
