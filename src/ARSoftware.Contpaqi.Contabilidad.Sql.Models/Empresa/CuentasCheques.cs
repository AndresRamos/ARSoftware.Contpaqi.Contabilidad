using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa;

public partial class CuentasCheques
{
    public int Id { get; set; }

    public int? RowVersion { get; set; }

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public int? IdBanco { get; set; }

    public string? CodigoMoneda { get; set; }

    public bool? UsarRefConciliacion { get; set; }

    public bool? UsaRango { get; set; }

    public bool? UsaNumeracionAut { get; set; }

    public string? FolioActual { get; set; }

    public string? FolioInicial { get; set; }

    public string? FolioFinal { get; set; }

    public string? Titular1 { get; set; }

    public string? Titular2 { get; set; }

    public string? Titular3 { get; set; }

    public DateTime? FechaUltConciliacion { get; set; }

    public string? CodigoCuenta { get; set; }

    public string? CodigoCtaComplementaria { get; set; }

    public int? IdSegNeg { get; set; }

    public string? NumSucursal { get; set; }

    public string? Sucursal { get; set; }

    public string? Ejecutivo { get; set; }

    public string? Telefono { get; set; }

    public string? Fax { get; set; }

    public string? Direccion { get; set; }

    public string? FormatoCheque { get; set; }

    public string? FormatoDeposito { get; set; }

    public string? FormatoCargo { get; set; }

    public string? FormatoAbono { get; set; }

    public string? FormatoIngreso { get; set; }

    public int? IdDatoExtra { get; set; }

    public int? Referencia { get; set; }

    public int? Concepto { get; set; }

    public bool? UsaActTipoCambio { get; set; }

    public int? IdPlantillaEstadoCuenta { get; set; }

    public DateTime? FechaSaldoInicial { get; set; }

    public int? IdDiarioEgreso { get; set; }

    public int? IdDiarioIngreso { get; set; }

    public string? CodigoConceptoComercialCheque { get; set; }

    public string? CodigoConceptoComercialEgreso { get; set; }

    public string? CodigoConceptoComercialIngreso { get; set; }

    public string? CodigoConceptoComercialIngresoND { get; set; }

    public string? CodigoConceptoComercialIngresoCFD { get; set; }

    public string? CodigoConceptoComercialIngresoNDCFD { get; set; }

    public bool? permitirCambiarConceptoComercial { get; set; }

    public string? SegContCuentaCheque1 { get; set; }

    public string? SegContCuentaCheque2 { get; set; }

    public string? SegContCuentaCheque3 { get; set; }

    public string? SegContCuentaCheque4 { get; set; }

    public string? SegContCuentaCheque5 { get; set; }

    public string? SegContCuentaCheque6 { get; set; }

    public string? SegContCuentaCheque7 { get; set; }

    public bool? UsarRefIngEgConciliacion { get; set; }

    public bool? EsBaja { get; set; }

    public string? TDCheque { get; set; }

    public string? TDEgreso { get; set; }

    public string? TDIngreso { get; set; }

    public string? TDDeposito { get; set; }

    public string? TDIngresoND { get; set; }
}
