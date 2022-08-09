using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa
{
    public partial class ParametrosInicialesMto
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public string DBTemplate { get; set; }
        public int? LogSize { get; set; }
        public int? LogLevel1 { get; set; }
        public int? LogLevel2 { get; set; }
        public int? LogLevel3 { get; set; }
        public int? IdxLevel1 { get; set; }
        public int? IdxLevel2 { get; set; }
        public int? IdxLevel3 { get; set; }
    }
}
