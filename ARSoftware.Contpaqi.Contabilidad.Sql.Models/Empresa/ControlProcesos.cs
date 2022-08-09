using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa
{
    public partial class ControlProcesos
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public string GuidControl { get; set; }
        public string ProcesoDescripcion { get; set; }
        public int? Porcentaje { get; set; }
        public DateTime? FechaInicial { get; set; }
        public DateTime? FechaFinal { get; set; }
        public int? TotalExtraccion { get; set; }
        public int? TotalProcesado { get; set; }
        public string NombreLog { get; set; }
        public string EstatusProceso { get; set; }
    }
}
