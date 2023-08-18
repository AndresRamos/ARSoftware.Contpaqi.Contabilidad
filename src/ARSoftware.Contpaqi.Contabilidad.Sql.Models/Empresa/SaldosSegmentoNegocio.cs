using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa;

public partial class SaldosSegmentoNegocio
{
    public int Id { get; set; }

    public int? RowVersion { get; set; }

    public int IdCuenta { get; set; }

    public int IdSegNeg { get; set; }

    public int Ejercicio { get; set; }

    public int Tipo { get; set; }

    public double? SaldoIni { get; set; }

    public double? Importe1 { get; set; }

    public double? Importe2 { get; set; }

    public double? Importe3 { get; set; }

    public double? Importe4 { get; set; }

    public double? Importe5 { get; set; }

    public double? Importe6 { get; set; }

    public double? Importe7 { get; set; }

    public double? Importe8 { get; set; }

    public double? Importe9 { get; set; }

    public double? Importe10 { get; set; }

    public double? Importe11 { get; set; }

    public double? Importe12 { get; set; }

    public double? Importe13 { get; set; }

    public double? Importe14 { get; set; }

    public string? TimeStamp { get; set; }
}
