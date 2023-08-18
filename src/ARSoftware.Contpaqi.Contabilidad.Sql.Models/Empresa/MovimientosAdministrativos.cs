using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa;

public partial class MovimientosAdministrativos
{
    public int Id { get; set; }

    public int? RowVersion { get; set; }

    public int IdDoctoAdmvo { get; set; }

    public string UUID { get; set; } = null!;

    public int NumMovto { get; set; }

    public string? CodigoTipoOperacion { get; set; }

    public string? CodigoSegmentoNegocio { get; set; }

    public string? CveProdSAT { get; set; }

    public string? CodigoProducto { get; set; }
}
