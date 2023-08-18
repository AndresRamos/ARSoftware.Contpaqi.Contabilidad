using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa;

public partial class Polizas
{
    public int Id { get; set; }

    public int? RowVersion { get; set; }

    public int Ejercicio { get; set; }

    public int Periodo { get; set; }

    public int TipoPol { get; set; }

    public int Folio { get; set; }

    public int? Clase { get; set; }

    public bool? Impresa { get; set; }

    public string? Concepto { get; set; }

    public DateTime? Fecha { get; set; }

    public double? Cargos { get; set; }

    public double? Abonos { get; set; }

    public int? IdDiario { get; set; }

    public int? SistOrig { get; set; }

    public bool? Ajuste { get; set; }

    public int IdUsuario { get; set; }

    public bool? ConFlujo { get; set; }

    public bool? ConCuadre { get; set; }

    public string? TimeStamp { get; set; }

    public string? RutaAnexo { get; set; }

    public string? ArchivoAnexo { get; set; }

    public string Guid { get; set; } = null!;

    public bool? tieneDoctoBancario { get; set; }
}
