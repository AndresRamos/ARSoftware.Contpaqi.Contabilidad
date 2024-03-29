﻿using System;
using System.Collections.Generic;
using ARSoftware.Contpaqi.Contabilidad.Sql.Models.Empresa;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Contexts;

public partial class ContpaqiContabilidadEmpresaDbContext : DbContext
{
    public ContpaqiContabilidadEmpresaDbContext(DbContextOptions<ContpaqiContabilidadEmpresaDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ActivosFijos> ActivosFijos { get; set; }

    public virtual DbSet<Afectaciones> Afectaciones { get; set; }

    public virtual DbSet<AfectacionesPresupuestos> AfectacionesPresupuestos { get; set; }

    public virtual DbSet<AfectacionesSaldos> AfectacionesSaldos { get; set; }

    public virtual DbSet<AgrupadoresSAT> AgrupadoresSAT { get; set; }

    public virtual DbSet<Asientos> Asientos { get; set; }

    public virtual DbSet<AsientosContablesCV> AsientosContablesCV { get; set; }

    public virtual DbSet<AsignacionesDigitos> AsignacionesDigitos { get; set; }

    public virtual DbSet<AsocCFDINodosDePago> AsocCFDINodosDePago { get; set; }

    public virtual DbSet<AsocCFDIs> AsocCFDIs { get; set; }

    public virtual DbSet<AsocCargosAbonos> AsocCargosAbonos { get; set; }

    public virtual DbSet<AsocCategorias> AsocCategorias { get; set; }

    public virtual DbSet<AsocCategoriasPlantillas> AsocCategoriasPlantillas { get; set; }

    public virtual DbSet<AsocComprasVentas> AsocComprasVentas { get; set; }

    public virtual DbSet<AsocCuentasGrupos> AsocCuentasGrupos { get; set; }

    public virtual DbSet<AsocDoctoCategorias> AsocDoctoCategorias { get; set; }

    public virtual DbSet<AsocDoctosAdministrativos> AsocDoctosAdministrativos { get; set; }

    public virtual DbSet<AsocMovtsConciliacion> AsocMovtsConciliacion { get; set; }

    public virtual DbSet<Asociaciones> Asociaciones { get; set; }

    public virtual DbSet<Bancos> Bancos { get; set; }

    public virtual DbSet<Categorias> Categorias { get; set; }

    public virtual DbSet<CausacionesIVA> CausacionesIVA { get; set; }

    public virtual DbSet<Cheques> Cheques { get; set; }

    public virtual DbSet<ClavesCV> ClavesCV { get; set; }

    public virtual DbSet<Clientes> Clientes { get; set; }

    public virtual DbSet<CodigoProductos> CodigoProductos { get; set; }

    public virtual DbSet<ComplementosRetencion> ComplementosRetencion { get; set; }

    public virtual DbSet<ComprobantesExtranjeros> ComprobantesExtranjeros { get; set; }

    public virtual DbSet<Conceptos> Conceptos { get; set; }

    public virtual DbSet<ConceptosIETU> ConceptosIETU { get; set; }

    public virtual DbSet<ControlProcesos> ControlProcesos { get; set; }

    public virtual DbSet<Counters> Counters { get; set; }

    public virtual DbSet<Cuentas> Cuentas { get; set; }

    public virtual DbSet<CuentasCheques> CuentasCheques { get; set; }

    public virtual DbSet<CuentasChequesAlias> CuentasChequesAlias { get; set; }

    public virtual DbSet<CuentasDeGastosYRetenciones> CuentasDeGastosYRetenciones { get; set; }

    public virtual DbSet<DatosExtra> DatosExtra { get; set; }

    public virtual DbSet<Depositos> Depositos { get; set; }

    public virtual DbSet<DescargasCFDI> DescargasCFDI { get; set; }

    public virtual DbSet<DevolucionesIVA> DevolucionesIVA { get; set; }

    public virtual DbSet<DiariosEspeciales> DiariosEspeciales { get; set; }

    public virtual DbSet<Digitos> Digitos { get; set; }

    public virtual DbSet<DispersionesPagos> DispersionesPagos { get; set; }

    public virtual DbSet<DocumentosAdministrativos> DocumentosAdministrativos { get; set; }

    public virtual DbSet<DocumentosBancarios> DocumentosBancarios { get; set; }

    public virtual DbSet<DocumentosDe> DocumentosDe { get; set; }

    public virtual DbSet<DocumentosGastos> DocumentosGastos { get; set; }

    public virtual DbSet<Domicilios> Domicilios { get; set; }

    public virtual DbSet<EFOS> EFOS { get; set; }

    public virtual DbSet<EdoCtaBancos> EdoCtaBancos { get; set; }

    public virtual DbSet<EdosCtaContabilidad> EdosCtaContabilidad { get; set; }

    public virtual DbSet<Egresos> Egresos { get; set; }

    public virtual DbSet<Ejercicios> Ejercicios { get; set; }

    public virtual DbSet<EmisionesContabilidadElectronica> EmisionesContabilidadElectronica { get; set; }

    public virtual DbSet<EmisionesDPIVA> EmisionesDPIVA { get; set; }

    public virtual DbSet<EmisionesSAT> EmisionesSAT { get; set; }

    public virtual DbSet<Folios> Folios { get; set; }

    public virtual DbSet<FoliosDigitales> FoliosDigitales { get; set; }

    public virtual DbSet<FoliosUsados> FoliosUsados { get; set; }

    public virtual DbSet<GruposCuentas> GruposCuentas { get; set; }

    public virtual DbSet<GruposEstadisticos> GruposEstadisticos { get; set; }

    public virtual DbSet<ImpuestosRetencion> ImpuestosRetencion { get; set; }

    public virtual DbSet<Ingresos> Ingresos { get; set; }

    public virtual DbSet<IngresosNoDepositados> IngresosNoDepositados { get; set; }

    public virtual DbSet<Listados> Listados { get; set; }

    public virtual DbSet<MantenimientoBDDErrores> MantenimientoBDDErrores { get; set; }

    public virtual DbSet<MantenimientoBDDIndexTmps> MantenimientoBDDIndexTmps { get; set; }

    public virtual DbSet<MantenimientoBDDProcesos> MantenimientoBDDProcesos { get; set; }

    public virtual DbSet<Modulos> Modulos { get; set; }

    public virtual DbSet<ModulosListados> ModulosListados { get; set; }

    public virtual DbSet<Monedas> Monedas { get; set; }

    public virtual DbSet<MovimientosAdministrativos> MovimientosAdministrativos { get; set; }

    public virtual DbSet<MovimientosAsiento> MovimientosAsiento { get; set; }

    public virtual DbSet<MovimientosCFD> MovimientosCFD { get; set; }

    public virtual DbSet<MovimientosPlantillaAsiento> MovimientosPlantillaAsiento { get; set; }

    public virtual DbSet<MovimientosPoliza> MovimientosPoliza { get; set; }

    public virtual DbSet<MovimientosPrepoliza> MovimientosPrepoliza { get; set; }

    public virtual DbSet<MovtosEdoCtaBancos> MovtosEdoCtaBancos { get; set; }

    public virtual DbSet<NombresValoresCV> NombresValoresCV { get; set; }

    public virtual DbSet<PagosProvisionalISR> PagosProvisionalISR { get; set; }

    public virtual DbSet<Parametros> Parametros { get; set; }

    public virtual DbSet<ParametrosInicialesMto> ParametrosInicialesMto { get; set; }

    public virtual DbSet<PeriodosCausacionIVA> PeriodosCausacionIVA { get; set; }

    public virtual DbSet<Personas> Personas { get; set; }

    public virtual DbSet<Plantillas> Plantillas { get; set; }

    public virtual DbSet<PlantillasAsiento> PlantillasAsiento { get; set; }

    public virtual DbSet<PlantillasEstadosCuentas> PlantillasEstadosCuentas { get; set; }

    public virtual DbSet<Polizas> Polizas { get; set; }

    public virtual DbSet<PolizasIntuitivas> PolizasIntuitivas { get; set; }

    public virtual DbSet<PorcentajesPresupuesto> PorcentajesPresupuesto { get; set; }

    public virtual DbSet<Prepolizas> Prepolizas { get; set; }

    public virtual DbSet<Presupuestos> Presupuestos { get; set; }

    public virtual DbSet<PresupuestosCategorias> PresupuestosCategorias { get; set; }

    public virtual DbSet<Productos> Productos { get; set; }

    public virtual DbSet<Proveedores> Proveedores { get; set; }

    public virtual DbSet<Recordatorios> Recordatorios { get; set; }

    public virtual DbSet<RelacionEmpresasNube> RelacionEmpresasNube { get; set; }

    public virtual DbSet<Retenciones> Retenciones { get; set; }

    public virtual DbSet<RubrosNIF> RubrosNIF { get; set; }

    public virtual DbSet<SaldosCategorias> SaldosCategorias { get; set; }

    public virtual DbSet<SaldosCtasCheques> SaldosCtasCheques { get; set; }

    public virtual DbSet<SaldosCuentas> SaldosCuentas { get; set; }

    public virtual DbSet<SaldosSegmentoNegocio> SaldosSegmentoNegocio { get; set; }

    public virtual DbSet<SegmentosNegocio> SegmentosNegocio { get; set; }

    public virtual DbSet<TiposActivos> TiposActivos { get; set; }

    public virtual DbSet<TiposCambio> TiposCambio { get; set; }

    public virtual DbSet<TiposDocumentos> TiposDocumentos { get; set; }

    public virtual DbSet<TiposOperacion> TiposOperacion { get; set; }

    public virtual DbSet<TiposPolizas> TiposPolizas { get; set; }

    public virtual DbSet<TiposPolizasSAT> TiposPolizasSAT { get; set; }

    public virtual DbSet<ValoresAuxiliaresCV> ValoresAuxiliaresCV { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ActivosFijos>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ActivosF__3214EC0776DE368E");

            entity.HasIndex(e => e.Codigo, "Index_1").IsUnique();

            entity.HasIndex(e => e.IdPolizaF, "Index_10");

            entity.HasIndex(e => e.IdSegNegC, "Index_11");

            entity.HasIndex(e => e.IdSegNegF, "Index_12");

            entity.HasIndex(e => e.IdCuenta, "Index_2");

            entity.HasIndex(e => e.IdCtaDeprecC, "Index_3");

            entity.HasIndex(e => e.IdCtaDeprecF, "Index_4");

            entity.HasIndex(e => e.IdCtaGastosC, "Index_5");

            entity.HasIndex(e => e.IdCtaGastosF, "Index_6");

            entity.HasIndex(e => e.IdCtaNoDedC, "Index_7");

            entity.HasIndex(e => e.IdCtaNoDedF, "Index_8");

            entity.HasIndex(e => e.IdPolizaC, "Index_9");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.FecAdqui).HasColumnType("datetime");
            entity.Property(e => e.FecBajaC).HasColumnType("datetime");
            entity.Property(e => e.FecBajaF).HasColumnType("datetime");
            entity.Property(e => e.FecDeprecC).HasColumnType("datetime");
            entity.Property(e => e.FecDeprecF).HasColumnType("datetime");
            entity.Property(e => e.FecIniUsoC).HasColumnType("datetime");
            entity.Property(e => e.FecIniUsoF).HasColumnType("datetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TimeStamp)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<Afectaciones>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Afectaci__3214EC0711A619D9");

            entity.HasIndex(e => e.NumTransac, "Index_1").IsUnique();

            entity.HasIndex(e => e.Estado, "Index_2");

            entity.HasIndex(e => new { e.IdCuenta, e.Estado }, "Index_3");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Fecha).HasColumnType("datetime");
        });

        modelBuilder.Entity<AfectacionesPresupuestos>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Afectaci__3214EC07E892F042");

            entity.HasIndex(e => e.NumTransac, "Index_1").IsUnique();

            entity.HasIndex(e => e.Estado, "Index_2");

            entity.HasIndex(e => new { e.IdCuenta, e.Estado }, "Index_3");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<AfectacionesSaldos>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Afectaci__3214EC0790A70748");

            entity.HasIndex(e => e.NumTransac, "Index_1").IsUnique();

            entity.HasIndex(e => e.Estado, "Index_2");

            entity.HasIndex(e => new { e.IdCuenta, e.Estado }, "Index_3");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.TipoAnt)
                .HasMaxLength(1)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TipoNvo)
                .HasMaxLength(1)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<AgrupadoresSAT>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Agrupado__3214EC07C830E338");

            entity.HasIndex(e => e.Codigo, "Index_1").IsUnique();

            entity.HasIndex(e => e.Nombre, "Index_2");

            entity.HasIndex(e => e.Tipo, "Index_3");

            entity.HasIndex(e => e.IdRubro, "Index_4");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TimeStamp)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<Asientos>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Asientos__3214EC0716592A28");

            entity.HasIndex(e => e.Codigo, "Index_1").IsUnique();

            entity.HasIndex(e => e.Codigo, "Index_2");

            entity.HasIndex(e => e.Nombre, "Index_3");

            entity.HasIndex(e => e.Tipo, "Index_4");

            entity.HasIndex(e => e.TipoXML, "Index_5");

            entity.HasIndex(e => e.IdDiario, "Index_6");

            entity.HasIndex(e => e.IdCtaBancaria, "Index_7");

            entity.HasIndex(e => e.TipoCFDI, "Index_8");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.AsientoDe)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.DescripcionConcepto)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TipoCFDI)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<AsientosContablesCV>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Asientos__3214EC0788CCFABF");

            entity.HasIndex(e => e.Consec, "Index_1").IsUnique();

            entity.HasIndex(e => e.IdClave, "Index_2");

            entity.HasIndex(e => e.IdCuenta, "Index_3");

            entity.HasIndex(e => e.IdDiario, "Index_4");

            entity.HasIndex(e => e.IdSegNeg, "Index_5");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Concepto)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Referencia)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<AsignacionesDigitos>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Asignaci__3214EC07C600E041");

            entity.HasIndex(e => e.IdCuenta, "Index_1").IsUnique();

            entity.HasIndex(e => e.IdDigito1, "Index_2");

            entity.HasIndex(e => e.IdDigito2, "Index_3");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.TimeStamp)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<AsocCFDINodosDePago>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AsocCFDI__3214EC07466097DB");

            entity.HasIndex(e => new { e.UUIDRep, e.NumNodoPago, e.GuidReferencia }, "Index_1").IsUnique();

            entity.HasIndex(e => e.UUIDRep, "Index_2");

            entity.HasIndex(e => e.NumNodoPago, "Index_3");

            entity.HasIndex(e => e.GuidReferencia, "Index_4");

            entity.HasIndex(e => new { e.UUIDRep, e.NumNodoPago }, "Index_5");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.AplicationType)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.GuidReferencia)
                .HasMaxLength(36)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.UUIDRep)
                .HasMaxLength(36)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<AsocCFDIs>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AsocCFDI__3214EC07A4ED6D37");

            entity.HasIndex(e => new { e.UUID, e.GuidRef }, "Index_1").IsUnique();

            entity.HasIndex(e => e.GuidRef, "Index_2");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.AppType)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.GuidRef)
                .HasMaxLength(36)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Referencia)
                .HasMaxLength(1000)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.UUID)
                .HasMaxLength(36)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
        });

        modelBuilder.Entity<AsocCargosAbonos>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AsocCarg__3214EC07D4A21658");

            entity.HasIndex(e => new { e.IdDocumentoDe, e.TipoDocumento, e.IdCuentaCheques, e.Folio, e.CodigoConceptoPago, e.SeriePago, e.FolioPago, e.IdCheque, e.IdEgreso, e.IdIngreso, e.IdIngresoNoDepositado }, "Index_1").IsUnique();

            entity.HasIndex(e => e.Fecha, "Index_2");

            entity.HasIndex(e => new { e.CodigoConceptoPago, e.FolioPago, e.SeriePago }, "Index_3");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ClienteProveedor)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoClienteProveedor)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoConceptoPago)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.ConceptoPago)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaPago).HasColumnType("datetime");
            entity.Property(e => e.Folio)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.FolioPago)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SeriePago)
                .HasMaxLength(15)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<AsocCategorias>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AsocCate__3214EC07DB5F050A");

            entity.HasIndex(e => new { e.IdCategoria, e.IdSubCategoria }, "Index_1").IsUnique();

            entity.HasIndex(e => e.IdCategoria, "Index_2");

            entity.HasIndex(e => e.IdSubCategoria, "Index_3");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<AsocCategoriasPlantillas>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AsocCate__3214EC07FE565559");

            entity.HasIndex(e => new { e.CodigoPlantilla, e.IdCategoria, e.IdSubCategoria }, "Index_1").IsUnique();

            entity.HasIndex(e => e.CodigoPlantilla, "Index_2");

            entity.HasIndex(e => e.IdCategoria, "Index_3");

            entity.HasIndex(e => e.IdSubCategoria, "Index_4");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CodigoPlantilla)
                .HasMaxLength(5)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<AsocComprasVentas>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AsocComp__3214EC07BD5E3272");

            entity.HasIndex(e => new { e.IdDocumentoDe, e.TipoDocumento, e.IdCuentaCheques, e.Folio }, "Index_1").IsUnique();

            entity.HasIndex(e => new { e.CodigoConceptoAdmin, e.FolioAdminPAQ, e.SerieAdminPAQ }, "Index_2");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CodigoConceptoAdmin)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoConceptoPago)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoCteProvAdminPAQ)
                .HasMaxLength(40)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.ConceptoAdmin)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.FechaAdminPAQ)
                .HasMaxLength(23)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Folio)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.FolioAdminPAQ)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SerieAdminPAQ)
                .HasMaxLength(15)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<AsocCuentasGrupos>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AsocCuen__3214EC07A40F9C08");

            entity.HasIndex(e => new { e.IdGrupoCuenta, e.IdCuentaCheque }, "Index_1").IsUnique();

            entity.HasIndex(e => e.IdGrupoCuenta, "Index_2");

            entity.HasIndex(e => e.IdCuentaCheque, "Index_3");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<AsocDoctoCategorias>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AsocDoct__3214EC07BC8186CC");

            entity.HasIndex(e => new { e.IdDocumento, e.IdDocumentoDe, e.IdCategoria, e.IdSubCategoria }, "Index_1").IsUnique();

            entity.HasIndex(e => e.IdDocumento, "Index_2");

            entity.HasIndex(e => e.IdCategoria, "Index_3");

            entity.HasIndex(e => e.IdSubCategoria, "Index_4");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Folio)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<AsocDoctosAdministrativos>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AsocDoct__3214EC077831F2BC");

            entity.HasIndex(e => new { e.UUID, e.GuidPoliza }, "Index_1").IsUnique();

            entity.HasIndex(e => e.UUID, "Index_2");

            entity.HasIndex(e => e.GuidPoliza, "Index_3");

            entity.HasIndex(e => new { e.UUID, e.GuidPoliza }, "Index_4");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.GuidPoliza)
                .HasMaxLength(36)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.UUID)
                .HasMaxLength(36)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<AsocMovtsConciliacion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AsocMovt__3214EC07BBA93BAD");

            entity.HasIndex(e => new { e.IdEdoCuentaContable, e.IdMovtoPoliza, e.IdDocumento }, "Index_1").IsUnique();

            entity.HasIndex(e => e.IdEdoCuentaContable, "Index_2");

            entity.HasIndex(e => e.IdMovtoPoliza, "Index_3");

            entity.HasIndex(e => e.IdDocumento, "Index_4");

            entity.HasIndex(e => e.Id, "Index_Id");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Asociaciones>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Asociaci__3214EC07C5FD7D83");

            entity.HasIndex(e => new { e.IdCtaSup, e.IdSubCtade, e.TipoRel }, "Index_1").IsUnique();

            entity.HasIndex(e => e.IdCtaSup, "Index_2");

            entity.HasIndex(e => e.IdSubCtade, "Index_3");

            entity.HasIndex(e => e.TipoRel, "Index_4");

            entity.HasIndex(e => new { e.CtaSup, e.SubCtade }, "Index_5");

            entity.HasIndex(e => new { e.SubCtade, e.CtaSup }, "Index_6");

            entity.HasIndex(e => new { e.SubCtade, e.TipoRel }, "Index_7");

            entity.HasIndex(e => new { e.CtaSup, e.TipoRel }, "Index_8");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CtaSup)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SubCtade)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TimeStamp)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<Bancos>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Bancos__3214EC07FC1E339F");

            entity.HasIndex(e => e.Codigo, "Index_1").IsUnique();

            entity.HasIndex(e => e.Nombre, "Index_2");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ClaveFiscal)
                .HasMaxLength(5)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Codigo)
                .HasMaxLength(5)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Logotipo)
                .HasMaxLength(254)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Nombre)
                .HasMaxLength(60)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.PaginaWeb)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.RFC)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TimeStamp)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<Categorias>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Categori__3214EC076BA7B6EA");

            entity.HasIndex(e => e.Codigo, "Index_1").IsUnique();

            entity.HasIndex(e => e.Nombre, "Index_2");

            entity.HasIndex(e => e.CodigoMoneda, "Index_3");

            entity.HasIndex(e => e.CodigoCuenta, "Index_4");

            entity.HasIndex(e => e.CodigoCtaComplementaria, "Index_5");

            entity.HasIndex(e => e.CodigoPrepoliza, "Index_6");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Codigo)
                .HasMaxLength(5)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoCtaComplementaria)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoCuenta)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoMoneda)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoPrepoliza)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Nivel)
                .HasMaxLength(1)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Nombre)
                .HasMaxLength(60)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Presupuesto)
                .HasMaxLength(1)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegmentoCuenta)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<CausacionesIVA>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Causacio__3214EC07960D6F1C");

            entity.HasIndex(e => new { e.IdPoliza, e.Tipo }, "Index_1").IsUnique();

            entity.HasIndex(e => e.IdPoliza, "Index_2");

            entity.HasIndex(e => e.Tipo, "Index_3");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.TimeStamp)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<Cheques>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Cheques__3214EC0749B371B6");

            entity.HasIndex(e => new { e.IdDocumentoDe, e.TipoDocumento, e.IdCuentaCheques, e.Folio, e.IdDocumento }, "Index_1").IsUnique();

            entity.HasIndex(e => new { e.EsConciliado, e.Fecha }, "Index_10");

            entity.HasIndex(e => new { e.EjercicioPol, e.PeriodoPol, e.TipoPol, e.NumPol }, "Index_11");

            entity.HasIndex(e => new { e.EjercicioPolOrigen, e.PeriodoPolOrigen, e.TipoPolOrigen, e.NumPolOrigen }, "Index_12");

            entity.HasIndex(e => e.Fecha, "Index_2");

            entity.HasIndex(e => e.Guid, "Index_3");

            entity.HasIndex(e => new { e.IdDocumentoDe, e.Folio }, "Index_4");

            entity.HasIndex(e => new { e.IdCuentaCheques, e.Fecha }, "Index_5");

            entity.HasIndex(e => new { e.IdCuentaCheques, e.EsConciliado, e.Fecha }, "Index_6");

            entity.HasIndex(e => new { e.IdCuentaCheques, e.IdDocumentoDe, e.Folio }, "Index_7");

            entity.HasIndex(e => new { e.IdCuentaCheques, e.IdMovEdoCta, e.FechaAplicacion }, "Index_8");

            entity.HasIndex(e => new { e.CodigoPersona, e.IdDocumentoDe, e.Fecha }, "Index_9");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.BeneficiarioPagador)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoMoneda)
                .HasMaxLength(5)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoMonedaTipoCambio)
                .HasMaxLength(5)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoPersona)
                .HasMaxLength(40)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Concepto)
                .HasMaxLength(1000)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CuentaDestino)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaAplicacion).HasColumnType("datetime");
            entity.Property(e => e.Folio)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Guid)
                .HasMaxLength(36)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.NumAsoc).HasDefaultValue(0);
            entity.Property(e => e.OtroMetodoDePago)
                .HasMaxLength(2)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Prioridad)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Referencia)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.UUIDRep)
                .HasMaxLength(36)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.UsuAutoriza)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.UsuAutorizaPresupuesto)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<ClavesCV>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ClavesCV__3214EC075E5E2FA8");

            entity.HasIndex(e => new { e.TipoClave, e.Consec }, "Index_1").IsUnique();

            entity.HasIndex(e => e.Clave, "Index_2");

            entity.HasIndex(e => e.TipoClave, "Index_3");

            entity.HasIndex(e => e.IdCuenta, "Index_4");

            entity.HasIndex(e => new { e.TipoClave, e.Clave }, "Index_5");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Clave)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<Clientes>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Clientes__3214EC0791B005CA");

            entity.HasIndex(e => e.Codigo, "Index_1").IsUnique();

            entity.HasIndex(e => e.SegContCliente5, "Index_10");

            entity.HasIndex(e => e.SegContCliente6, "Index_11");

            entity.HasIndex(e => e.SegContCliente7, "Index_12");

            entity.HasIndex(e => e.CodigoCuenta, "Index_2");

            entity.HasIndex(e => e.CodigoCtaComplementaria, "Index_3");

            entity.HasIndex(e => e.CodigoPrepoliza, "Index_4");

            entity.HasIndex(e => e.CodigoPersona, "Index_5");

            entity.HasIndex(e => e.SegContCliente1, "Index_6");

            entity.HasIndex(e => e.SegContCliente2, "Index_7");

            entity.HasIndex(e => e.SegContCliente3, "Index_8");

            entity.HasIndex(e => e.SegContCliente4, "Index_9");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.BancoOrigen)
                .HasMaxLength(10)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.BancoOrigenId).HasDefaultValue(0);
            entity.Property(e => e.Codigo)
                .HasMaxLength(40)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoAsiento).HasMaxLength(20);
            entity.Property(e => e.CodigoCtaComplementaria)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoCuenta)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoPersona)
                .HasMaxLength(40)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoPrepoliza)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CuentaOrigen)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Diario).HasDefaultValue(0);
            entity.Property(e => e.SegContCliente1)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegContCliente2)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegContCliente3)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegContCliente4)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegContCliente5)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegContCliente6)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegContCliente7)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<CodigoProductos>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CodigoPr__3214EC074BE8F79F");

            entity.HasIndex(e => new { e.NoIdentificacion, e.RFC }, "Index_1").IsUnique();

            entity.HasIndex(e => e.SegContCodigoProducto5, "Index_10");

            entity.HasIndex(e => e.SegContCodigoProducto6, "Index_11");

            entity.HasIndex(e => e.SegContCodigoProducto7, "Index_12");

            entity.HasIndex(e => new { e.NoIdentificacion, e.RFC }, "Index_13");

            entity.HasIndex(e => e.NoIdentificacion, "Index_2");

            entity.HasIndex(e => e.RFC, "Index_3");

            entity.HasIndex(e => e.Codigo, "Index_4");

            entity.HasIndex(e => e.IdTipoOperacion, "Index_5");

            entity.HasIndex(e => e.SegContCodigoProducto1, "Index_6");

            entity.HasIndex(e => e.SegContCodigoProducto2, "Index_7");

            entity.HasIndex(e => e.SegContCodigoProducto3, "Index_8");

            entity.HasIndex(e => e.SegContCodigoProducto4, "Index_9");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.NoIdentificacion)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Nombre)
                .HasMaxLength(1000)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.RFC)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegContCodigoProducto1)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegContCodigoProducto2)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegContCodigoProducto3)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegContCodigoProducto4)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegContCodigoProducto5)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegContCodigoProducto6)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegContCodigoProducto7)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<ComplementosRetencion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Compleme__3214EC078909381D");

            entity.HasIndex(e => new { e.Codigo, e.Version }, "Index_1").IsUnique();

            entity.HasIndex(e => e.Nombre, "Index_2");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Codigo)
                .HasMaxLength(2)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TimeStamp)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Version)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.XMLComplemento)
                .UseCollation("SQL_Latin1_General_CP437_BIN")
                .HasColumnType("ntext");
        });

        modelBuilder.Entity<ComprobantesExtranjeros>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Comproba__3214EC070D924D7B");

            entity.HasIndex(e => new { e.Fecha, e.NumeroDeFactura }, "Index_1").IsUnique();

            entity.HasIndex(e => e.Fecha, "Index_2");

            entity.HasIndex(e => e.Guid, "Index_3");

            entity.HasIndex(e => e.NumeroDeFactura, "Index_4");

            entity.HasIndex(e => e.MetodoDePago, "Index_5");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Guid)
                .HasMaxLength(36)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.MetodoDePago)
                .HasMaxLength(2)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.NumeroDeFactura)
                .HasMaxLength(36)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TaxID)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TimeStamp)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<Conceptos>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Concepto__3214EC07EA2F573A");

            entity.HasIndex(e => e.Codigo, "Index_1").IsUnique();

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TimeStamp)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<ConceptosIETU>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Concepto__3214EC07C912762A");

            entity.HasIndex(e => e.Codigo, "Index_1").IsUnique();

            entity.HasIndex(e => e.Tipo, "Index_2");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TimeStamp)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<ControlProcesos>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ControlP__3214EC07932A94DC");

            entity.HasIndex(e => e.GuidControl, "Index_1").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.EstatusProceso)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaFinal).HasColumnType("datetime");
            entity.Property(e => e.FechaInicial).HasColumnType("datetime");
            entity.Property(e => e.GuidControl)
                .HasMaxLength(36)
                .IsUnicode(false);
            entity.Property(e => e.NombreLog)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProcesoDescripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Counters>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Counters__3214EC07C18AF76C");

            entity.HasIndex(e => e.Name, "Index_1").IsUnique();

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .HasMaxLength(256)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<Cuentas>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Cuentas__3214EC078AA60F5E");

            entity.HasIndex(e => e.Codigo, "Index_1").IsUnique();

            entity.HasIndex(e => e.IdSegNeg, "Index_2");

            entity.HasIndex(e => e.Tipo, "Index_3");

            entity.HasIndex(e => e.IdMoneda, "Index_4");

            entity.HasIndex(e => e.IdAgrupadorSAT, "Index_5");

            entity.HasIndex(e => new { e.Codigo, e.Nombre }, "Index_6");

            entity.HasIndex(e => new { e.Codigo, e.IdRubro }, "Index_7");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Codigo)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.ConceptosConsume)
                .HasMaxLength(1000)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.NomIdioma)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TimeStamp)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<CuentasCheques>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CuentasC__3214EC0749DFEBB0");

            entity.HasIndex(e => e.Codigo, "Index_1").IsUnique();

            entity.HasIndex(e => e.SegContCuentaCheque4, "Index_10");

            entity.HasIndex(e => e.SegContCuentaCheque5, "Index_11");

            entity.HasIndex(e => e.SegContCuentaCheque6, "Index_12");

            entity.HasIndex(e => e.SegContCuentaCheque7, "Index_13");

            entity.HasIndex(e => e.Nombre, "Index_2");

            entity.HasIndex(e => e.CodigoMoneda, "Index_3");

            entity.HasIndex(e => e.CodigoCuenta, "Index_4");

            entity.HasIndex(e => e.CodigoCtaComplementaria, "Index_5");

            entity.HasIndex(e => e.IdSegNeg, "Index_6");

            entity.HasIndex(e => e.SegContCuentaCheque1, "Index_7");

            entity.HasIndex(e => e.SegContCuentaCheque2, "Index_8");

            entity.HasIndex(e => e.SegContCuentaCheque3, "Index_9");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Codigo)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoConceptoComercialCheque)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoConceptoComercialEgreso)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoConceptoComercialIngreso)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoConceptoComercialIngresoCFD)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoConceptoComercialIngresoND)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoConceptoComercialIngresoNDCFD)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoCtaComplementaria)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoCuenta)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoMoneda)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Direccion)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Ejecutivo)
                .HasMaxLength(60)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.EsBaja).HasDefaultValue(false);
            entity.Property(e => e.Fax)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.FechaSaldoInicial).HasColumnType("datetime");
            entity.Property(e => e.FechaUltConciliacion).HasColumnType("datetime");
            entity.Property(e => e.FolioActual)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.FolioFinal)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.FolioInicial)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.FormatoAbono)
                .HasMaxLength(254)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.FormatoCargo)
                .HasMaxLength(254)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.FormatoCheque)
                .HasMaxLength(254)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.FormatoDeposito)
                .HasMaxLength(254)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.FormatoIngreso)
                .HasMaxLength(254)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Nombre)
                .HasMaxLength(60)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.NumSucursal)
                .HasMaxLength(5)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegContCuentaCheque1)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegContCuentaCheque2)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegContCuentaCheque3)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegContCuentaCheque4)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegContCuentaCheque5)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegContCuentaCheque6)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegContCuentaCheque7)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Sucursal)
                .HasMaxLength(60)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TDCheque)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.TDDeposito)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.TDEgreso)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.TDIngreso)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.TDIngresoND)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Titular1)
                .HasMaxLength(60)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Titular2)
                .HasMaxLength(60)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Titular3)
                .HasMaxLength(60)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.UsarRefIngEgConciliacion).HasDefaultValue(false);
        });

        modelBuilder.Entity<CuentasChequesAlias>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CuentasC__3214EC07034642E7");

            entity.HasIndex(e => e.NumeroCuenta, "Index_1").IsUnique();

            entity.HasIndex(e => new { e.NumeroCuenta, e.TipoCuenta, e.IdCuentaCheques }, "Index_2");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(60)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.NumeroCuenta)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<CuentasDeGastosYRetenciones>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CuentasD__3214EC074752099A");

            entity.HasIndex(e => new { e.NombreImpuesto, e.IdCuentaContable }, "Index_1").IsUnique();

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.NombreImpuesto)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<DatosExtra>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DatosExt__3214EC07DE4EC019");

            entity.HasIndex(e => e.Codigo, "Index_1").IsUnique();

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Codigo)
                .HasMaxLength(5)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.FechaExtra1).HasColumnType("datetime");
            entity.Property(e => e.TextoExtra1)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TextoExtra2)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TextoExtra3)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TextoExtra4)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<Depositos>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Deposito__3214EC07BB8DD20C");

            entity.HasIndex(e => new { e.IdDocumentoDe, e.TipoDocumento, e.IdCuentaCheques, e.Folio }, "Index_1").IsUnique();

            entity.HasIndex(e => new { e.EjercicioPol, e.PeriodoPol, e.TipoPol, e.NumPol }, "Index_10");

            entity.HasIndex(e => e.Fecha, "Index_2");

            entity.HasIndex(e => e.Guid, "Index_3");

            entity.HasIndex(e => new { e.IdDocumentoDe, e.Folio }, "Index_4");

            entity.HasIndex(e => new { e.IdCuentaCheques, e.Fecha }, "Index_5");

            entity.HasIndex(e => new { e.IdCuentaCheques, e.EsConciliado, e.Fecha }, "Index_6");

            entity.HasIndex(e => new { e.IdCuentaCheques, e.IdDocumentoDe, e.Folio }, "Index_7");

            entity.HasIndex(e => new { e.IdCuentaCheques, e.IdMovEdoCta, e.FechaAplicacion }, "Index_8");

            entity.HasIndex(e => new { e.EsConciliado, e.Fecha }, "Index_9");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Concepto)
                .HasMaxLength(1000)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaAplicacion).HasColumnType("datetime");
            entity.Property(e => e.Folio)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.FormaDeposito)
                .HasMaxLength(1)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Guid)
                .HasMaxLength(36)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Referencia)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<DescargasCFDI>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Descarga__3214EC0714AA3DE5");

            entity.HasIndex(e => e.Guid, "Index_1").IsUnique();

            entity.HasIndex(e => e.Guid, "Index_2");

            entity.HasIndex(e => e.RequestId, "Index_3");

            entity.HasIndex(e => e.GuidProcessADD, "Index_4");

            entity.HasIndex(e => e.FechaSolicitud, "Index_5");

            entity.HasIndex(e => e.FechaUsuarioNotificado, "Index_6");

            entity.HasIndex(e => e.UsuarioNotificado, "Index_7");

            entity.HasIndex(e => e.TipoNotificacion, "Index_8");

            entity.HasIndex(e => new { e.Guid, e.TipoNotificacion }, "Index_9");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.EstadoComprobante).HasMaxLength(100);
            entity.Property(e => e.Estatus).HasMaxLength(100);
            entity.Property(e => e.FechaFinalRango).HasColumnType("datetime");
            entity.Property(e => e.FechaInicialRango).HasColumnType("datetime");
            entity.Property(e => e.FechaSolicitud).HasColumnType("datetime");
            entity.Property(e => e.FechaUsuarioNotificado).HasColumnType("datetime");
            entity.Property(e => e.Guid).HasMaxLength(36);
            entity.Property(e => e.GuidProcessADD).HasMaxLength(36);
            entity.Property(e => e.Mensaje).HasMaxLength(1000);
            entity.Property(e => e.RFCFiltro).HasMaxLength(20);
            entity.Property(e => e.RequestId).HasMaxLength(36);
            entity.Property(e => e.TipoComprobante).HasMaxLength(100);
        });

        modelBuilder.Entity<DevolucionesIVA>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Devoluci__3214EC07DB26A771");

            entity.HasIndex(e => new { e.IdPoliza, e.NumDev }, "Index_1").IsUnique();

            entity.HasIndex(e => e.IdPoliza, "Index_2");

            entity.HasIndex(e => e.IdProveedor, "Index_3");

            entity.HasIndex(e => e.IdConceptoIETU, "Index_4");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Referencia)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Serie)
                .HasMaxLength(15)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TimeStamp)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.UUID)
                .HasMaxLength(36)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<DiariosEspeciales>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DiariosE__3214EC07EA89063F");

            entity.HasIndex(e => e.Codigo, "Index_1").IsUnique();

            entity.HasIndex(e => e.Tipo, "Index_2");

            entity.HasIndex(e => e.IdRubro, "Index_3");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TimeStamp)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<Digitos>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Digitos__3214EC07C48D7013");

            entity.HasIndex(e => e.Codigo, "Index_1").IsUnique();

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Naturaleza)
                .HasMaxLength(1)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TimeStamp)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TipoCtas)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<DispersionesPagos>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Dispersi__3214EC07CC09958F");

            entity.HasIndex(e => new { e.UUID, e.UUIDRep, e.GuidRef }, "Index_1").IsUnique();

            entity.HasIndex(e => e.GuidRef, "Index_2");

            entity.HasIndex(e => e.UUID, "Index_3");

            entity.HasIndex(e => e.FechaPago, "Index_4");

            entity.HasIndex(e => e.UUIDRep, "Index_5");

            entity.HasIndex(e => new { e.UUID, e.UUIDRep, e.NumNodoPago }, "Index_6");

            entity.HasIndex(e => new { e.UUID, e.GuidRef }, "Index_7");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.FechaPago).HasColumnType("datetime");
            entity.Property(e => e.GuidRef).HasMaxLength(36);
            entity.Property(e => e.UUID)
                .HasMaxLength(36)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.UUIDRep)
                .HasMaxLength(36)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
        });

        modelBuilder.Entity<DocumentosAdministrativos>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Document__3214EC077F315C7B");

            entity.HasIndex(e => e.UUID, "Index_1").IsUnique();

            entity.HasIndex(e => e.CodigoPersona, "Index_2");

            entity.HasIndex(e => e.CodigoAsiento, "Index_3");

            entity.HasIndex(e => e.CodigoTipoOperacion, "Index_4");

            entity.HasIndex(e => e.CodigoResponsableGasto, "Index_5");

            entity.HasIndex(e => e.CodigoSegmentoNegocio, "Index_6");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CodigoAsiento)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoPersona)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoResponsableGasto)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoSegmentoNegocio)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoTipoOperacion)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.UUID)
                .HasMaxLength(36)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
        });

        modelBuilder.Entity<DocumentosBancarios>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Document__3214EC074F529BAD");

            entity.HasIndex(e => new { e.IdCheque, e.IdEgreso, e.IdIngreso, e.IdIngresoNoDepositado, e.IdDeposito, e.IdCuentaCheques }, "Index_1").IsUnique();

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaAplicacion).HasColumnType("datetime");
        });

        modelBuilder.Entity<DocumentosDe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Document__3214EC076C03A20B");

            entity.HasIndex(e => e.Codigo, "Index_1").IsUnique();

            entity.HasIndex(e => e.AsocTabla, "Index_2");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Codigo)
                .HasMaxLength(5)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<DocumentosGastos>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Document__3214EC078ED7E605");

            entity.HasIndex(e => e.Folio, "Index_1").IsUnique();

            entity.HasIndex(e => e.Guid, "Index_2");

            entity.HasIndex(e => e.SistOrig, "Index_3");

            entity.HasIndex(e => e.Ejercicio, "Index_4");

            entity.HasIndex(e => e.Periodo, "Index_5");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CodigoPersona)
                .HasMaxLength(40)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Concepto)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.FechaApertura).HasColumnType("datetime");
            entity.Property(e => e.FechaCierre).HasColumnType("datetime");
            entity.Property(e => e.Folio)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.FolioDocumentoBancario)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Guid)
                .HasMaxLength(36)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Propina).HasDefaultValue(0.0);
            entity.Property(e => e.Referencia)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TipoDocumentoBancario)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TipoOperacion)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<Domicilios>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Domicili__3214EC0734C6A1F5");

            entity.HasIndex(e => new { e.IdReferencia, e.TablaReferencia }, "Index_1").IsUnique();

            entity.HasIndex(e => e.CodigoPostal, "Index_2");

            entity.HasIndex(e => e.Calle, "Index_3");

            entity.HasIndex(e => e.Estado, "Index_4");

            entity.HasIndex(e => e.Municipio, "Index_5");

            entity.HasIndex(e => e.Colonia, "Index_6");

            entity.HasIndex(e => new { e.Pais, e.Estado, e.Municipio, e.Colonia, e.Calle, e.NoExt }, "Index_7");

            entity.HasIndex(e => new { e.Colonia, e.Calle, e.NoExt }, "Index_8");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Calle)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(10)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Colonia)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Estado)
                .HasMaxLength(2)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Localidad)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Municipio)
                .HasMaxLength(5)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.NoExt)
                .HasMaxLength(55)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.NoInt)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Pais)
                .HasMaxLength(3)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Referencia)
                .HasMaxLength(1000)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TablaReferencia)
                .HasMaxLength(1000)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<EFOS>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EFOS__3214EC077B89EEF0");

            entity.HasIndex(e => e.RFC, "Index_1").IsUnique();

            entity.HasIndex(e => e.Situacion, "Index_2");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Nombre).HasMaxLength(200);
            entity.Property(e => e.RFC).HasMaxLength(50);
            entity.Property(e => e.Situacion).HasMaxLength(50);
        });

        modelBuilder.Entity<EdoCtaBancos>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EdoCtaBa__3214EC0725290EAB");

            entity.HasIndex(e => new { e.Numero, e.IdCuentaCheques }, "Index_1").IsUnique();

            entity.HasIndex(e => new { e.IdCuentaCheques, e.EstadoConciliacion, e.FechaFinal }, "Index_2");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaFinal).HasColumnType("datetime");
            entity.Property(e => e.FechaInicial).HasColumnType("datetime");
            entity.Property(e => e.TimeStamp)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<EdosCtaContabilidad>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EdosCtaC__3214EC07E3C7A660");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaFinal).HasColumnType("datetime");
            entity.Property(e => e.FechaInicial).HasColumnType("datetime");
            entity.Property(e => e.TimeStamp).HasMaxLength(20);
        });

        modelBuilder.Entity<Egresos>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Egresos__3214EC074DC51045");

            entity.HasIndex(e => new { e.IdDocumentoDe, e.TipoDocumento, e.IdCuentaCheques, e.Folio }, "Index_1").IsUnique();

            entity.HasIndex(e => new { e.EsConciliado, e.Fecha }, "Index_10");

            entity.HasIndex(e => new { e.EjercicioPol, e.PeriodoPol, e.TipoPol, e.NumPol }, "Index_11");

            entity.HasIndex(e => new { e.EjercicioPolOrigen, e.PeriodoPolOrigen, e.TipoPolOrigen, e.NumPolOrigen }, "Index_12");

            entity.HasIndex(e => e.Fecha, "Index_2");

            entity.HasIndex(e => e.Guid, "Index_3");

            entity.HasIndex(e => new { e.IdDocumentoDe, e.Folio }, "Index_4");

            entity.HasIndex(e => new { e.IdCuentaCheques, e.Fecha }, "Index_5");

            entity.HasIndex(e => new { e.IdCuentaCheques, e.EsConciliado, e.Fecha }, "Index_6");

            entity.HasIndex(e => new { e.IdCuentaCheques, e.IdDocumentoDe, e.Folio }, "Index_7");

            entity.HasIndex(e => new { e.IdCuentaCheques, e.IdMovEdoCta, e.FechaAplicacion }, "Index_8");

            entity.HasIndex(e => new { e.CodigoPersona, e.IdDocumentoDe, e.Fecha }, "Index_9");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.BeneficiarioPagador)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoMoneda)
                .HasMaxLength(5)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoMonedaTipoCambio)
                .HasMaxLength(5)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoPersona)
                .HasMaxLength(40)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Concepto)
                .HasMaxLength(1000)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CuentaDestino)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaAplicacion).HasColumnType("datetime");
            entity.Property(e => e.Folio)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Guid)
                .HasMaxLength(36)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.NumAsoc).HasDefaultValue(0);
            entity.Property(e => e.OtroMetodoDePago)
                .HasMaxLength(2)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Referencia)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.UUIDRep)
                .HasMaxLength(36)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.UsuAutorizaPresupuesto)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<Ejercicios>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Ejercici__3214EC07B8A902F3");

            entity.HasIndex(e => e.Ejercicio, "Index_1").IsUnique();

            entity.HasIndex(e => e.IdCtaCierre, "Index_2");

            entity.HasIndex(e => e.IdPolCierre, "Index_3");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.FecFinEje).HasColumnType("datetime");
            entity.Property(e => e.FecIniEje).HasColumnType("datetime");
            entity.Property(e => e.FecIniPer1).HasColumnType("datetime");
            entity.Property(e => e.FecIniPer10).HasColumnType("datetime");
            entity.Property(e => e.FecIniPer11).HasColumnType("datetime");
            entity.Property(e => e.FecIniPer12).HasColumnType("datetime");
            entity.Property(e => e.FecIniPer13).HasColumnType("datetime");
            entity.Property(e => e.FecIniPer14).HasColumnType("datetime");
            entity.Property(e => e.FecIniPer2).HasColumnType("datetime");
            entity.Property(e => e.FecIniPer3).HasColumnType("datetime");
            entity.Property(e => e.FecIniPer4).HasColumnType("datetime");
            entity.Property(e => e.FecIniPer5).HasColumnType("datetime");
            entity.Property(e => e.FecIniPer6).HasColumnType("datetime");
            entity.Property(e => e.FecIniPer7).HasColumnType("datetime");
            entity.Property(e => e.FecIniPer8).HasColumnType("datetime");
            entity.Property(e => e.FecIniPer9).HasColumnType("datetime");
            entity.Property(e => e.TimeStamp)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<EmisionesContabilidadElectronica>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Emisione__3214EC07D9A182B7");

            entity.HasIndex(e => e.Guid, "Index_1").IsUnique();

            entity.HasIndex(e => e.FechaModBal, "Index_10");

            entity.HasIndex(e => e.TipoEntrega, "Index_11");

            entity.HasIndex(e => new { e.Anio, e.Mes, e.TipoArchivo, e.TipoSolicitud }, "Index_12");

            entity.HasIndex(e => e.Guid, "Index_2");

            entity.HasIndex(e => e.GuidAcuse, "Index_3");

            entity.HasIndex(e => e.EstadoDocto, "Index_4");

            entity.HasIndex(e => e.EstadoPSRDD, "Index_5");

            entity.HasIndex(e => e.NumOrden, "Index_6");

            entity.HasIndex(e => e.NumTramite, "Index_7");

            entity.HasIndex(e => e.Folio, "Index_8");

            entity.HasIndex(e => e.Fecha, "Index_9");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaModBal).HasColumnType("datetime");
            entity.Property(e => e.Folio)
                .HasMaxLength(22)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Guid)
                .HasMaxLength(36)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.GuidAcuse)
                .HasMaxLength(36)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.NumOrden)
                .HasMaxLength(13)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.NumTramite)
                .HasMaxLength(10)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TipoSolicitud)
                .HasMaxLength(2)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<EmisionesDPIVA>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Emisione__3214EC07D9A39CDF");

            entity.HasIndex(e => e.Guid, "Index_1").IsUnique();

            entity.HasIndex(e => e.EstadoDocto, "Index_10");

            entity.HasIndex(e => e.EstadoPSRDD, "Index_11");

            entity.HasIndex(e => new { e.Ejercicio, e.Periodo, e.TipoDeclaracion, e.MesInicial, e.MesFinal }, "Index_12");

            entity.HasIndex(e => new { e.Ejercicio, e.Periodo, e.TipoEntrega, e.MesInicial, e.MesFinal }, "Index_13");

            entity.HasIndex(e => e.Periodo, "Index_2");

            entity.HasIndex(e => e.TipoDeclaracion, "Index_3");

            entity.HasIndex(e => e.DPIVA, "Index_4");

            entity.HasIndex(e => e.UsuarioCrea, "Index_5");

            entity.HasIndex(e => e.Fecha, "Index_6");

            entity.HasIndex(e => e.FechaPresAnt, "Index_7");

            entity.HasIndex(e => e.GuidAcuse, "Index_8");

            entity.HasIndex(e => e.NoOperacion, "Index_9");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaPresAnt).HasColumnType("datetime");
            entity.Property(e => e.FolioAnt)
                .HasMaxLength(16)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Guid)
                .HasMaxLength(36)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.GuidAcuse)
                .HasMaxLength(36)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.GuidPDF_Acuse)
                .HasMaxLength(36)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.NoOperacion)
                .HasMaxLength(16)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<EmisionesSAT>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Emisione__3214EC071797F36C");

            entity.HasIndex(e => new { e.Ano, e.Mes }, "Index_1").IsUnique();

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Guid)
                .HasMaxLength(36)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<Folios>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Folios__3214EC074245F29D");

            entity.HasIndex(e => e.Codigo, "Index_1").IsUnique();

            entity.HasIndex(e => e.NoAprobacion, "Index_2");

            entity.HasIndex(e => new { e.IdDocumentoDe, e.TipoGeneracion }, "Index_3");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Codigo)
                .HasMaxLength(5)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.FolioActual)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.FolioFinal)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.FolioInicial)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Serie)
                .HasMaxLength(15)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<FoliosDigitales>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FoliosDi__3214EC0717919F51");

            entity.HasIndex(e => e.Codigo, "Index_1").IsUnique();

            entity.HasIndex(e => new { e.NoAprobacion, e.AnioAprobacion }, "Index_2");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Codigo)
                .HasMaxLength(5)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoTipoDocumento)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.FolioActual)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.FolioFinal)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.FolioInicial)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Nombre)
                .HasMaxLength(60)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Serie)
                .HasMaxLength(15)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<FoliosUsados>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FoliosUs__3214EC077351BBF3");

            entity.HasIndex(e => new { e.Codigo, e.Serie, e.Folio }, "Index_1").IsUnique();

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Codigo)
                .HasMaxLength(5)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Folio)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Serie)
                .HasMaxLength(15)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<GruposCuentas>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__GruposCu__3214EC07720994CD");

            entity.HasIndex(e => e.Codigo, "Index_1").IsUnique();

            entity.HasIndex(e => e.Nombre, "Index_2");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Codigo)
                .HasMaxLength(5)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Nombre)
                .HasMaxLength(60)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<GruposEstadisticos>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__GruposEs__3214EC076F5D28EA");

            entity.HasIndex(e => e.Codigo, "Index_1").IsUnique();

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CuentaAl)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CuentaDel)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Patron)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TimeStamp)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<ImpuestosRetencion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Impuesto__3214EC070E4546CC");

            entity.HasIndex(e => e.Guid, "Index_1").IsUnique();

            entity.HasIndex(e => e.IdRetencion, "Index_2");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Guid)
                .HasMaxLength(36)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Impuesto)
                .HasMaxLength(2)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TimeStamp)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<Ingresos>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Ingresos__3214EC0720734C39");

            entity.HasIndex(e => new { e.IdDocumentoDe, e.TipoDocumento, e.IdCuentaCheques, e.Folio }, "Index_1").IsUnique();

            entity.HasIndex(e => new { e.EsConciliado, e.Fecha }, "Index_10");

            entity.HasIndex(e => new { e.EjercicioPol, e.PeriodoPol, e.TipoPol, e.NumPol }, "Index_11");

            entity.HasIndex(e => e.Fecha, "Index_2");

            entity.HasIndex(e => e.Guid, "Index_3");

            entity.HasIndex(e => new { e.IdDocumentoDe, e.Folio }, "Index_4");

            entity.HasIndex(e => new { e.IdCuentaCheques, e.Fecha }, "Index_5");

            entity.HasIndex(e => new { e.IdCuentaCheques, e.EsConciliado, e.Fecha }, "Index_6");

            entity.HasIndex(e => new { e.IdCuentaCheques, e.IdDocumentoDe, e.Folio }, "Index_7");

            entity.HasIndex(e => new { e.IdCuentaCheques, e.IdMovEdoCta, e.FechaAplicacion }, "Index_8");

            entity.HasIndex(e => new { e.CodigoPersona, e.IdDocumentoDe, e.Fecha }, "Index_9");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.BeneficiarioPagador)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoMoneda)
                .HasMaxLength(5)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoMonedaTipoCambio)
                .HasMaxLength(5)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoPersona)
                .HasMaxLength(40)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Concepto)
                .HasMaxLength(1000)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CuentaOrigen)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaAplicacion).HasColumnType("datetime");
            entity.Property(e => e.Folio)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Guid)
                .HasMaxLength(36)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.NumAsoc).HasDefaultValue(0);
            entity.Property(e => e.NumeroCheque)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.OtroMetodoDePago)
                .HasMaxLength(2)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Referencia)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.UUIDRep)
                .HasMaxLength(36)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.UsuAutorizaPresupuesto)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<IngresosNoDepositados>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Ingresos__3214EC0711AE55A3");

            entity.HasIndex(e => new { e.IdDocumentoDe, e.TipoDocumento, e.Folio }, "Index_1").IsUnique();

            entity.HasIndex(e => e.Fecha, "Index_2");

            entity.HasIndex(e => e.IdDeposito, "Index_3");

            entity.HasIndex(e => e.Guid, "Index_4");

            entity.HasIndex(e => new { e.IdDocumentoDe, e.Folio }, "Index_5");

            entity.HasIndex(e => new { e.CodigoPersona, e.IdDocumentoDe, e.Fecha }, "Index_6");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.BeneficiarioPagador)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoMoneda)
                .HasMaxLength(5)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoMonedaTipoCambio)
                .HasMaxLength(5)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoPersona)
                .HasMaxLength(40)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Concepto)
                .HasMaxLength(1000)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CuentaOrigen)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaAplicacion).HasColumnType("datetime");
            entity.Property(e => e.Folio)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Guid)
                .HasMaxLength(36)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.NumAsoc).HasDefaultValue(0);
            entity.Property(e => e.NumeroCheque)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.OtroMetodoDePago)
                .HasMaxLength(2)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Referencia)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.UsuAutorizaPresupuesto)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<Listados>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Listados__3214EC07015D02BE");

            entity.HasIndex(e => e.Consec, "Index_1").IsUnique();

            entity.HasIndex(e => e.Modulo, "Index_2");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.DatosXML)
                .UseCollation("SQL_Latin1_General_CP437_BIN")
                .HasColumnType("ntext");
            entity.Property(e => e.NombreTabla)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Titulo)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<MantenimientoBDDErrores>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Mantenim__3214EC072C2D4E5D");

            entity.HasIndex(e => new { e.GuidProceso, e.NumError }, "Index_1").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.DescripcionError)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GuidProceso)
                .HasMaxLength(36)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MantenimientoBDDIndexTmps>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Mantenim__3214EC0798FD616C");

            entity.HasIndex(e => new { e.NombreTabla, e.NombreIndex }, "Index_1").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.NombreIndex)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreTabla)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MantenimientoBDDProcesos>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Mantenim__3214EC07E79A384C");

            entity.HasIndex(e => e.GuidProceso, "Index_1").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.FechaFinal).HasColumnType("datetime");
            entity.Property(e => e.FechaInicial).HasColumnType("datetime");
            entity.Property(e => e.GuidProceso)
                .HasMaxLength(36)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Modulos>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Modulos__3214EC07C7BDE5B3");

            entity.HasIndex(e => e.Codigo, "Index_1").IsUnique();

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Codigo)
                .HasMaxLength(5)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(60)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<ModulosListados>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ModulosL__3214EC077866DA80");

            entity.HasIndex(e => e.Consec, "Index_1").IsUnique();

            entity.HasIndex(e => new { e.Modulo, e.PorOmision }, "Index_2");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ColumnaDesIdiom)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.ColumnaDesplegar)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.ColumnaOrigen)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Tabla)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<Monedas>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Monedas__3214EC07F4967FC1");

            entity.HasIndex(e => e.Codigo, "Index_1").IsUnique();

            entity.HasIndex(e => e.Nombre, "Index_2");

            entity.HasIndex(e => new { e.Codigo, e.Nombre }, "Index_3");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoSAT)
                .HasMaxLength(3)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.NombrePlural)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.NombreSingular)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Simbolo)
                .HasMaxLength(3)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TextoFinal)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TimeStamp)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<MovimientosAdministrativos>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Movimien__3214EC07E332A908");

            entity.HasIndex(e => new { e.IdDoctoAdmvo, e.NumMovto }, "Index_1").IsUnique();

            entity.HasIndex(e => e.UUID, "Index_2");

            entity.HasIndex(e => e.CodigoTipoOperacion, "Index_3");

            entity.HasIndex(e => e.CodigoSegmentoNegocio, "Index_4");

            entity.HasIndex(e => e.CveProdSAT, "Index_5");

            entity.HasIndex(e => e.CodigoProducto, "Index_6");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CodigoProducto)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoSegmentoNegocio)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoTipoOperacion)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CveProdSAT)
                .HasMaxLength(8)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.UUID)
                .HasMaxLength(36)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<MovimientosAsiento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Movimien__3214EC079D212B03");

            entity.HasIndex(e => new { e.IdAsiento, e.NumeroMovto }, "Index_1").IsUnique();

            entity.HasIndex(e => e.IdAsiento, "Index_2");

            entity.HasIndex(e => e.IdSegmentoNegocio, "Index_3");

            entity.HasIndex(e => e.IdDiario, "Index_4");

            entity.HasIndex(e => new { e.IdAsiento, e.NumeroMovto }, "Index_5");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.FormulaCuenta)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.FormulaImporte)
                .HasMaxLength(500)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.FormulaImporteME)
                .HasMaxLength(500)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.IdDiario)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.IdSegmentoNegocio)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TextoConcepto)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TextoReferencia)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<MovimientosCFD>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Movimien__3214EC0788BDBC73");

            entity.HasIndex(e => new { e.IdPoliza, e.NumMovto, e.IdDocGastos }, "Index_1").IsUnique();

            entity.HasIndex(e => e.IdPoliza, "Index_2");

            entity.HasIndex(e => e.NumMovto, "Index_3");

            entity.HasIndex(e => e.IdDocGastos, "Index_4");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ClaveRastreo)
                .HasMaxLength(60)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoConceptoIETU)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Concepto)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FolioStr)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.GuidComprobante)
                .HasMaxLength(36)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.NombreImpuesto)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.NombreOtrasRetenciones)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Referencia)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Serie)
                .HasMaxLength(15)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.UUID)
                .HasMaxLength(60)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.UsuAutorizaPresupuesto)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<MovimientosPlantillaAsiento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Movimien__3214EC07A519B97E");

            entity.HasIndex(e => new { e.IdPlantillaAsiento, e.NumeroMovto }, "Index_1").IsUnique();

            entity.HasIndex(e => e.IdPlantillaAsiento, "Index_2");

            entity.HasIndex(e => new { e.IdPlantillaAsiento, e.NumeroMovto }, "Index_3");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.FormulaCuenta)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.FormulaImporte)
                .HasMaxLength(500)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.FormulaImporteME)
                .HasMaxLength(500)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.IdDiario).HasMaxLength(100);
            entity.Property(e => e.IdSegmentoNegocio).HasMaxLength(100);
            entity.Property(e => e.TextoConcepto)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TextoReferencia)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<MovimientosPoliza>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Movimien__3214EC0734055DE2");

            entity.HasIndex(e => new { e.IdPoliza, e.NumMovto }, "Index_1").IsUnique();

            entity.HasIndex(e => new { e.Ejercicio, e.Periodo, e.TipoPol, e.Folio, e.NumMovto }, "Index_10");

            entity.HasIndex(e => new { e.Ejercicio, e.Periodo, e.IdCuenta, e.IdSegNeg, e.IdDiario }, "Index_11");

            entity.HasIndex(e => e.IdPoliza, "Index_2");

            entity.HasIndex(e => e.NumMovto, "Index_3");

            entity.HasIndex(e => e.IdSegNeg, "Index_4");

            entity.HasIndex(e => e.Guid, "Index_5");

            entity.HasIndex(e => new { e.IdCuenta, e.Fecha, e.TipoPol, e.Folio }, "Index_6");

            entity.HasIndex(e => new { e.IdCuenta, e.IdSegNeg, e.Fecha, e.TipoPol, e.Folio }, "Index_7");

            entity.HasIndex(e => new { e.IdDiario, e.Fecha, e.TipoPol, e.Folio }, "Index_8");

            entity.HasIndex(e => new { e.Fecha, e.TipoPol, e.NumMovto }, "Index_9");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Concepto)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaAplicacion).HasColumnType("datetime");
            entity.Property(e => e.Guid)
                .HasMaxLength(36)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Referencia)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TimeStamp)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<MovimientosPrepoliza>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Movimien__3214EC078DD9838D");

            entity.HasIndex(e => new { e.IdPrepoliza, e.NumMovto }, "Index_1").IsUnique();

            entity.HasIndex(e => e.IdPrepoliza, "Index_2");

            entity.HasIndex(e => e.NumMovto, "Index_3");

            entity.HasIndex(e => e.Cuenta, "Index_4");

            entity.HasIndex(e => e.Diario, "Index_5");

            entity.HasIndex(e => e.SegNeg, "Index_6");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CodigoPrepoliza)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Concepto)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CtaFinal)
                .HasMaxLength(52)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Cuenta)
                .HasMaxLength(52)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Diario)
                .HasMaxLength(52)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Importe)
                .HasMaxLength(52)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.ImporteME)
                .HasMaxLength(52)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Referencia)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegNeg)
                .HasMaxLength(52)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TimeStamp)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<MovtosEdoCtaBancos>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MovtosEd__3214EC07AE8A0295");

            entity.HasIndex(e => e.IdMovto, "Index_1").IsUnique();

            entity.HasIndex(e => new { e.IdEdoCtaBanco, e.EsConciliado, e.Referencia, e.Fecha }, "Index_2");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Concepto)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Numero)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Referencia)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TipoMovto)
                .HasMaxLength(1)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<NombresValoresCV>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NombresV__3214EC07541CC0B4");

            entity.HasIndex(e => e.NumValor, "Index_1").IsUnique();

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<PagosProvisionalISR>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PagosPro__3214EC070C28335B");

            entity.HasIndex(e => new { e.Ejercicio, e.Periodo }, "Index_1").IsUnique();

            entity.HasIndex(e => new { e.Ejercicio, e.Periodo }, "Index_2");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Parametros>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Parametr__3214EC073FCFC930");

            entity.HasIndex(e => e.IdEmpresa, "Index_1").IsUnique();

            entity.HasIndex(e => e.CtaFlujo, "Index_2");

            entity.HasIndex(e => e.EjerActual, "Index_3");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ApdoPostal)
                .HasMaxLength(10)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.ApellMatRep)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.ApellPatRep)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Asunto)
                .HasMaxLength(254)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CURP)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Ciudad)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodPostal)
                .HasMaxLength(10)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CtaFlujo)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Cuerpo)
                .HasMaxLength(1000)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.DelimExport)
                .HasMaxLength(10)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.DiaTrabajo).HasColumnType("datetime");
            entity.Property(e => e.Direccion)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.EstCliente)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.EstProveedor)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Estado)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.EstructCta)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.FecIniHist).HasColumnType("datetime");
            entity.Property(e => e.FechaInicioHistoriaBN).HasColumnType("datetime");
            entity.Property(e => e.Firma)
                .HasMaxLength(254)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.GuidCertificado)
                .HasMaxLength(36)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.GuidCertificadoEntrega)
                .HasMaxLength(36)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.GuidDSL)
                .HasMaxLength(36)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.GuidDSLCreado)
                .HasMaxLength(36)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.GuidEmpresa)
                .HasMaxLength(36)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.LeyendaAbono)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Mascarilla)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.ModulosIntegrados)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Pais)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.ParFunc)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.ParFuncCheques)
                .HasMaxLength(15)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.PolizaIntuitiva)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.RFC)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.RFCRepresentante)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(254)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.RegCamara)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.RegEstatal)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.RepLegal)
                .HasMaxLength(254)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.RutaAdminPAQ)
                .HasMaxLength(254)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.RutaRespaldo)
                .HasMaxLength(254)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SMTPName)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SalidaDisco)
                .HasMaxLength(254)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TimeStamp)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TitularCer)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.VersionBDD)
                .HasMaxLength(10)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.eMail)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<ParametrosInicialesMto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Parametr__3214EC079A070CA4");

            entity.HasIndex(e => e.DBTemplate, "Index_1").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.DBTemplate)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PeriodosCausacionIVA>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Periodos__3214EC0789F6E003");

            entity.HasIndex(e => e.IdMovimiento, "Index_1").IsUnique();

            entity.HasIndex(e => e.IdPoliza, "Index_2");

            entity.HasIndex(e => new { e.EjercicioAsignado, e.PeriodoAsignado, e.IdPoliza, e.IdMovimiento }, "Index_3");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.TimeStamp)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<Personas>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Personas__3214EC07E127CF4D");

            entity.HasIndex(e => e.Codigo, "Index_1").IsUnique();

            entity.HasIndex(e => e.SegContPersona3, "Index_10");

            entity.HasIndex(e => e.SegContPersona4, "Index_11");

            entity.HasIndex(e => e.SegContPersona5, "Index_12");

            entity.HasIndex(e => e.SegContPersona6, "Index_13");

            entity.HasIndex(e => e.SegContPersona7, "Index_14");

            entity.HasIndex(e => e.EsCliente, "Index_15");

            entity.HasIndex(e => e.EsProveedor, "Index_16");

            entity.HasIndex(e => e.EsResponsableGasto, "Index_17");

            entity.HasIndex(e => e.RFC, "Index_2");

            entity.HasIndex(e => e.CURP, "Index_3");

            entity.HasIndex(e => e.Nombre, "Index_4");

            entity.HasIndex(e => e.Telefono1, "Index_5");

            entity.HasIndex(e => e.eMail, "Index_6");

            entity.HasIndex(e => e.CodigoAdminPAQ, "Index_7");

            entity.HasIndex(e => e.SegContPersona1, "Index_8");

            entity.HasIndex(e => e.SegContPersona2, "Index_9");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CURP)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Codigo)
                .HasMaxLength(40)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoAdminPAQ)
                .HasMaxLength(40)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.CtaContableGasto)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Fax)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(254)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.PaginaWeb)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.RFC)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegContPersona1)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegContPersona2)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegContPersona3)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegContPersona4)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegContPersona5)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegContPersona6)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegContPersona7)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Telefono1)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Telefono2)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Telefono3)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.eMail)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<Plantillas>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Plantill__3214EC07E1B86CAD");

            entity.HasIndex(e => e.Codigo, "Index_1").IsUnique();

            entity.HasIndex(e => e.BeneficiarioPagador, "Index_2");

            entity.HasIndex(e => e.TipoDocumento, "Index_3");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.BeneficiarioPagador)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Codigo)
                .HasMaxLength(5)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoMoneda)
                .HasMaxLength(5)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoPersona)
                .HasMaxLength(40)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Concepto)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Nombre)
                .HasMaxLength(60)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Referencia)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<PlantillasAsiento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Plantill__3214EC07AFF94998");

            entity.HasIndex(e => e.Codigo, "Index_1").IsUnique();

            entity.HasIndex(e => e.Codigo, "Index_2");

            entity.HasIndex(e => e.Nombre, "Index_3");

            entity.HasIndex(e => e.Tipo, "Index_4");

            entity.HasIndex(e => e.TipoXML, "Index_5");

            entity.HasIndex(e => e.IdCtaBancaria, "Index_6");

            entity.HasIndex(e => e.TipoCFDI, "Index_7");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.DescripcionConcepto)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TipoCFDI)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<PlantillasEstadosCuentas>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Plantill__3214EC07D5AA3428");

            entity.HasIndex(e => e.Nombre, "Index_1").IsUnique();

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Archivo)
                .HasMaxLength(254)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TimeStamp)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<Polizas>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Polizas__3214EC075CEF825F");

            entity.HasIndex(e => new { e.Ejercicio, e.Periodo, e.TipoPol, e.Folio }, "Index_1").IsUnique();

            entity.HasIndex(e => new { e.SistOrig, e.Fecha, e.TipoPol, e.Folio }, "Index_10");

            entity.HasIndex(e => new { e.Clase, e.Fecha, e.TipoPol, e.Folio }, "Index_11");

            entity.HasIndex(e => new { e.Ejercicio, e.Periodo, e.TipoPol, e.SistOrig }, "Index_12");

            entity.HasIndex(e => new { e.Ejercicio, e.TipoPol, e.Periodo }, "Index_13");

            entity.HasIndex(e => e.Periodo, "Index_2");

            entity.HasIndex(e => e.TipoPol, "Index_3");

            entity.HasIndex(e => e.Folio, "Index_4");

            entity.HasIndex(e => e.IdUsuario, "Index_5");

            entity.HasIndex(e => e.Guid, "Index_6");

            entity.HasIndex(e => e.Fecha, "Index_7");

            entity.HasIndex(e => new { e.IdDiario, e.Fecha, e.TipoPol, e.Folio }, "Index_8");

            entity.HasIndex(e => new { e.Fecha, e.TipoPol, e.Folio }, "Index_9");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ArchivoAnexo)
                .HasMaxLength(254)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Concepto)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Guid)
                .HasMaxLength(36)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.RutaAnexo)
                .HasMaxLength(254)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TimeStamp)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<PolizasIntuitivas>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PolizasI__3214EC074582D529");

            entity.HasIndex(e => new { e.TipoPol, e.TipoXml, e.RFC, e.IdCuenta, e.TipoMovto, e.ImporteUsado, e.IdDiario, e.IdSegNeg }, "Index_1").IsUnique();

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.FechaUltimoUso).HasColumnType("datetime");
            entity.Property(e => e.RFC).HasMaxLength(20);
        });

        modelBuilder.Entity<PorcentajesPresupuesto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Porcenta__3214EC0756B712CC");

            entity.HasIndex(e => e.Codigo, "Index_1").IsUnique();

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TimeStamp)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<Prepolizas>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Prepoliz__3214EC0781F38997");

            entity.HasIndex(e => e.Codigo, "Index_1").IsUnique();

            entity.HasIndex(e => e.Acceso, "Index_2");

            entity.HasIndex(e => e.Diario, "Index_3");

            entity.HasIndex(e => e.TipoPol, "Index_4");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Acceso)
                .HasMaxLength(1)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Concepto)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CveFecha)
                .HasMaxLength(52)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Diario)
                .HasMaxLength(52)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.EsquemaDatos)
                .HasMaxLength(254)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Folio)
                .HasMaxLength(52)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TimeStamp)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TipoPol)
                .HasMaxLength(52)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Variable1)
                .HasMaxLength(15)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Variable10)
                .HasMaxLength(15)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Variable2)
                .HasMaxLength(15)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Variable3)
                .HasMaxLength(15)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Variable4)
                .HasMaxLength(15)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Variable5)
                .HasMaxLength(15)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Variable6)
                .HasMaxLength(15)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Variable7)
                .HasMaxLength(15)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Variable8)
                .HasMaxLength(15)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Variable9)
                .HasMaxLength(15)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<Presupuestos>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Presupue__3214EC07EAF39BDC");

            entity.HasIndex(e => new { e.IdCuenta, e.Ejercicio, e.IdSegNeg }, "Index_1").IsUnique();

            entity.HasIndex(e => e.Ejercicio, "Index_2");

            entity.HasIndex(e => e.IdSegNeg, "Index_3");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.TimeStamp)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<PresupuestosCategorias>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Presupue__3214EC078BE5919F");

            entity.HasIndex(e => new { e.IdCategoria, e.Ejercicio }, "Index_1").IsUnique();

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Productos>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Producto__3214EC07BBB2FF43");

            entity.HasIndex(e => e.Codigo, "Index_1").IsUnique();

            entity.HasIndex(e => e.IdTipoOperacion, "Index_2");

            entity.HasIndex(e => e.SegContProducto1, "Index_3");

            entity.HasIndex(e => e.SegContProducto2, "Index_4");

            entity.HasIndex(e => e.SegContProducto3, "Index_5");

            entity.HasIndex(e => e.SegContProducto4, "Index_6");

            entity.HasIndex(e => e.SegContProducto5, "Index_7");

            entity.HasIndex(e => e.SegContProducto6, "Index_8");

            entity.HasIndex(e => e.SegContProducto7, "Index_9");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ClaveProdServ)
                .HasMaxLength(8)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegContProducto1)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegContProducto2)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegContProducto3)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegContProducto4)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegContProducto5)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegContProducto6)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegContProducto7)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<Proveedores>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Proveedo__3214EC07398A420C");

            entity.HasIndex(e => e.Codigo, "Index_1").IsUnique();

            entity.HasIndex(e => e.CodigoCtaGastosComplementaria, "Index_10");

            entity.HasIndex(e => e.SegContProveedor1, "Index_11");

            entity.HasIndex(e => e.SegContProveedor2, "Index_12");

            entity.HasIndex(e => e.SegContProveedor3, "Index_13");

            entity.HasIndex(e => e.SegContProveedor4, "Index_14");

            entity.HasIndex(e => e.SegContProveedor5, "Index_15");

            entity.HasIndex(e => e.SegContProveedor6, "Index_16");

            entity.HasIndex(e => e.SegContProveedor7, "Index_17");

            entity.HasIndex(e => new { e.TipoOperacion, e.Codigo }, "Index_18");

            entity.HasIndex(e => new { e.TipoOperacion, e.Nombre }, "Index_19");

            entity.HasIndex(e => e.RFC, "Index_2");

            entity.HasIndex(e => e.Nombre, "Index_3");

            entity.HasIndex(e => e.IdCuenta, "Index_4");

            entity.HasIndex(e => e.CodigoCuenta, "Index_5");

            entity.HasIndex(e => e.CodigoCtaComplementaria, "Index_6");

            entity.HasIndex(e => e.CodigoPrepoliza, "Index_7");

            entity.HasIndex(e => e.CodigoPersona, "Index_8");

            entity.HasIndex(e => e.CodigoCtaGastos, "Index_9");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.BancoDestinoId).HasDefaultValue(0);
            entity.Property(e => e.CURP)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.ClaveBanco)
                .HasMaxLength(10)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoAsiento).HasMaxLength(20);
            entity.Property(e => e.CodigoCtaComplementaria)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoCtaGastos)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoCtaGastosComplementaria)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoCuenta)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoPersona)
                .HasMaxLength(40)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoPrepoliza)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CuentaClabe)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Diario).HasDefaultValue(0);
            entity.Property(e => e.IdFiscal)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Nacionalidad)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.NomExtranjero)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Nombre)
                .HasMaxLength(254)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Pais)
                .HasMaxLength(3)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.RFC)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Referencia)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegContProveedor1)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegContProveedor2)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegContProveedor3)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegContProveedor4)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegContProveedor5)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegContProveedor6)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegContProveedor7)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Sucursal)
                .HasMaxLength(10)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TimeStamp)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<Recordatorios>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Recordat__3214EC077415B06C");

            entity.HasIndex(e => new { e.IdDocumentoDe, e.TipoDocumento, e.IdCuentaCheque, e.Folio }, "Index_1").IsUnique();

            entity.HasIndex(e => e.IdUsuario, "Index_2");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Folio)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Mensaje)
                .UseCollation("SQL_Latin1_General_CP437_BIN")
                .HasColumnType("ntext");
            entity.Property(e => e.MensajeCorto)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<RelacionEmpresasNube>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Relacion__3214EC07A8F4C92A");

            entity.HasIndex(e => new { e.CompanyID, e.InstanceID, e.IdAppNube }, "Index_1").IsUnique();

            entity.HasIndex(e => e.CompanyID, "Index_2");

            entity.HasIndex(e => e.InstanceID, "Index_3");

            entity.HasIndex(e => e.IdAppNube, "Index_4");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.AliasEmpresa).HasMaxLength(50);
            entity.Property(e => e.CompanyID).HasMaxLength(36);
            entity.Property(e => e.Estado).HasMaxLength(50);
            entity.Property(e => e.IdAppNube).HasMaxLength(36);
            entity.Property(e => e.InstanceID).HasMaxLength(36);
            entity.Property(e => e.NombreEmpresa).HasMaxLength(50);
            entity.Property(e => e.RFC).HasMaxLength(20);
        });

        modelBuilder.Entity<Retenciones>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Retencio__3214EC07B3FBE245");

            entity.HasIndex(e => new { e.IdComplemento, e.Folio }, "Index_1").IsUnique();

            entity.HasIndex(e => e.Fecha, "Index_2");

            entity.HasIndex(e => e.IdComplemento, "Index_3");

            entity.HasIndex(e => e.Guid, "Index_4");

            entity.HasIndex(e => e.GuidRetencion, "Index_5");

            entity.HasIndex(e => e.UUIDRetencion, "Index_6");

            entity.HasIndex(e => e.FechaExpedicion, "Index_7");

            entity.HasIndex(e => new { e.IdComplemento, e.Fecha }, "Index_8");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaExpedicion).HasColumnType("datetime");
            entity.Property(e => e.Folio)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.FolioCancelacion)
                .HasMaxLength(36)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Guid)
                .HasMaxLength(36)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.GuidRetencion)
                .HasMaxLength(36)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Referencia)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TimeStamp)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TipoRelacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.UUIDAsociado)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.UUIDRetencion)
                .HasMaxLength(36)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Version).HasDefaultValue(1);
            entity.Property(e => e.XMLComplemento)
                .UseCollation("SQL_Latin1_General_CP437_BIN")
                .HasColumnType("ntext");
        });

        modelBuilder.Entity<RubrosNIF>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RubrosNI__3214EC0732B2FD67");

            entity.HasIndex(e => e.Codigo, "Index_1").IsUnique();

            entity.HasIndex(e => e.Nombre, "Index_2");

            entity.HasIndex(e => e.NombreIdioma, "Index_3");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.DescripcionNivel)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.DescripcionNivelIdioma)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.NombreIdioma)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TimeStamp)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<SaldosCategorias>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SaldosCa__3214EC07A0FE6CA6");

            entity.HasIndex(e => new { e.IdCategoria, e.Ejercicio }, "Index_1").IsUnique();

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<SaldosCtasCheques>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SaldosCt__3214EC07207E51BF");

            entity.HasIndex(e => new { e.Tipo, e.Ejercicio, e.IdCuentaCheque }, "Index_1").IsUnique();

            entity.HasIndex(e => e.IdCuentaCheque, "Index_2");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<SaldosCuentas>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SaldosCu__3214EC07F335434D");

            entity.HasIndex(e => new { e.IdCuenta, e.Ejercicio, e.Tipo }, "Index_1").IsUnique();

            entity.HasIndex(e => e.IdCuenta, "Index_2");

            entity.HasIndex(e => e.Ejercicio, "Index_3");

            entity.HasIndex(e => e.Tipo, "Index_4");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.TimeStamp)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<SaldosSegmentoNegocio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SaldosSe__3214EC076700BD6A");

            entity.HasIndex(e => new { e.IdCuenta, e.IdSegNeg, e.Ejercicio, e.Tipo }, "Index_1").IsUnique();

            entity.HasIndex(e => e.IdSegNeg, "Index_2");

            entity.HasIndex(e => e.Ejercicio, "Index_3");

            entity.HasIndex(e => e.Tipo, "Index_4");

            entity.HasIndex(e => new { e.IdCuenta, e.Ejercicio, e.Tipo }, "Index_5");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.TimeStamp)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<SegmentosNegocio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Segmento__3214EC07A8863E14");

            entity.HasIndex(e => e.Codigo, "Index_1").IsUnique();

            entity.HasIndex(e => e.Nombre, "Index_2");

            entity.HasIndex(e => e.SegContSegmento1, "Index_3");

            entity.HasIndex(e => e.SegContSegmento2, "Index_4");

            entity.HasIndex(e => e.SegContSegmento3, "Index_5");

            entity.HasIndex(e => e.SegContSegmento4, "Index_6");

            entity.HasIndex(e => e.SegContSegmento5, "Index_7");

            entity.HasIndex(e => e.SegContSegmento6, "Index_8");

            entity.HasIndex(e => e.SegContSegmento7, "Index_9");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegContSegmento1)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegContSegmento2)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegContSegmento3)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegContSegmento4)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegContSegmento5)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegContSegmento6)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegContSegmento7)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TimeStamp)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<TiposActivos>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TiposAct__3214EC078AB65C91");

            entity.HasIndex(e => e.Codigo, "Index_1");

            entity.HasIndex(e => e.IdCtaDeprecC, "Index_2");

            entity.HasIndex(e => e.IdCtaDeprecF, "Index_3");

            entity.HasIndex(e => e.IdCtaGastosC, "Index_4");

            entity.HasIndex(e => e.IdCtaGastosF, "Index_5");

            entity.HasIndex(e => e.IdCtaNoDedC, "Index_6");

            entity.HasIndex(e => e.IdCtaNoDedF, "Index_7");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Codigo).HasMaxLength(20);
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        modelBuilder.Entity<TiposCambio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TiposCam__3214EC07D59DA8DB");

            entity.HasIndex(e => new { e.Moneda, e.Fecha, e.Tipo }, "Index_1").IsUnique();

            entity.HasIndex(e => e.Moneda, "Index_2");

            entity.HasIndex(e => e.Fecha, "Index_3");

            entity.HasIndex(e => e.Tipo, "Index_4");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.TimeStamp)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<TiposDocumentos>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TiposDoc__3214EC07B3F960EB");

            entity.HasIndex(e => e.Codigo, "Index_1").IsUnique();

            entity.HasIndex(e => e.Nombre, "Index_2");

            entity.HasIndex(e => e.IdDocumentoDe, "Index_3");

            entity.HasIndex(e => new { e.IdDocumentoDe, e.Clasificacion }, "Index_4");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Codigo)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoAsiento).HasMaxLength(20);
            entity.Property(e => e.CodigoFolioDigital)
                .HasMaxLength(5)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoFolioDocumentoDe)
                .HasMaxLength(5)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoFolioTipoDocumento)
                .HasMaxLength(5)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoPrepoliza)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.FormaPreimpresa)
                .HasMaxLength(254)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Nombre)
                .HasMaxLength(60)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<TiposOperacion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TiposOpe__3214EC07B753FA0E");

            entity.HasIndex(e => e.Codigo, "Index_1").IsUnique();

            entity.HasIndex(e => e.SegContTipoOperacion1, "Index_2");

            entity.HasIndex(e => e.SegContTipoOperacion2, "Index_3");

            entity.HasIndex(e => e.SegContTipoOperacion3, "Index_4");

            entity.HasIndex(e => e.SegContTipoOperacion4, "Index_5");

            entity.HasIndex(e => e.SegContTipoOperacion5, "Index_6");

            entity.HasIndex(e => e.SegContTipoOperacion6, "Index_7");

            entity.HasIndex(e => e.SegContTipoOperacion7, "Index_8");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegContTipoOperacion1)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegContTipoOperacion2)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegContTipoOperacion3)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegContTipoOperacion4)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegContTipoOperacion5)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegContTipoOperacion6)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.SegContTipoOperacion7)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<TiposPolizas>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TiposPol__3214EC07C61D1594");

            entity.HasIndex(e => e.Codigo, "Index_1").IsUnique();

            entity.HasIndex(e => e.Tipo, "Index_2");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TimeStamp)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<TiposPolizasSAT>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TiposPol__3214EC071571C6C4");

            entity.HasIndex(e => e.Codigo, "Index_1").IsUnique();

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TimeStamp)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<ValoresAuxiliaresCV>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ValoresA__3214EC07334FB9AA");

            entity.HasIndex(e => new { e.IdClave, e.IdEjercicio, e.Periodo }, "Index_1").IsUnique();

            entity.HasIndex(e => e.IdClave, "Index_2");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
