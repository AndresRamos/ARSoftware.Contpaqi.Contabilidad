﻿using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa;

public partial class ConceptosIETU
{
    public int Id { get; set; }

    public int? RowVersion { get; set; }

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public int? Tipo { get; set; }

    public int? TipoFlujo { get; set; }

    public string? TimeStamp { get; set; }
}
