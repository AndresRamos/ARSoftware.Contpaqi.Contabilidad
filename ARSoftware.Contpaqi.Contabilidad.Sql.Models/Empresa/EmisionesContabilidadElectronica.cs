using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa
{
    public partial class EmisionesContabilidadElectronica
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public DateTime Fecha { get; set; }
        public int? Anio { get; set; }
        public int? Mes { get; set; }
        public string TipoSolicitud { get; set; }
        public int? TipoArchivo { get; set; }
        public string NumOrden { get; set; }
        public string NumTramite { get; set; }
        public string Folio { get; set; }
        public DateTime? FechaModBal { get; set; }
        public int? EstadoPSRDD { get; set; }
        public int? EstadoDocto { get; set; }
        public int? EstadoSAT { get; set; }
        public string UsuarioCrea { get; set; }
        public string Guid { get; set; }
        public string GuidAcuse { get; set; }
        public int? TipoEntrega { get; set; }
    }
}
