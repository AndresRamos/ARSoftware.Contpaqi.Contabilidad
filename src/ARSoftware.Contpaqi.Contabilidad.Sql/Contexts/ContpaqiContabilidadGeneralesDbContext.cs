using System;
using System.Collections.Generic;
using ARSoftware.Contpaqi.Contabilidad.Sql.Models.Generales;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Contexts;

public partial class ContpaqiContabilidadGeneralesDbContext : DbContext
{
    public ContpaqiContabilidadGeneralesDbContext(DbContextOptions<ContpaqiContabilidadGeneralesDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Counters> Counters { get; set; }

    public virtual DbSet<EmpresasUsuario> EmpresasUsuario { get; set; }

    public virtual DbSet<Estados> Estados { get; set; }

    public virtual DbSet<HistorialContrasenas> HistorialContrasenas { get; set; }

    public virtual DbSet<INPCs> INPCs { get; set; }

    public virtual DbSet<ListaEmpresas> ListaEmpresas { get; set; }

    public virtual DbSet<ModelosFinancieros> ModelosFinancieros { get; set; }

    public virtual DbSet<Municipios> Municipios { get; set; }

    public virtual DbSet<Notificaciones> Notificaciones { get; set; }

    public virtual DbSet<Paises> Paises { get; set; }

    public virtual DbSet<Perfiles> Perfiles { get; set; }

    public virtual DbSet<PeriodosSAT> PeriodosSAT { get; set; }

    public virtual DbSet<PermisosPerfil> PermisosPerfil { get; set; }

    public virtual DbSet<PermisosUsuario> PermisosUsuario { get; set; }

    public virtual DbSet<Procesos> Procesos { get; set; }

    public virtual DbSet<Temps> Temps { get; set; }

    public virtual DbSet<Usuarios> Usuarios { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Counters>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Counters__3214EC074668F2A1");

            entity.HasIndex(e => e.Name, "Index_1").IsUnique();

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .HasMaxLength(256)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<EmpresasUsuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Empresas__3214EC07EA95A562");

            entity.HasIndex(e => new { e.IdUsuario, e.IdEmpresa }, "Index_1").IsUnique();

            entity.HasIndex(e => e.IdUsuario, "Index_2");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Estados>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Estados__3214EC0767731D77");

            entity.HasIndex(e => e.Codigo, "Index_1").IsUnique();

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Codigo)
                .HasMaxLength(2)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<HistorialContrasenas>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Historia__3214EC0750890EE3");

            entity.HasIndex(e => new { e.CodigoUsuario, e.FechaCambio }, "Index_1").IsUnique();

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Clave)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoUsuario)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.FechaCambio).HasColumnType("datetime");
        });

        modelBuilder.Entity<INPCs>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__INPCs__3214EC071619AFE6");

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

        modelBuilder.Entity<ListaEmpresas>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ListaEmp__3214EC07059CC914");

            entity.HasIndex(e => e.AliasBDD, "Index_1").IsUnique();

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.AccessToken).HasMaxLength(3000);
            entity.Property(e => e.AliasBDD)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.ArchivoUltimoResp)
                .HasMaxLength(254)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.IdToken).HasMaxLength(3000);
            entity.Property(e => e.ModulosIntegrados)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.RefreshToken).HasMaxLength(3000);
            entity.Property(e => e.RutaDatos)
                .HasMaxLength(254)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.RutaResp)
                .HasMaxLength(254)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TimeStamp)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.UltimaRest).HasColumnType("datetime");
            entity.Property(e => e.UltimoResp).HasColumnType("datetime");
            entity.Property(e => e.VersionBDD)
                .HasMaxLength(10)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<ModelosFinancieros>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ModelosF__3214EC070FD5C3A1");

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

        modelBuilder.Entity<Municipios>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Municipi__3214EC0728F95E1E");

            entity.HasIndex(e => e.Codigo, "Index_1").IsUnique();

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Codigo)
                .HasMaxLength(5)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.CodigoEstado)
                .HasMaxLength(2)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<Notificaciones>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Notifica__3214EC07FDB28CB9");

            entity.HasIndex(e => e.Llave, "Index_1").IsUnique();

            entity.HasIndex(e => e.Usuario, "Index_2");

            entity.HasIndex(e => e.Tipo, "Index_3");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Empresa)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.FechaNotificacion).HasColumnType("datetime");
            entity.Property(e => e.Llave)
                .HasMaxLength(36)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Mensaje)
                .HasMaxLength(1000)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.MensajeEnIngles)
                .HasMaxLength(1000)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Usuario)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<Paises>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Paises__3214EC0746953700");

            entity.HasIndex(e => e.Codigo, "Index_1").IsUnique();

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Codigo)
                .HasMaxLength(3)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TimeStamp)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<Perfiles>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Perfiles__3214EC071B0E3E85");

            entity.HasIndex(e => e.Codigo, "Index_1").IsUnique();

            entity.HasIndex(e => e.Nombre, "Index_2");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TimeStamp)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<PeriodosSAT>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Periodos__3214EC0709384EB6");

            entity.HasIndex(e => e.Codigo, "Index_1").IsUnique();

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Codigo)
                .HasMaxLength(2)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Periodicidad)
                .HasMaxLength(2)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<PermisosPerfil>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Permisos__3214EC07A1C97313");

            entity.HasIndex(e => new { e.IdPerfil, e.IdProceso }, "Index_1").IsUnique();

            entity.HasIndex(e => e.IdPerfil, "Index_2");

            entity.HasIndex(e => e.IdProceso, "Index_3");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.TimeStamp)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<PermisosUsuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Permisos__3214EC07756DCD6C");

            entity.HasIndex(e => new { e.IdUsuario, e.IdProceso }, "Index_1").IsUnique();

            entity.HasIndex(e => e.IdUsuario, "Index_2");

            entity.HasIndex(e => e.IdProceso, "Index_3");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.TimeStamp)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
        });

        modelBuilder.Entity<Procesos>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Procesos__3214EC07F50F9673");

            entity.HasIndex(e => e.Codigo, "Index_1").IsUnique();

            entity.HasIndex(e => e.Nombre, "Index_2");

            entity.HasIndex(e => new { e.Sistema, e.Tipo, e.Nombre }, "Index_3");

            entity.HasIndex(e => new { e.SistemaIntegrado, e.Tipo, e.Nombre }, "Index_4");

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

        modelBuilder.Entity<Temps>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Temps__3214EC073C98396D");

            entity.HasIndex(e => e.Local, "Index_1");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Async)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Demo)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.End1)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.End2)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.End3)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.End4)
                .HasMaxLength(5)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Fix)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Reference)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Replace)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Stream)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TStamp).HasColumnType("datetime");
        });

        modelBuilder.Entity<Usuarios>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Usuarios__3214EC078DFCF6D1");

            entity.HasIndex(e => e.Guid, "Id_Global").IsUnique();

            entity.HasIndex(e => e.Codigo, "Index_1").IsUnique();

            entity.HasIndex(e => e.IdPerfil, "Index_2");

            entity.HasIndex(e => e.Id, "Index_Id").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Clave).HasMaxLength(100);
            entity.Property(e => e.ClaveTemporal).HasDefaultValue(false);
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.ExpiraClave).HasDefaultValue(false);
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.FechaUltimaActividad)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaVencimientoClave)
                .HasDefaultValueSql("(getdate()+(90))")
                .HasColumnType("datetime");
            entity.Property(e => e.Guid)
                .HasMaxLength(36)
                .HasDefaultValueSql("(newid())")
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.TimeStamp)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.eMail)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.eMailClave)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP437_BIN");
            entity.Property(e => e.eMailRecuperacion)
                .HasMaxLength(250)
                .HasDefaultValue("");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
