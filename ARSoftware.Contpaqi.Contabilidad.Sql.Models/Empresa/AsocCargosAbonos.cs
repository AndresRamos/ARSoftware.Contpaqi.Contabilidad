using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa
{
    public partial class AsocCargosAbonos
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public int? IdDocumento { get; set; }
        public int IdDocumentoDe { get; set; }
        public string TipoDocumento { get; set; }
        public int IdCuentaCheques { get; set; }
        public string Folio { get; set; }
        public string CodigoConceptoPago { get; set; }
        public string SeriePago { get; set; }
        public string FolioPago { get; set; }
        public double? ImportePago { get; set; }
        public DateTime? FechaPago { get; set; }
        public string ConceptoPago { get; set; }
        public string CodigoClienteProveedor { get; set; }
        public string ClienteProveedor { get; set; }
        public bool? EsCFD { get; set; }
        public double? SaldoCargoAbono { get; set; }
        public int IdCheque { get; set; }
        public int IdEgreso { get; set; }
        public int IdIngreso { get; set; }
        public int IdIngresoNoDepositado { get; set; }
        public bool? EsDisponibleDoctoBancario { get; set; }
        public DateTime Fecha { get; set; }
    }
}
