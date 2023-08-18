using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa;

public partial class DispersionesPagos
{
    public int Id { get; set; }

    public int? RowVersion { get; set; }

    public string UUID { get; set; } = null!;

    public string UUIDRep { get; set; } = null!;

    public string GuidRef { get; set; } = null!;

    public int NumNodoPago { get; set; }

    public DateTime FechaPago { get; set; }

    public double TotalPago { get; set; }

    public double TipoCambio { get; set; }

    public double TotalPagoComprobante { get; set; }
}
