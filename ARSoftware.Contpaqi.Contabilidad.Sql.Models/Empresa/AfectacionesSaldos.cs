using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa
{
    public partial class AfectacionesSaldos
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public int NumTransac { get; set; }
        public int? IdEmpresa { get; set; }
        public int? IdCuenta { get; set; }
        public string TipoAnt { get; set; }
        public string TipoNvo { get; set; }
        public int? IdCtaSupAnt { get; set; }
        public int? IdCtaSupNva { get; set; }
        public int? Estado { get; set; }
        public int? MotivoError { get; set; }
        public bool? CtaSupEsAfectable { get; set; }
        public bool? Afectar { get; set; }
    }
}
