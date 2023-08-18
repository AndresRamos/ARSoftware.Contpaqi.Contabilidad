using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa;

public partial class Cuentas
{
    public int Id { get; set; }

    public int? RowVersion { get; set; }

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string? NomIdioma { get; set; }

    public string? Tipo { get; set; }

    public bool? EsBaja { get; set; }

    public int? CtaMayor { get; set; }

    public bool? CtaEfectivo { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public int? SistOrigen { get; set; }

    public int? IdMoneda { get; set; }

    public int? DigAgrup { get; set; }

    public int? IdSegNeg { get; set; }

    public bool? SegNegMovtos { get; set; }

    public int? Afectable { get; set; }

    public string? TimeStamp { get; set; }

    public int? IdRubro { get; set; }

    public int? Consume { get; set; }

    public int? IdAgrupadorSAT { get; set; }

    public string? ConceptosConsume { get; set; }
}
