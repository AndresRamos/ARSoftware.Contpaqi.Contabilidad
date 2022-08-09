using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa
{
    public partial class ClavesCV
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public int TipoClave { get; set; }
        public int Consec { get; set; }
        public string Clave { get; set; }
        public string Descripcion { get; set; }
        public int? IdCuenta { get; set; }
    }
}
