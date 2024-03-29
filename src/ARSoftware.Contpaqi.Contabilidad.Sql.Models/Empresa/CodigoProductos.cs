﻿using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa;

public partial class CodigoProductos
{
    public int Id { get; set; }

    public int? RowVersion { get; set; }

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string RFC { get; set; } = null!;

    public string NoIdentificacion { get; set; } = null!;

    public int? IdTipoOperacion { get; set; }

    public string? SegContCodigoProducto1 { get; set; }

    public string? SegContCodigoProducto2 { get; set; }

    public string? SegContCodigoProducto3 { get; set; }

    public string? SegContCodigoProducto4 { get; set; }

    public string? SegContCodigoProducto5 { get; set; }

    public string? SegContCodigoProducto6 { get; set; }

    public string? SegContCodigoProducto7 { get; set; }

    public int? SistOrig { get; set; }
}
