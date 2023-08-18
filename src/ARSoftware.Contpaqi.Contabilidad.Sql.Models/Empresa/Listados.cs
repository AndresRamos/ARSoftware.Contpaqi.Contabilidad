using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa;

public partial class Listados
{
    public int Id { get; set; }

    public int? RowVersion { get; set; }

    public int Consec { get; set; }

    public int? Modulo { get; set; }

    public string? Titulo { get; set; }

    public int? Usuario { get; set; }

    public int? Alcance { get; set; }

    public string? NombreTabla { get; set; }

    public int? ColumnaOrden { get; set; }

    public bool? Ascendente { get; set; }

    public bool? ConsultaInicial { get; set; }

    public string? DatosXML { get; set; }
}
