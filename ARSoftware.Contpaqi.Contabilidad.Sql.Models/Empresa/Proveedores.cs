using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa
{
    public partial class Proveedores
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string RFC { get; set; }
        public string CURP { get; set; }
        public int? TipoOperacion { get; set; }
        public int? IdCuenta { get; set; }
        public string TimeStamp { get; set; }
        public bool? TasaIVA15 { get; set; }
        public bool? TasaIVA10 { get; set; }
        public bool? TasaIVA0 { get; set; }
        public bool? TasaIVAExento { get; set; }
        public bool? TasaIVAOtra1 { get; set; }
        public bool? TasaIVAOtra2 { get; set; }
        public double? TasaOtra1 { get; set; }
        public double? TasaOtra2 { get; set; }
        public int? TasaAsumida { get; set; }
        public double? RetencionIVA { get; set; }
        public double? RetencionISR { get; set; }
        public int? TipoTercero { get; set; }
        public string IdFiscal { get; set; }
        public string NomExtranjero { get; set; }
        public string Pais { get; set; }
        public string Nacionalidad { get; set; }
        public int? IdConceptoIETU { get; set; }
        public string CodigoPersona { get; set; }
        public string CodigoCuenta { get; set; }
        public bool? EsParaAbonoCta { get; set; }
        public string CodigoCtaComplementaria { get; set; }
        public string CodigoPrepoliza { get; set; }
        public int? IdSegNeg { get; set; }
        public bool? TasaIVA16 { get; set; }
        public bool? TasaIVA11 { get; set; }
        public string ClaveBanco { get; set; }
        public string Sucursal { get; set; }
        public string CuentaClabe { get; set; }
        public string Referencia { get; set; }
        public string CodigoCtaGastos { get; set; }
        public string CodigoCtaGastosComplementaria { get; set; }
        public bool? TasaIVA8 { get; set; }
        public string SegContProveedor1 { get; set; }
        public string SegContProveedor2 { get; set; }
        public string SegContProveedor3 { get; set; }
        public string SegContProveedor4 { get; set; }
        public string SegContProveedor5 { get; set; }
        public string SegContProveedor6 { get; set; }
        public string SegContProveedor7 { get; set; }
        public string CodigoAsiento { get; set; }
        public int? Diario { get; set; }
        public int? BancoDestinoId { get; set; }
    }
}
