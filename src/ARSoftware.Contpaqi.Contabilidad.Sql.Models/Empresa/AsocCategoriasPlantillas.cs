using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa
{
    public partial class AsocCategoriasPlantillas
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public string CodigoPlantilla { get; set; }
        public int IdCategoria { get; set; }
        public int IdSubCategoria { get; set; }
        public double? Porcentaje { get; set; }
        public double? Total { get; set; }
    }
}
