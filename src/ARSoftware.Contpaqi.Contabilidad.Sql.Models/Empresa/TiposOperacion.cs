using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa
{
    public partial class TiposOperacion
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string SegContTipoOperacion1 { get; set; }
        public string SegContTipoOperacion2 { get; set; }
        public string SegContTipoOperacion3 { get; set; }
        public string SegContTipoOperacion4 { get; set; }
        public string SegContTipoOperacion5 { get; set; }
        public string SegContTipoOperacion6 { get; set; }
        public string SegContTipoOperacion7 { get; set; }
    }
}
