using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa
{
    public partial class AsocDoctosAdministrativos
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public string UUID { get; set; }
        public string GuidPoliza { get; set; }
    }
}
