using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa;

public partial class RubrosNIF
{
    public int Id { get; set; }

    public int? RowVersion { get; set; }

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public int? Nivel { get; set; }

    public string? TimeStamp { get; set; }

    public string? NombreIdioma { get; set; }

    public string? DescripcionNivel { get; set; }

    public string? DescripcionNivelIdioma { get; set; }
}
