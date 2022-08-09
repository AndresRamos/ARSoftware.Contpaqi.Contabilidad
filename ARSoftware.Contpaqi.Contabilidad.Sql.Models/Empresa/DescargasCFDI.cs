using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa
{
    public partial class DescargasCFDI
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public string Guid { get; set; }
        public string RequestId { get; set; }
        public string GuidProcessADD { get; set; }
        public string TipoComprobante { get; set; }
        public string EstadoComprobante { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public DateTime FechaInicialRango { get; set; }
        public DateTime FechaFinalRango { get; set; }
        public string RFCFiltro { get; set; }
        public int? TotalCFDI { get; set; }
        public int? TotalCancelados { get; set; }
        public int? CodigoEstatus { get; set; }
        public string Estatus { get; set; }
        public string Mensaje { get; set; }
        public bool ValidacionCriterios { get; set; }
        public int TipoNotificacion { get; set; }
        public DateTime? FechaUsuarioNotificado { get; set; }
        public bool UsuarioNotificado { get; set; }
        public int? NoIntentos { get; set; }
    }
}
