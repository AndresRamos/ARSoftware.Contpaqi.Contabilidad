using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa;

public partial class TiposDocumentos
{
    public int Id { get; set; }

    public int? RowVersion { get; set; }

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public DateTime? FechaRegistro { get; set; }

    public int? Modulo { get; set; }

    public int IdDocumentoDe { get; set; }

    public int? Naturaleza { get; set; }

    public int? NatBancaria { get; set; }

    public int? AfectaExistencia { get; set; }

    public int? TipoGeneracion { get; set; }

    public string? CodigoFolioTipoDocumento { get; set; }

    public string? CodigoFolioDocumentoDe { get; set; }

    public string? CodigoFolioDigital { get; set; }

    public string? FormaPreimpresa { get; set; }

    public int? MaximoMovimientos { get; set; }

    public int? Clasificacion { get; set; }

    public int? ContabilizarPor { get; set; }

    public string? CodigoPrepoliza { get; set; }

    public bool? AgruparMovtosBanco { get; set; }

    public bool? AgruparMovtosPoliza { get; set; }

    public bool? EsFiscal { get; set; }

    public bool? EsFolioDigital { get; set; }

    public bool? UsaAsignaNumero { get; set; }

    public bool? UsaAsignaSerieFolio { get; set; }

    public bool? PermiteEditarFolio { get; set; }

    public string? CodigoAsiento { get; set; }
}
