using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa;

public partial class MantenimientoBDDIndexTmps
{
    public int Id { get; set; }

    public int? RowVersion { get; set; }

    public string NombreTabla { get; set; } = null!;

    public string NombreIndex { get; set; } = null!;

    public int? PorcentajeFragmentacion { get; set; }
}
