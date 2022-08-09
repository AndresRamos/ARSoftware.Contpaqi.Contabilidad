using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa
{
    public partial class DocumentosBancarios
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public int IdCheque { get; set; }
        public int IdEgreso { get; set; }
        public int IdIngreso { get; set; }
        public int IdIngresoNoDepositado { get; set; }
        public int IdDeposito { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? FechaAplicacion { get; set; }
        public bool? EsConciliado { get; set; }
        public bool? EsProyectado { get; set; }
        public int IdCuentaCheques { get; set; }
    }
}
