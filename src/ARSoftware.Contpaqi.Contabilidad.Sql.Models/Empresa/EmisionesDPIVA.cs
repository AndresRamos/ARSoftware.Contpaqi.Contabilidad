using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa;

public partial class EmisionesDPIVA
{
    public int Id { get; set; }

    public int? RowVersion { get; set; }

    public int Ejercicio { get; set; }

    public int TipoPeriodo { get; set; }

    public int Periodo { get; set; }

    public int TipoDeclaracion { get; set; }

    public bool DPIVA { get; set; }

    public string? NoOperacion { get; set; }

    public string? FolioAnt { get; set; }

    public DateTime? FechaPresAnt { get; set; }

    public DateTime? Fecha { get; set; }

    public string Guid { get; set; } = null!;

    public int? EstadoPSRDD { get; set; }

    public int? EstadoDocto { get; set; }

    public int? EstadoSAT { get; set; }

    public string? UsuarioCrea { get; set; }

    public string? GuidAcuse { get; set; }

    public int? MesInicial { get; set; }

    public int? MesFinal { get; set; }

    public int TipoEntrega { get; set; }

    public string? GuidPDF_Acuse { get; set; }

    public bool? Visto { get; set; }
}
