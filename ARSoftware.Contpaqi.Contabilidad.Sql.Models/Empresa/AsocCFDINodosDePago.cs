using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa
{
    public partial class AsocCFDINodosDePago
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public string UUIDRep { get; set; }
        public int NumNodoPago { get; set; }
        public string GuidReferencia { get; set; }
        public string AplicationType { get; set; }
    }
}
