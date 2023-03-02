using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa
{
    public partial class AsientosContablesCV
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public int Consec { get; set; }
        public int? IdClave { get; set; }
        public int? IdCuenta { get; set; }
        public bool? TipoMovto { get; set; }
        public int? ClaveImp { get; set; }
        public double? Importe { get; set; }
        public int? RefMovto { get; set; }
        public string Referencia { get; set; }
        public string Concepto { get; set; }
        public int? IdDiario { get; set; }
        public int? IdSegNeg { get; set; }
    }
}
