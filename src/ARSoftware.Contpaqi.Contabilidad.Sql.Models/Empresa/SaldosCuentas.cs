using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa
{
    public partial class SaldosCuentas
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public int IdCuenta { get; set; }
        public int Ejercicio { get; set; }
        public int Tipo { get; set; }
        public double? SaldoIni { get; set; }
        public double? Importes1 { get; set; }
        public double? Importes2 { get; set; }
        public double? Importes3 { get; set; }
        public double? Importes4 { get; set; }
        public double? Importes5 { get; set; }
        public double? Importes6 { get; set; }
        public double? Importes7 { get; set; }
        public double? Importes8 { get; set; }
        public double? Importes9 { get; set; }
        public double? Importes10 { get; set; }
        public double? Importes11 { get; set; }
        public double? Importes12 { get; set; }
        public double? Importes13 { get; set; }
        public double? Importes14 { get; set; }
        public string TimeStamp { get; set; }
    }
}
