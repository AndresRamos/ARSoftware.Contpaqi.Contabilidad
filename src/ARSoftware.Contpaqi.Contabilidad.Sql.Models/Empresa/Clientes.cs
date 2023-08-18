using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa;

public partial class Clientes
{
    public int Id { get; set; }

    public int? RowVersion { get; set; }

    public string Codigo { get; set; } = null!;

    public string? CodigoPersona { get; set; }

    public string? CodigoCuenta { get; set; }

    public string? CodigoCtaComplementaria { get; set; }

    public string? CodigoPrepoliza { get; set; }

    public int? IdSegNeg { get; set; }

    public string? BancoOrigen { get; set; }

    public string? CuentaOrigen { get; set; }

    public string? SegContCliente1 { get; set; }

    public string? SegContCliente2 { get; set; }

    public string? SegContCliente3 { get; set; }

    public string? SegContCliente4 { get; set; }

    public string? SegContCliente5 { get; set; }

    public string? SegContCliente6 { get; set; }

    public string? SegContCliente7 { get; set; }

    public string? CodigoAsiento { get; set; }

    public int? Diario { get; set; }

    public int? BancoOrigenId { get; set; }
}
