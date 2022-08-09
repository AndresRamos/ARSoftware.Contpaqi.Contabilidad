﻿using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa
{
    public partial class ComplementosRetencion
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public string TimeStamp { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Version { get; set; }
        public string XMLComplemento { get; set; }
        public bool? EsActivo { get; set; }
    }
}
