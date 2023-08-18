using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Generales;

public partial class Procesos
{
    public int Id { get; set; }

    public int? RowVersion { get; set; }

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public int Tipo { get; set; }

    public int Sistema { get; set; }

    public int Permisos { get; set; }

    public string? TimeStamp { get; set; }

    public int? SistemaIntegrado { get; set; }
}
