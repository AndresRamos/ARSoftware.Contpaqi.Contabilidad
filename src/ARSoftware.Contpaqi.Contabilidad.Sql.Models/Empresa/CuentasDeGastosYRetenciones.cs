using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa
{
    public partial class CuentasDeGastosYRetenciones
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public string NombreImpuesto { get; set; }
        public int IdCuentaContable { get; set; }
        public bool? AsignarAlNeto { get; set; }
    }
}
