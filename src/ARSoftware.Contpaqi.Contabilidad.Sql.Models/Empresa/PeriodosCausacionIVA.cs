using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa
{
    public partial class PeriodosCausacionIVA
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public int? IdPoliza { get; set; }
        public int IdMovimiento { get; set; }
        public int? EjercicioAsignado { get; set; }
        public int? PeriodoAsignado { get; set; }
        public string TimeStamp { get; set; }
    }
}
