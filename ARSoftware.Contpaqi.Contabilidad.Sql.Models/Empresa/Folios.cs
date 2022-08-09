using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa
{
    public partial class Folios
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public string Codigo { get; set; }
        public int IdDocumentoDe { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public int? NoAprobacion { get; set; }
        public string Serie { get; set; }
        public bool? UsaRango { get; set; }
        public string FolioActual { get; set; }
        public string FolioInicial { get; set; }
        public string FolioFinal { get; set; }
        public int? TipoGeneracion { get; set; }
    }
}
