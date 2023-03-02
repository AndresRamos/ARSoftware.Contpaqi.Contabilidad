using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa
{
    public partial class AsocDoctoCategorias
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public int IdDocumento { get; set; }
        public int IdDocumentoDe { get; set; }
        public string TipoDocumento { get; set; }
        public int? IdCuentaCheque { get; set; }
        public string Folio { get; set; }
        public int IdCategoria { get; set; }
        public int IdSubCategoria { get; set; }
        public double? Porcentaje { get; set; }
        public double? Total { get; set; }
    }
}
