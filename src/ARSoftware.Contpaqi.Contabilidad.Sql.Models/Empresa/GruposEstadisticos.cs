using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa
{
    public partial class GruposEstadisticos
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public string Codigo { get; set; }
        public int PosSeg { get; set; }
        public int? LongSeg { get; set; }
        public string Patron { get; set; }
        public string CuentaDel { get; set; }
        public string CuentaAl { get; set; }
        public string TimeStamp { get; set; }
    }
}
