using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa
{
    public partial class DatosExtra
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public string Codigo { get; set; }
        public string TextoExtra1 { get; set; }
        public string TextoExtra2 { get; set; }
        public string TextoExtra3 { get; set; }
        public string TextoExtra4 { get; set; }
        public DateTime? FechaExtra1 { get; set; }
        public double? ImporteExtra1 { get; set; }
        public double? ImporteExtra2 { get; set; }
        public double? ImporteExtra3 { get; set; }
        public double? ImporteExtra4 { get; set; }
    }
}
