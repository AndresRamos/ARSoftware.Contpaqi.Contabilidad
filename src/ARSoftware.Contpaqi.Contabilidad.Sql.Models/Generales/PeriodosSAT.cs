using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Generales;

public partial class PeriodosSAT
{
    public int Id { get; set; }

    public int? RowVersion { get; set; }

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public int? MesInicial { get; set; }

    public int? MesFinal { get; set; }

    public string Periodicidad { get; set; } = null!;
}
