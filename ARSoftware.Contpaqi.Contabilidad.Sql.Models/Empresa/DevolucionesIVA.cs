using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa
{
    public partial class DevolucionesIVA
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public int IdPoliza { get; set; }
        public int NumDev { get; set; }
        public int IdProveedor { get; set; }
        public double? ImpTotal { get; set; }
        public double? PorIVA { get; set; }
        public double? ImpBase { get; set; }
        public double? ImpIVA { get; set; }
        public bool? CausaIVA { get; set; }
        public string TimeStamp { get; set; }
        public bool? ExentoIVA { get; set; }
        public int? IdDocto2 { get; set; }
        public string Serie { get; set; }
        public int? Folio { get; set; }
        public string Referencia { get; set; }
        public double? OtrosImptos { get; set; }
        public double? ImpSinRet { get; set; }
        public double? IVARetenido { get; set; }
        public double? ISRRetenido { get; set; }
        public double? GranTotal { get; set; }
        public int? EjercicioAsignado { get; set; }
        public int? PeriodoAsignado { get; set; }
        public int? IdCuenta { get; set; }
        public double? IVAPagNoAcred { get; set; }
        public double? IETUDeducible { get; set; }
        public bool? IETUModificado { get; set; }
        public double? IETUAcreditable { get; set; }
        public int? IdConceptoIETU { get; set; }
        public string UUID { get; set; }
        public double? IEPS { get; set; }
    }
}
