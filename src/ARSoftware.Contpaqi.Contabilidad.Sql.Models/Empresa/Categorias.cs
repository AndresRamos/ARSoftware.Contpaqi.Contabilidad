using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa
{
    public partial class Categorias
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string CodigoMoneda { get; set; }
        public string Tipo { get; set; }
        public string Presupuesto { get; set; }
        public string CodigoCuenta { get; set; }
        public string CodigoCtaComplementaria { get; set; }
        public string CodigoPrepoliza { get; set; }
        public int? IdSegNeg { get; set; }
        public int? IdDatoExtra { get; set; }
        public string Nivel { get; set; }
        public string SegmentoCuenta { get; set; }
    }
}
