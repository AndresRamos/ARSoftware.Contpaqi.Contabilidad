using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Generales
{
    public partial class Usuarios
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public bool? EsBaja { get; set; }
        public string Clave { get; set; }
        public int? IdPerfil { get; set; }
        public bool? UsaTodasEmpresas { get; set; }
        public bool? UsuarioContPAQ { get; set; }
        public bool? UsuarioAdminPAQ { get; set; }
        public bool? UsuarioNomiPAQ { get; set; }
        public bool? UsuarioCheqPAQ { get; set; }
        public string TimeStamp { get; set; }
        public string Guid { get; set; }
        public string eMail { get; set; }
        public string eMailClave { get; set; }
    }
}
