using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa
{
    public partial class PlantillasEstadosCuentas
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public string Nombre { get; set; }
        public string Archivo { get; set; }
        public string TimeStamp { get; set; }
    }
}
