﻿using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Generales;

public partial class Paises
{
    public int Id { get; set; }

    public int? RowVersion { get; set; }

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string? TimeStamp { get; set; }
}
