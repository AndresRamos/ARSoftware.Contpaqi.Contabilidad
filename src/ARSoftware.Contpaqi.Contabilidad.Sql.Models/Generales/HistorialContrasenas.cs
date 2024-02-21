using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Generales;

public partial class HistorialContrasenas
{
    public int Id { get; set; }

    public int? RowVersion { get; set; }

    public string CodigoUsuario { get; set; } = null!;

    public string? Clave { get; set; }

    public DateTime FechaCambio { get; set; }
}
