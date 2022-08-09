using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa
{
    public partial class EdosCtaContabilidad
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public int Numero { get; set; }
        public int IdCuentaContable { get; set; }
        public DateTime Fecha { get; set; }
        public int? Ejercicio { get; set; }
        public int? Periodo { get; set; }
        public bool EstadoConciliacion { get; set; }
        public double? SaldoInicial { get; set; }
        public double? SaldoFinal { get; set; }
        public string TimeStamp { get; set; }
    }
}
