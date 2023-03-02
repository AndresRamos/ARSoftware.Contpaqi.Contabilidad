using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa
{
    public partial class MovimientosPoliza
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public int IdPoliza { get; set; }
        public int Ejercicio { get; set; }
        public int Periodo { get; set; }
        public int TipoPol { get; set; }
        public int Folio { get; set; }
        public int NumMovto { get; set; }
        public int IdCuenta { get; set; }
        public bool? TipoMovto { get; set; }
        public double? Importe { get; set; }
        public double? ImporteME { get; set; }
        public string Referencia { get; set; }
        public string Concepto { get; set; }
        public int? IdDiario { get; set; }
        public DateTime Fecha { get; set; }
        public int? IdSegNeg { get; set; }
        public string TimeStamp { get; set; }
        public string Guid { get; set; }
        public DateTime? FechaAplicacion { get; set; }
        public bool? EsConciliado { get; set; }
    }
}
