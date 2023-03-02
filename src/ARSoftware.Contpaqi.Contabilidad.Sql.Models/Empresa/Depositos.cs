using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa
{
    public partial class Depositos
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public int IdDocumentoDe { get; set; }
        public string TipoDocumento { get; set; }
        public string Folio { get; set; }
        public DateTime Fecha { get; set; }
        public int? Ejercicio { get; set; }
        public int? Periodo { get; set; }
        public DateTime FechaAplicacion { get; set; }
        public int? EjercicioAp { get; set; }
        public int? PeriodoAp { get; set; }
        public int IdCuentaCheques { get; set; }
        public int NatBancaria { get; set; }
        public int Naturaleza { get; set; }
        public double? Total { get; set; }
        public string Referencia { get; set; }
        public string Concepto { get; set; }
        public bool? EsConciliado { get; set; }
        public int? IdMovEdoCta { get; set; }
        public int? EjercicioPol { get; set; }
        public int? PeriodoPol { get; set; }
        public int? TipoPol { get; set; }
        public int? NumPol { get; set; }
        public string FormaDeposito { get; set; }
        public int? IdPoliza { get; set; }
        public int? Origen { get; set; }
        public int? IdDocumento { get; set; }
        public bool? PolizaAgrupada { get; set; }
        public string UsuarioCrea { get; set; }
        public string UsuarioModifica { get; set; }
        public bool? tieneCFD { get; set; }
        public string Guid { get; set; }
    }
}
