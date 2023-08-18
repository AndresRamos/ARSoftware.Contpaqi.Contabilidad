using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa;

public partial class Monedas
{
    public int Id { get; set; }

    public int? RowVersion { get; set; }

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string? Simbolo { get; set; }

    public int? PosicionSimbolo { get; set; }

    public int? Decimales { get; set; }

    public string? NombreSingular { get; set; }

    public string? NombrePlural { get; set; }

    public string? TextoFinal { get; set; }

    public string? TimeStamp { get; set; }

    public string? CodigoSAT { get; set; }
}
