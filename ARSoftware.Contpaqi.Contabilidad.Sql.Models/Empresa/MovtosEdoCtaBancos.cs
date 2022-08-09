using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa
{
    public partial class MovtosEdoCtaBancos
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public int IdMovto { get; set; }
        public string Numero { get; set; }
        public int IdEdoCtaBanco { get; set; }
        public DateTime Fecha { get; set; }
        public string TipoMovto { get; set; }
        public string Referencia { get; set; }
        public string Concepto { get; set; }
        public double? Total { get; set; }
        public bool? EsConciliado { get; set; }
    }
}
