using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ARSoftware.Contpaqi.Contabilidad.Sql.Models.Generales;

namespace ARSoftware.Contpaqi.Contabilidad.Sql.Contexts
{
    public partial class ContpaqiContabilidadGeneralesDbContext : DbContext
    {
        public ContpaqiContabilidadGeneralesDbContext()
        {
        }

        public ContpaqiContabilidadGeneralesDbContext(DbContextOptions<ContpaqiContabilidadGeneralesDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Counters> Counters { get; set; }
        public virtual DbSet<EmpresasUsuario> EmpresasUsuario { get; set; }
        public virtual DbSet<Estados> Estados { get; set; }
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
                entity.HasIndex(e => e.Name, "Index_1")
                    .IsUnique();

                entity.HasIndex(e => e.Id, "Index_Id")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256)
                    .UseCollation("SQL_Latin1_General_CP437_BIN");
            });

            modelBuilder.Entity<EmpresasUsuario>(entity =>
            {
                entity.HasIndex(e => new { e.IdUsuario, e.IdEmpresa }, "Index_1")
                    .IsUnique();

                entity.HasIndex(e => e.IdUsuario, "Index_2");

                entity.HasIndex(e => e.Id, "Index_Id")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Estados>(entity =>
            {
                entity.HasIndex(e => e.Codigo, "Index_1")
                    .IsUnique();

                entity.HasIndex(e => e.Id, "Index_Id")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(2)
                    .UseCollation("SQL_Latin1_General_CP437_BIN");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .UseCollation("SQL_Latin1_General_CP437_BIN");
            });

            modelBuilder.Entity<INPCs>(entity =>
            {
                entity.HasIndex(e => e.Codigo, "Index_1")
                    .IsUnique();

                entity.HasIndex(e => e.Id, "Index_Id")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .UseCollation("SQL_Latin1_General_CP437_BIN");

                entity.Property(e => e.TimeStamp)
                    .HasMaxLength(20)
                    .UseCollation("SQL_Latin1_General_CP437_BIN");
            });

            modelBuilder.Entity<ListaEmpresas>(entity =>
            {
                entity.HasIndex(e => e.AliasBDD, "Index_1")
                    .IsUnique();

                entity.HasIndex(e => e.Id, "Index_Id")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AccessToken).HasMaxLength(2000);

                entity.Property(e => e.AliasBDD)
                    .IsRequired()
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP437_BIN");

                entity.Property(e => e.ArchivoUltimoResp)
                    .HasMaxLength(254)
                    .UseCollation("SQL_Latin1_General_CP437_BIN");

                entity.Property(e => e.IdToken).HasMaxLength(2000);

                entity.Property(e => e.ModulosIntegrados)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP437_BIN");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .UseCollation("SQL_Latin1_General_CP437_BIN");

                entity.Property(e => e.RefreshToken).HasMaxLength(2000);

                entity.Property(e => e.RutaDatos)
                    .IsRequired()
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
                entity.HasIndex(e => e.Nombre, "Index_1")
                    .IsUnique();

                entity.HasIndex(e => e.Id, "Index_Id")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Archivo)
                    .IsRequired()
                    .HasMaxLength(254)
                    .UseCollation("SQL_Latin1_General_CP437_BIN");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP437_BIN");

                entity.Property(e => e.TimeStamp)
                    .HasMaxLength(20)
                    .UseCollation("SQL_Latin1_General_CP437_BIN");
            });

            modelBuilder.Entity<Municipios>(entity =>
            {
                entity.HasIndex(e => e.Codigo, "Index_1")
                    .IsUnique();

                entity.HasIndex(e => e.Id, "Index_Id")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(5)
                    .UseCollation("SQL_Latin1_General_CP437_BIN");

                entity.Property(e => e.CodigoEstado)
                    .IsRequired()
                    .HasMaxLength(2)
                    .UseCollation("SQL_Latin1_General_CP437_BIN");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .UseCollation("SQL_Latin1_General_CP437_BIN");
            });

            modelBuilder.Entity<Notificaciones>(entity =>
            {
                entity.HasIndex(e => e.Llave, "Index_1")
                    .IsUnique();

                entity.HasIndex(e => e.Usuario, "Index_2");

                entity.HasIndex(e => e.Tipo, "Index_3");

                entity.HasIndex(e => e.Id, "Index_Id")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Empresa)
                    .IsRequired()
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP437_BIN");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaNotificacion).HasColumnType("datetime");

                entity.Property(e => e.Llave)
                    .IsRequired()
                    .HasMaxLength(36)
                    .UseCollation("SQL_Latin1_General_CP437_BIN");

                entity.Property(e => e.Mensaje)
                    .HasMaxLength(1000)
                    .UseCollation("SQL_Latin1_General_CP437_BIN");

                entity.Property(e => e.MensajeEnIngles)
                    .HasMaxLength(1000)
                    .UseCollation("SQL_Latin1_General_CP437_BIN");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(20)
                    .UseCollation("SQL_Latin1_General_CP437_BIN");
            });

            modelBuilder.Entity<Paises>(entity =>
            {
                entity.HasIndex(e => e.Codigo, "Index_1")
                    .IsUnique();

                entity.HasIndex(e => e.Id, "Index_Id")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .UseCollation("SQL_Latin1_General_CP437_BIN");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .UseCollation("SQL_Latin1_General_CP437_BIN");

                entity.Property(e => e.TimeStamp)
                    .HasMaxLength(20)
                    .UseCollation("SQL_Latin1_General_CP437_BIN");
            });

            modelBuilder.Entity<Perfiles>(entity =>
            {
                entity.HasIndex(e => e.Codigo, "Index_1")
                    .IsUnique();

                entity.HasIndex(e => e.Nombre, "Index_2");

                entity.HasIndex(e => e.Id, "Index_Id")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .UseCollation("SQL_Latin1_General_CP437_BIN");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP437_BIN");

                entity.Property(e => e.TimeStamp)
                    .HasMaxLength(20)
                    .UseCollation("SQL_Latin1_General_CP437_BIN");
            });

            modelBuilder.Entity<PeriodosSAT>(entity =>
            {
                entity.HasIndex(e => e.Codigo, "Index_1")
                    .IsUnique();

                entity.HasIndex(e => e.Id, "Index_Id")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(2)
                    .UseCollation("SQL_Latin1_General_CP437_BIN");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .UseCollation("SQL_Latin1_General_CP437_BIN");

                entity.Property(e => e.Periodicidad)
                    .IsRequired()
                    .HasMaxLength(2)
                    .UseCollation("SQL_Latin1_General_CP437_BIN");
            });

            modelBuilder.Entity<PermisosPerfil>(entity =>
            {
                entity.HasIndex(e => new { e.IdPerfil, e.IdProceso }, "Index_1")
                    .IsUnique();

                entity.HasIndex(e => e.IdPerfil, "Index_2");

                entity.HasIndex(e => e.IdProceso, "Index_3");

                entity.HasIndex(e => e.Id, "Index_Id")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.TimeStamp)
                    .HasMaxLength(20)
                    .UseCollation("SQL_Latin1_General_CP437_BIN");
            });

            modelBuilder.Entity<PermisosUsuario>(entity =>
            {
                entity.HasIndex(e => new { e.IdUsuario, e.IdProceso }, "Index_1")
                    .IsUnique();

                entity.HasIndex(e => e.IdUsuario, "Index_2");

                entity.HasIndex(e => e.IdProceso, "Index_3");

                entity.HasIndex(e => e.Id, "Index_Id")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.TimeStamp)
                    .HasMaxLength(20)
                    .UseCollation("SQL_Latin1_General_CP437_BIN");
            });

            modelBuilder.Entity<Procesos>(entity =>
            {
                entity.HasIndex(e => e.Codigo, "Index_1")
                    .IsUnique();

                entity.HasIndex(e => e.Nombre, "Index_2");

                entity.HasIndex(e => new { e.Sistema, e.Tipo, e.Nombre }, "Index_3");

                entity.HasIndex(e => new { e.SistemaIntegrado, e.Tipo, e.Nombre }, "Index_4");

                entity.HasIndex(e => e.Id, "Index_Id")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .UseCollation("SQL_Latin1_General_CP437_BIN");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .UseCollation("SQL_Latin1_General_CP437_BIN");

                entity.Property(e => e.TimeStamp)
                    .HasMaxLength(20)
                    .UseCollation("SQL_Latin1_General_CP437_BIN");
            });

            modelBuilder.Entity<Temps>(entity =>
            {
                entity.HasIndex(e => e.Local, "Index_1");

                entity.HasIndex(e => e.Id, "Index_Id")
                    .IsUnique();

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
                entity.HasIndex(e => e.Guid, "Id_Global")
                    .IsUnique();

                entity.HasIndex(e => e.Codigo, "Index_1")
                    .IsUnique();

                entity.HasIndex(e => e.IdPerfil, "Index_2");

                entity.HasIndex(e => e.Id, "Index_Id")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .UseCollation("SQL_Latin1_General_CP437_BIN");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.Guid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(newid())")
                    .UseCollation("SQL_Latin1_General_CP437_BIN");

                entity.Property(e => e.Nombre)
                    .IsRequired()
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
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
