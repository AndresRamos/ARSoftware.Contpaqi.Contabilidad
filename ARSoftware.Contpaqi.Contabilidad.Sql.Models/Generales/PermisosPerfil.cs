using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Generales
{
    public partial class PermisosPerfil
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public int IdPerfil { get; set; }
        public int IdProceso { get; set; }
        public int Permisos { get; set; }
        public string TimeStamp { get; set; }
    }
}
