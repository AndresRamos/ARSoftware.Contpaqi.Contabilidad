using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa
{
    public partial class TiposActivos
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int? IdCtaDeprecC { get; set; }
        public int? IdCtaGastosC { get; set; }
        public int? IdCtaNoDedC { get; set; }
        public int? IdCtaDeprecF { get; set; }
        public int? IdCtaGastosF { get; set; }
        public int? IdCtaNoDedF { get; set; }
    }
}
