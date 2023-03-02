﻿using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa
{
    public partial class CausacionesIVA
    {
        public int Id { get; set; }
        public int? RowVersion { get; set; }
        public int IdPoliza { get; set; }
        public int Tipo { get; set; }
        public double? TotTasa15 { get; set; }
        public double? BaseTasa15 { get; set; }
        public double? IVATasa15 { get; set; }
        public double? TotTasa10 { get; set; }
        public double? BaseTasa10 { get; set; }
        public double? IVATasa10 { get; set; }
        public double? TotTasa0 { get; set; }
        public double? BaseTasa0 { get; set; }
        public double? TotTasaExento { get; set; }
        public double? BaseTasaExento { get; set; }
        public double? TotOtraTasa { get; set; }
        public double? BaseOtraTasa { get; set; }
        public double? IVAOtraTasa { get; set; }
        public double? ISRRetenido { get; set; }
        public double? TotOtros { get; set; }
        public double? IVARetenido { get; set; }
        public bool? Captado { get; set; }
        public bool? NoCausar { get; set; }
        public string TimeStamp { get; set; }
        public double? IVATasa15NoAcred { get; set; }
        public double? IVATasa10NoAcred { get; set; }
        public double? IETU { get; set; }
        public int? Modificado { get; set; }
        public int? Origen { get; set; }
        public int? IdConceptoIETU { get; set; }
        public double? TotTasa16 { get; set; }
        public double? BaseTasa16 { get; set; }
        public double? IVATasa16 { get; set; }
        public double? IVATasa16NoAcred { get; set; }
        public double? TotTasa11 { get; set; }
        public double? BaseTasa11 { get; set; }
        public double? IVATasa11 { get; set; }
        public double? IVATasa11NoAcred { get; set; }
        public double? IEPS { get; set; }
        public double? TotTasa8 { get; set; }
        public double? BaseTasa8 { get; set; }
        public double? IVATasa8 { get; set; }
        public double? IVATasa8NoAcred { get; set; }
    }
}
