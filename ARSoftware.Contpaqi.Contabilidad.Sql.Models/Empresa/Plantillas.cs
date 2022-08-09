using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa
{
    public partial class Plantillas
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int? IdDocumentoDe { get; set; }
        public string TipoDocumento { get; set; }
        public string BeneficiarioPagador { get; set; }
        public string Referencia { get; set; }
        public string Concepto { get; set; }
        public double? Total { get; set; }
        public bool? EsParaAbonoCta { get; set; }
        public string CodigoPersona { get; set; }
        public int? NatBancaria { get; set; }
        public int? Naturaleza { get; set; }
        public string CodigoMoneda { get; set; }
    }
}
