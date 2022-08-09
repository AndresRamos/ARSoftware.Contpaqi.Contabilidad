using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa
{
    public partial class Productos
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string ClaveProdServ { get; set; }
        public int? IdTipoOperacion { get; set; }
        public string SegContProducto1 { get; set; }
        public string SegContProducto2 { get; set; }
        public string SegContProducto3 { get; set; }
        public string SegContProducto4 { get; set; }
        public string SegContProducto5 { get; set; }
        public string SegContProducto6 { get; set; }
        public string SegContProducto7 { get; set; }
        public int? SistOrig { get; set; }
    }
}
