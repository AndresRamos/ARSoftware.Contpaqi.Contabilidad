using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa
{
    public partial class MantenimientoBDDProcesos
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public string GuidProceso { get; set; }
        public DateTime? FechaInicial { get; set; }
        public DateTime? FechaFinal { get; set; }
        public int? LogsEliminados { get; set; }
        public int? IndicesReorganizados { get; set; }
        public int? IndicesReconstruidos { get; set; }
        public int? UpdStatix { get; set; }
    }
}
