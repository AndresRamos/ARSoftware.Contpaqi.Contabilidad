using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa
{
    public partial class ImpuestosRetencion
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public string TimeStamp { get; set; }
        public int IdRetencion { get; set; }
        public string Impuesto { get; set; }
        public double? BaseRet { get; set; }
        public double? MontoRet { get; set; }
        public int? TipoPagoRet { get; set; }
        public string Guid { get; set; }
    }
}
