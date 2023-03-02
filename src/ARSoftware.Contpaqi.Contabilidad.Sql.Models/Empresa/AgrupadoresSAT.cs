using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa
{
    public partial class AgrupadoresSAT
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public int? CtaMayor { get; set; }
        public int? IdRubro { get; set; }
        public string TimeStamp { get; set; }
    }
}
