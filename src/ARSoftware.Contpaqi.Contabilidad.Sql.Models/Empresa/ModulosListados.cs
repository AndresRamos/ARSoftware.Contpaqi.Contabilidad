using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa;

public partial class ModulosListados
{
    public int Id { get; set; }

    public int? RowVersion { get; set; }

    public int Consec { get; set; }

    public int? Modulo { get; set; }

    public string? ColumnaOrigen { get; set; }

    public string? ColumnaDesplegar { get; set; }

    public string? ColumnaDesIdiom { get; set; }

    public string? Tipo { get; set; }

    public int? TipoDato { get; set; }

    public int? PorOmision { get; set; }

    public string? Tabla { get; set; }
}
