using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa
{
    public partial class Recordatorios
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public int IdDocumentoDe { get; set; }
        public string TipoDocumento { get; set; }
        public int IdCuentaCheque { get; set; }
        public string Folio { get; set; }
        public int IdUsuario { get; set; }
        public string MensajeCorto { get; set; }
        public string Mensaje { get; set; }
        public DateTime? Fecha { get; set; }
    }
}
