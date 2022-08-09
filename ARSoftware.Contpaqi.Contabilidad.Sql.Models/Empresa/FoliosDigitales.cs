using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa
{
    public partial class FoliosDigitales
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int? IdDocumentoDe { get; set; }
        public string CodigoTipoDocumento { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public int NoAprobacion { get; set; }
        public int AnioAprobacion { get; set; }
        public string Serie { get; set; }
        public string FolioActual { get; set; }
        public string FolioInicial { get; set; }
        public string FolioFinal { get; set; }
        public bool? EsFiscal { get; set; }
    }
}
