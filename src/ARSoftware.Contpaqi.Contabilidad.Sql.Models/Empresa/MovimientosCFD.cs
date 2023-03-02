using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa
{
    public partial class MovimientosCFD
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public int IdPoliza { get; set; }
        public int? IdCuentaFlujoEfectivo { get; set; }
        public int? IdSegmentoNegCtaFlujo { get; set; }
        public int NumMovto { get; set; }
        public DateTime? Fecha { get; set; }
        public string Serie { get; set; }
        public int? Folio { get; set; }
        public string UUID { get; set; }
        public string ClaveRastreo { get; set; }
        public string Referencia { get; set; }
        public int? IdProveedor { get; set; }
        public string CodigoConceptoIETU { get; set; }
        public double? ImpNeto { get; set; }
        public double? ImpNetoME { get; set; }
        public int? IdCuentaNeto { get; set; }
        public int? IdSegmentoNegNeto { get; set; }
        public double? PorIVA { get; set; }
        public double? ImporteIVA { get; set; }
        public double? ImporteIVAME { get; set; }
        public bool? IVATasaExcenta { get; set; }
        public int? IdCuentaIVA { get; set; }
        public int? IdSegmentoNegIVA { get; set; }
        public string NombreImpuesto { get; set; }
        public double? ImpImpuesto { get; set; }
        public double? ImpImpuestoME { get; set; }
        public int? IdCuentaImpuesto { get; set; }
        public int? IdSegmentoNegImp { get; set; }
        public double? ImpOtrosGastos { get; set; }
        public double? ImpOtrosGastosME { get; set; }
        public int? IdCuentaOtrosGastos { get; set; }
        public int? IdSegmentoNegOtrosGastos { get; set; }
        public double? IVARetenido { get; set; }
        public double? IVARetenidoME { get; set; }
        public int? IdCuentaRetIVA { get; set; }
        public int? IdSegmentoNegRetIVA { get; set; }
        public double? ISRRetenido { get; set; }
        public double? ISRRetenidoME { get; set; }
        public int? IdCuentaRetISR { get; set; }
        public int? IdSegmentoNegRetISR { get; set; }
        public string NombreOtrasRetenciones { get; set; }
        public double? ImpOtrasRetenciones { get; set; }
        public double? ImpOtrasRetencionesME { get; set; }
        public int? IdCuentaOtrasRetenciones { get; set; }
        public int? IdSegmentoNegOtrasRet { get; set; }
        public double? BaseIVADIOT { get; set; }
        public double? BaseIETU { get; set; }
        public double? IVANoAcreditable { get; set; }
        public double? ImpTotalErogacion { get; set; }
        public double? IVAAcreditable { get; set; }
        public double? ImpExtra1 { get; set; }
        public double? ImpExtra2 { get; set; }
        public int? IdCategoria { get; set; }
        public int? IdSubCategoria { get; set; }
        public double? TipoCambio { get; set; }
        public int IdDocGastos { get; set; }
        public bool? EsCapturaCompleta { get; set; }
        public string UsuAutorizaPresupuesto { get; set; }
        public double? tipoCambioCategoria { get; set; }
        public double? impCategoria { get; set; }
        public string Concepto { get; set; }
        public string FolioStr { get; set; }
        public string GuidComprobante { get; set; }
    }
}
