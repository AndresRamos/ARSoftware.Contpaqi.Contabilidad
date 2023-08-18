using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa;

public partial class Domicilios
{
    public int Id { get; set; }

    public int? RowVersion { get; set; }

    public int IdReferencia { get; set; }

    public string TablaReferencia { get; set; } = null!;

    public string? Calle { get; set; }

    public string? NoExt { get; set; }

    public string? NoInt { get; set; }

    public string? Colonia { get; set; }

    public string? Localidad { get; set; }

    public string? Municipio { get; set; }

    public string? Estado { get; set; }

    public string? Pais { get; set; }

    public string? CodigoPostal { get; set; }

    public string? Referencia { get; set; }

    public string? Telefono { get; set; }
}
