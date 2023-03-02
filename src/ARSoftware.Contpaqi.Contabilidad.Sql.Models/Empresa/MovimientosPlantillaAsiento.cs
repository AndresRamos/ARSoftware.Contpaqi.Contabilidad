using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa
{
    public partial class MovimientosPlantillaAsiento
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public int NumeroMovto { get; set; }
        public int IdPlantillaAsiento { get; set; }
        public int? TipoMovto { get; set; }
        public int? Referencia { get; set; }
        public string TextoReferencia { get; set; }
        public int? Concepto { get; set; }
        public string TextoConcepto { get; set; }
        public string IdSegmentoNegocio { get; set; }
        public bool? ConcentrarMovimientos { get; set; }
        public string FormulaCuenta { get; set; }
        public string FormulaImporte { get; set; }
        public string FormulaImporteME { get; set; }
        public string IdDiario { get; set; }
        public int? OpcionSegmento { get; set; }
    }
}
