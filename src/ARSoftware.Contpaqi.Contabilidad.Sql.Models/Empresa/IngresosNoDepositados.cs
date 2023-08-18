using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa;

public partial class IngresosNoDepositados
{
    public int Id { get; set; }

    public int? RowVersion { get; set; }

    public int IdDocumentoDe { get; set; }

    public string TipoDocumento { get; set; } = null!;

    public string Folio { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public int? Ejercicio { get; set; }

    public int? Periodo { get; set; }

    public DateTime FechaAplicacion { get; set; }

    public int? EjercicioAp { get; set; }

    public int? PeriodoAp { get; set; }

    public string? CodigoPersona { get; set; }

    public string? BeneficiarioPagador { get; set; }

    public int NatBancaria { get; set; }

    public int Naturaleza { get; set; }

    public string CodigoMoneda { get; set; } = null!;

    public string? CodigoMonedaTipoCambio { get; set; }

    public double? TipoCambio { get; set; }

    public double? Total { get; set; }

    public string? Referencia { get; set; }

    public string? Concepto { get; set; }

    public bool? EsDepositado { get; set; }

    public bool? EsAsociado { get; set; }

    public string? UsuAutorizaPresupuesto { get; set; }

    public int? PosibilidadPago { get; set; }

    public bool? EsProyectado { get; set; }

    public int? Origen { get; set; }

    public int? IdChequeOrigen { get; set; }

    public int? IdCuentaCheques { get; set; }

    public int? IdDeposito { get; set; }

    public double? TipoCambioDeposito { get; set; }

    public int? IdDocumento { get; set; }

    public bool? EsAnticipo { get; set; }

    public bool? EsTraspasado { get; set; }

    public string? UsuarioCrea { get; set; }

    public string? UsuarioModifica { get; set; }

    public bool? tieneCFD { get; set; }

    public string Guid { get; set; } = null!;

    public string? CuentaOrigen { get; set; }

    public int? BancoOrigen { get; set; }

    public string? OtroMetodoDePago { get; set; }

    public string? NumeroCheque { get; set; }

    public int? NumAsoc { get; set; }
}
