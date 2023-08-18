using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Generales;

public partial class Notificaciones
{
    public int Id { get; set; }

    public int? RowVersion { get; set; }

    public string Llave { get; set; } = null!;

    public string Usuario { get; set; } = null!;

    public int? Tipo { get; set; }

    public string? Mensaje { get; set; }

    public string? MensajeEnIngles { get; set; }

    public int? TipoMensaje { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public DateTime? FechaNotificacion { get; set; }

    public string Empresa { get; set; } = null!;
}
