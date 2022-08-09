using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa
{
    public partial class Retenciones
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public string TimeStamp { get; set; }
        public string Folio { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime? FechaExpedicion { get; set; }
        public int? MesInicialPeriodo { get; set; }
        public int? MesFinalPeriodo { get; set; }
        public int? EjercicioPeriodo { get; set; }
        public string Descripcion { get; set; }
        public string Referencia { get; set; }
        public int IdBeneficiario { get; set; }
        public int IdComplemento { get; set; }
        public double? TotalMontoOperacion { get; set; }
        public double? TotalGravado { get; set; }
        public double? TotalExento { get; set; }
        public double? TotalRetenciones { get; set; }
        public string XMLComplemento { get; set; }
        public int? Estado { get; set; }
        public string FolioCancelacion { get; set; }
        public string Guid { get; set; }
        public string GuidRetencion { get; set; }
        public string UUIDRetencion { get; set; }
        public int? Version { get; set; }
        public string TipoRelacion { get; set; }
        public string UUIDAsociado { get; set; }
    }
}
