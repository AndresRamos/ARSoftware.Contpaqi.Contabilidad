using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa
{
    public partial class Bancos
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Logotipo { get; set; }
        public string PaginaWeb { get; set; }
        public string ClaveFiscal { get; set; }
        public string TimeStamp { get; set; }
        public bool? EsBancoExtranjero { get; set; }
        public string RFC { get; set; }
    }
}
