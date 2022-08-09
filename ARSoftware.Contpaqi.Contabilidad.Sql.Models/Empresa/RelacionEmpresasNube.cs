using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa
{
    public partial class RelacionEmpresasNube
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public string CompanyID { get; set; }
        public string InstanceID { get; set; }
        public string IdAppNube { get; set; }
        public string NombreEmpresa { get; set; }
        public string AliasEmpresa { get; set; }
        public string RFC { get; set; }
        public string Estado { get; set; }
    }
}
