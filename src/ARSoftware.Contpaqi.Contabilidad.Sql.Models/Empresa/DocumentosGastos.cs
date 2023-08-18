using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa;

public partial class DocumentosGastos
{
    public int Id { get; set; }

    public int? RowVersion { get; set; }

    public string CodigoPersona { get; set; } = null!;

    public int TipoDeGasto { get; set; }

    public string Folio { get; set; } = null!;

    public DateTime FechaApertura { get; set; }

    public string? Concepto { get; set; }

    public string? Referencia { get; set; }

    public int? IdDocumentoDe { get; set; }

    public int? IdCuentaDocumentoBancario { get; set; }

    public string? TipoDocumentoBancario { get; set; }

    public string? FolioDocumentoBancario { get; set; }

    public int? IdPoliza { get; set; }

    public DateTime? FechaCierre { get; set; }

    public string Guid { get; set; } = null!;

    public string? TipoOperacion { get; set; }

    public int? SistOrig { get; set; }

    public int? Ejercicio { get; set; }

    public int? Periodo { get; set; }

    public double? Propina { get; set; }
}
