using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa;

public partial class RelacionEmpresasNube
{
    public int Id { get; set; }

    public int? RowVersion { get; set; }

    public string CompanyID { get; set; } = null!;

    public string InstanceID { get; set; } = null!;

    public string IdAppNube { get; set; } = null!;

    public string NombreEmpresa { get; set; } = null!;

    public string? AliasEmpresa { get; set; }

    public string RFC { get; set; } = null!;

    public string? Estado { get; set; }
}
