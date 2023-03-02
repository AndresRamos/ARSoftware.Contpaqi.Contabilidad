using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa
{
    public partial class NombresValoresCV
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public int NumValor { get; set; }
        public string Descripcion { get; set; }
    }
}
