using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa;

public partial class Parametros
{
    public int Id { get; set; }

    public int? RowVersion { get; set; }

    public int IdEmpresa { get; set; }

    public string? RepLegal { get; set; }

    public string? RFCRepresentante { get; set; }

    public string? RutaRespaldo { get; set; }

    public string? SalidaDisco { get; set; }

    public string? Direccion { get; set; }

    public string? CodPostal { get; set; }

    public string? ApdoPostal { get; set; }

    public string? Ciudad { get; set; }

    public string? Estado { get; set; }

    public string? Pais { get; set; }

    public string? RFC { get; set; }

    public string? CURP { get; set; }

    public string? RegCamara { get; set; }

    public string? RegEstatal { get; set; }

    public string? EstructCta { get; set; }

    public string? Mascarilla { get; set; }

    public string? CtaFlujo { get; set; }

    public string? DelimExport { get; set; }

    public int? Ejercicios { get; set; }

    public int? EjerActual { get; set; }

    public int? PerActual { get; set; }

    public DateTime? FecIniHist { get; set; }

    public string? ParFunc { get; set; }

    public string? VersionBDD { get; set; }

    public string? TimeStamp { get; set; }

    public string? ModulosIntegrados { get; set; }

    public string? GuidDSL { get; set; }

    public string? GuidEmpresa { get; set; }

    public string? GuidDSLCreado { get; set; }

    public string? ApellPatRep { get; set; }

    public string? ApellMatRep { get; set; }

    public string? RazonSocial { get; set; }

    public string? Telefono { get; set; }

    public string? eMail { get; set; }

    public string? ParFuncCheques { get; set; }

    public DateTime? DiaTrabajo { get; set; }

    public int? DigitosCheque { get; set; }

    public double? MinimoLeyendaAbono { get; set; }

    public string? LeyendaAbono { get; set; }

    public double? PorcentajeIVA { get; set; }

    public double? PorcentajeISR { get; set; }

    public string? RutaAdminPAQ { get; set; }

    public int? ContadorCodigoPersona { get; set; }

    public int? EjercicioVigenteBN { get; set; }

    public int? PeriodoVigenteBN { get; set; }

    public DateTime? FechaInicioHistoriaBN { get; set; }

    public string? EstCliente { get; set; }

    public string? EstProveedor { get; set; }

    public string? Asunto { get; set; }

    public string? Cuerpo { get; set; }

    public string? Firma { get; set; }

    public string? SMTPName { get; set; }

    public string? GuidCertificado { get; set; }

    public string? GuidCertificadoEntrega { get; set; }

    public int? Provider { get; set; }

    public bool? ProgramacionDescargas { get; set; }

    public bool? NotificaVigenciaFiel { get; set; }

    public int? FrecuenciaDescargas { get; set; }

    public int? RegimenFiscal { get; set; }

    public string? TitularCer { get; set; }

    public bool? TasaExentaAutomatica { get; set; }

    public string? PolizaIntuitiva { get; set; }

    public bool? DoctoBancarioAutomatico { get; set; }
}
