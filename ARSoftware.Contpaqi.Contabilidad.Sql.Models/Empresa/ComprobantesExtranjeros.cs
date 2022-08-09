using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa
{
    public partial class ComprobantesExtranjeros
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public string TimeStamp { get; set; }
        public DateTime Fecha { get; set; }
        public string NumeroDeFactura { get; set; }
        public string TaxID { get; set; }
        public double MontoTotal { get; set; }
        public int? IdMoneda { get; set; }
        public double? TipoCambio { get; set; }
        public string MetodoDePago { get; set; }
        public int? IdProveedor { get; set; }
        public string Guid { get; set; }
    }
}
