﻿using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa
{
    public partial class TiposPolizas
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int? Tipo { get; set; }
        public bool? PorEjercicio { get; set; }
        public int? UltPoliza { get; set; }
        public int? RngIniPol { get; set; }
        public int? RngFinPol { get; set; }
        public int? UltPolEje { get; set; }
        public int? Periodo1 { get; set; }
        public int? Periodo2 { get; set; }
        public int? Periodo3 { get; set; }
        public int? Periodo4 { get; set; }
        public int? Periodo5 { get; set; }
        public int? Periodo6 { get; set; }
        public int? Periodo7 { get; set; }
        public int? Periodo8 { get; set; }
        public int? Periodo9 { get; set; }
        public int? Periodo10 { get; set; }
        public int? Periodo11 { get; set; }
        public int? Periodo12 { get; set; }
        public int? Periodo13 { get; set; }
        public int? Periodo14 { get; set; }
        public string TimeStamp { get; set; }
        public int? IdTipoPolizaSAT { get; set; }
    }
}
