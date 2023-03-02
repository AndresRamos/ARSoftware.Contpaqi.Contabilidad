using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Generales
{
    public partial class Perfiles
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string TimeStamp { get; set; }
    }
}
