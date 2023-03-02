using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa
{
    public partial class EmisionesSAT
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public DateTime Fecha { get; set; }
        public int Ano { get; set; }
        public int Mes { get; set; }
        public string Guid { get; set; }
    }
}
