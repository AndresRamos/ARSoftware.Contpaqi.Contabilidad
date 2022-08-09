using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Generales
{
    public partial class EmpresasUsuario
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public int IdUsuario { get; set; }
        public int IdEmpresa { get; set; }
    }
}
