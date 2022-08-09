using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa
{
    public partial class AsocCFDIs
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public string GuidRef { get; set; }
        public string UUID { get; set; }
        public string Referencia { get; set; }
        public string AppType { get; set; }
        public bool? Reconstruir { get; set; }
    }
}
