using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa
{
    public partial class MovtosEdoCtaContabilidad
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public int IdMovto { get; set; }
        public string Numero { get; set; }
        public int IdEdoCuentaContable { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaAplicacion { get; set; }
        public string Referencia { get; set; }
        public string Concepto { get; set; }
        public double? Deposito { get; set; }
        public double? Retiro { get; set; }
        public bool? EsConciliado { get; set; }
    }
}
