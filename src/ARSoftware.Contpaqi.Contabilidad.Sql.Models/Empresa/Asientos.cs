using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa;

public partial class Asientos
{
    public int Id { get; set; }

    public int? RowVersion { get; set; }

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public int? Frecuencia { get; set; }

    public int? Fecha { get; set; }

    public int? Tipo { get; set; }

    public int? Concepto { get; set; }

    public string? DescripcionConcepto { get; set; }

    public string? AsientoDe { get; set; }

    public int? TipoXML { get; set; }

    public int? IdDiario { get; set; }

    public bool? CrearPolizasSinAfectar { get; set; }

    public bool? SuprimirMovtosEnCero { get; set; }

    public int? IdCtaBancaria { get; set; }

    public bool? CrearDoctoBancario { get; set; }

    public bool? EsBaja { get; set; }

    public bool? CrearPoliza { get; set; }

    public string? TipoCFDI { get; set; }

    public bool? EsGasto { get; set; }

    public bool? VisibleBancos { get; set; }
}
