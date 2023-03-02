using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa
{
    public partial class AsocCategorias
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public int IdCategoria { get; set; }
        public int IdSubCategoria { get; set; }
        public double? PorcAplicacion { get; set; }
    }
}
