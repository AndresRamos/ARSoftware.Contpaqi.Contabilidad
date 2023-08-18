using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Generales;

public partial class ListaEmpresas
{
    public int Id { get; set; }

    public int? RowVersion { get; set; }

    public string Nombre { get; set; } = null!;

    public string RutaDatos { get; set; } = null!;

    public string? RutaResp { get; set; }

    public DateTime? UltimoResp { get; set; }

    public DateTime? UltimaRest { get; set; }

    public string? ArchivoUltimoResp { get; set; }

    public string AliasBDD { get; set; } = null!;

    public string? TimeStamp { get; set; }

    public int? HashSchema { get; set; }

    public string? ModulosIntegrados { get; set; }

    public string? VersionBDD { get; set; }

    public string? IdToken { get; set; }

    public string? AccessToken { get; set; }

    public string? RefreshToken { get; set; }
}
