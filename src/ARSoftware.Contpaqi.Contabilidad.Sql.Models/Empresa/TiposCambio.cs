using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa
{
    public partial class TiposCambio
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public int Moneda { get; set; }
        public DateTime Fecha { get; set; }
        public double? TipoCambio { get; set; }
        public string TimeStamp { get; set; }
        public int Tipo { get; set; }
    }
}
