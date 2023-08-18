using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa;

public partial class EdosCtaContabilidad
{
    public int Id { get; set; }

    public int? RowVersion { get; set; }

    public int Numero { get; set; }

    public int IdCuentaCheque { get; set; }

    public int IdConciliacionBancaria { get; set; }

    public DateTime Fecha { get; set; }

    public DateTime FechaInicial { get; set; }

    public DateTime FechaFinal { get; set; }

    public bool EstadoConciliacion { get; set; }

    public double? SaldoInicial { get; set; }

    public double? SaldoFinal { get; set; }

    public string? TimeStamp { get; set; }
}
