using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa
{
    public partial class Personas
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string RFC { get; set; }
        public string CURP { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public bool? EsCliente { get; set; }
        public bool? EsProveedor { get; set; }
        public bool? EsEmpleado { get; set; }
        public bool? EsAgente { get; set; }
        public bool? EsPersona { get; set; }
        public bool? EsBaja { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Telefono3 { get; set; }
        public string Fax { get; set; }
        public string eMail { get; set; }
        public string PaginaWeb { get; set; }
        public int? IdDatoExtra { get; set; }
        public bool? GenerarPolizaAuto { get; set; }
        public int? PosibilidadPago { get; set; }
        public int? SistOrig { get; set; }
        public string CodigoAdminPAQ { get; set; }
        public bool? EsResponsableGasto { get; set; }
        public string CtaContableGasto { get; set; }
        public bool? PagarDoctosAMismoRFC { get; set; }
        public bool? GeneraContraCuentaDeudor { get; set; }
        public int? IdCategoria { get; set; }
        public int? IdSubCategoria { get; set; }
        public string SegContPersona1 { get; set; }
        public string SegContPersona2 { get; set; }
        public string SegContPersona3 { get; set; }
        public string SegContPersona4 { get; set; }
        public string SegContPersona5 { get; set; }
        public string SegContPersona6 { get; set; }
        public string SegContPersona7 { get; set; }
        public string CodigoPostal { get; set; }
    }
}
