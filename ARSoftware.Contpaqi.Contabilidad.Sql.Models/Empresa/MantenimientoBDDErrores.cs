using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa
{
    public partial class MantenimientoBDDErrores
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public string GuidProceso { get; set; }
        public string DescripcionError { get; set; }
        public int NumError { get; set; }
    }
}
