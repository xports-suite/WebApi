using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Domain.xports.Data.Models
{
    public partial class xports_devContext : DbContext
    {
        public xports_devContext()
        {
        }

        public xports_devContext(DbContextOptions<xports_devContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Company_Address> Company_Address { get; set; }
        public virtual DbSet<Company_Caja> Company_Caja { get; set; }
        public virtual DbSet<Company_Caja_Movimientos> Company_Caja_Movimientos { get; set; }
        public virtual DbSet<Company_Caja_Movimientos_Lin> Company_Caja_Movimientos_Lin { get; set; }
        public virtual DbSet<Company_Company> Company_Company { get; set; }
        public virtual DbSet<Company_DestinoFacturacion> Company_DestinoFacturacion { get; set; }
        public virtual DbSet<Company_Facturas> Company_Facturas { get; set; }
        public virtual DbSet<Company_Facturas_Lin> Company_Facturas_Lin { get; set; }
        public virtual DbSet<Company_Instalaciones_Cab> Company_Instalaciones_Cab { get; set; }
        public virtual DbSet<Company_Instalaciones_Detalle> Company_Instalaciones_Detalle { get; set; }
        public virtual DbSet<Company_Instalaciones_Excepcion> Company_Instalaciones_Excepcion { get; set; }
        public virtual DbSet<Company_Numeradores> Company_Numeradores { get; set; }
        public virtual DbSet<Company_Presupuesto> Company_Presupuesto { get; set; }
        public virtual DbSet<Company_Recibos> Company_Recibos { get; set; }
        public virtual DbSet<Company_Recibos_Detalle> Company_Recibos_Detalle { get; set; }
        public virtual DbSet<Company_Tarifas> Company_Tarifas { get; set; }
        public virtual DbSet<Company_TipoPersonal> Company_TipoPersonal { get; set; }
        public virtual DbSet<Config_Parameter> Config_Parameter { get; set; }
        public virtual DbSet<Deporte_Tiempo> Deporte_Tiempo { get; set; }
        public virtual DbSet<Equipos_Jugadores> Equipos_Jugadores { get; set; }
        public virtual DbSet<Fase_Equipos> Fase_Equipos { get; set; }
        public virtual DbSet<Fase_Grupos> Fase_Grupos { get; set; }
        public virtual DbSet<Grupos_Clasificaciones> Grupos_Clasificaciones { get; set; }
        public virtual DbSet<Grupos_Resultados> Grupos_Resultados { get; set; }
        public virtual DbSet<Instalaciones_Reserva> Instalaciones_Reserva { get; set; }
        public virtual DbSet<Instalaciones_Reserva_Lin> Instalaciones_Reserva_Lin { get; set; }
        public virtual DbSet<Master_AddressType> Master_AddressType { get; set; }
        public virtual DbSet<Master_Area> Master_Area { get; set; }
        public virtual DbSet<Master_ClaseActividad> Master_ClaseActividad { get; set; }
        public virtual DbSet<Master_Country> Master_Country { get; set; }
        public virtual DbSet<Master_Deporte> Master_Deporte { get; set; }
        public virtual DbSet<Master_Estado> Master_Estado { get; set; }
        public virtual DbSet<Master_EstadoRecibo> Master_EstadoRecibo { get; set; }
        public virtual DbSet<Master_Event> Master_Event { get; set; }
        public virtual DbSet<Master_FormasPago> Master_FormasPago { get; set; }
        public virtual DbSet<Master_Help> Master_Help { get; set; }
        public virtual DbSet<Master_Jerarquia_Menus> Master_Jerarquia_Menus { get; set; }
        public virtual DbSet<Master_LogErrores> Master_LogErrores { get; set; }
        public virtual DbSet<Master_NivelDeporte> Master_NivelDeporte { get; set; }
        public virtual DbSet<Master_PartidaPresupuestaria> Master_PartidaPresupuestaria { get; set; }
        public virtual DbSet<Master_Procedimientos> Master_Procedimientos { get; set; }
        public virtual DbSet<Master_ProjectType> Master_ProjectType { get; set; }
        public virtual DbSet<Master_Tiempo> Master_Tiempo { get; set; }
        public virtual DbSet<Master_TipoDeporte> Master_TipoDeporte { get; set; }
        public virtual DbSet<Master_TipoDescuento> Master_TipoDescuento { get; set; }
        public virtual DbSet<Master_TipoEmpresa> Master_TipoEmpresa { get; set; }
        public virtual DbSet<Master_TipoImpuesto> Master_TipoImpuesto { get; set; }
        public virtual DbSet<Master_TipoMovimiento> Master_TipoMovimiento { get; set; }
        public virtual DbSet<Master_TipoPersonal> Master_TipoPersonal { get; set; }
        public virtual DbSet<Master_TipoReserva> Master_TipoReserva { get; set; }
        public virtual DbSet<Master_Traducciones> Master_Traducciones { get; set; }
        public virtual DbSet<Master_Version> Master_Version { get; set; }
        public virtual DbSet<Person_Person> Person_Person { get; set; }
        public virtual DbSet<Productos_Familia> Productos_Familia { get; set; }
        public virtual DbSet<Productos_Producto> Productos_Producto { get; set; }
        public virtual DbSet<Project_Company> Project_Company { get; set; }
        public virtual DbSet<Project_Fase> Project_Fase { get; set; }
        public virtual DbSet<Project_Totales> Project_Totales { get; set; }
        public virtual DbSet<Project_Users> Project_Users { get; set; }
        public virtual DbSet<Security_EventLog> Security_EventLog { get; set; }
        public virtual DbSet<Security_Function> Security_Function { get; set; }
        public virtual DbSet<Security_Profile> Security_Profile { get; set; }
        public virtual DbSet<Security_ProfilePrivilege> Security_ProfilePrivilege { get; set; }
        public virtual DbSet<Security_Terminos> Security_Terminos { get; set; }
        public virtual DbSet<Security_User> Security_User { get; set; }
        public virtual DbSet<Security_UserPrivilege> Security_UserPrivilege { get; set; }
        public virtual DbSet<UserToken> UserToken { get; set; }
        public virtual DbSet<person_UnidadFamiliar> person_UnidadFamiliar { get; set; }
        public virtual DbSet<project_Tarea> project_Tarea { get; set; }
        public virtual DbSet<project_project> project_project { get; set; }

        // Unable to generate entity type for table 'dbo.usuarios.upload'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEmp_Get'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Temp_Users'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Company.Proveedores'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server=217.76.159.85;initial catalog=xports_dev;user id=xports_web;password=Xports_2020;MultipleActiveResultSets=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<Company_Address>(entity =>
            {
                entity.ToTable("Company.Address");

                entity.HasIndex(e => new { e.UID, e.UID_Company, e.UID_AddressType, e.UID_Country })
                    .HasName("UIDS");

                entity.Property(e => e.Ciudad).HasMaxLength(255);

                entity.Property(e => e.CodigoPostal).HasMaxLength(255);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha_Alta).HasColumnType("date");

                entity.Property(e => e.Fecha_Baja).HasColumnType("date");

                entity.Property(e => e.Provincia).HasMaxLength(255);

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Company_Caja>(entity =>
            {
                entity.ToTable("Company.Caja");

                entity.HasIndex(e => new { e.UID_Company, e.Fecha })
                    .HasName("IX_Company.Caja")
                    .IsUnique();

                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(CONVERT([date],getdate(),0))");

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Company_Caja_Movimientos>(entity =>
            {
                entity.ToTable("Company.Caja_Movimientos");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Company_Caja_Movimientos_Lin>(entity =>
            {
                entity.ToTable("Company.Caja_Movimientos_Lin");

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Company_Company>(entity =>
            {
                entity.ToTable("Company.Company");

                entity.HasIndex(e => e.UID)
                    .HasName("Company_UID");

                entity.Property(e => e.Acronimo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CIF).HasMaxLength(50);

                entity.Property(e => e.Fecha_Alta).HasColumnType("date");

                entity.Property(e => e.Fecha_Baja).HasColumnType("date");

                entity.Property(e => e.File_Css)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.File_Logo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Menu).HasMaxLength(4000);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Company_DestinoFacturacion>(entity =>
            {
                entity.ToTable("Company.DestinoFacturacion");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha_Alta).HasColumnType("date");

                entity.Property(e => e.Fecha_Baja).HasColumnType("date");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Company_Facturas>(entity =>
            {
                entity.ToTable("Company.Facturas");

                entity.Property(e => e.Cif).HasMaxLength(50);

                entity.Property(e => e.Direccion).HasMaxLength(500);

                entity.Property(e => e.Fecha_Alta).HasColumnType("date");

                entity.Property(e => e.Fecha_Factura).HasColumnType("date");

                entity.Property(e => e.Importe_Impuesto).HasMaxLength(10);

                entity.Property(e => e.Nombre).HasMaxLength(255);

                entity.Property(e => e.Numerador).HasMaxLength(50);

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Company_Facturas_Lin>(entity =>
            {
                entity.ToTable("Company.Facturas_Lin");

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Company_Instalaciones_Cab>(entity =>
            {
                entity.ToTable("Company.Instalaciones_Cab");

                entity.Property(e => e.id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.H_Contacto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.M_Contacto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.P_Contacto)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.T_Contacto)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.url_Contacto)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Company_Instalaciones_Detalle>(entity =>
            {
                entity.ToTable("Company.Instalaciones_Detalle");

                entity.Property(e => e.id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Abonado_HREF).HasMaxLength(10);

                entity.Property(e => e.Cerrado_HREF).HasMaxLength(10);

                entity.Property(e => e.Dias_Disponibilidad)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Disponible_HREF).HasMaxLength(10);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pendiente_Pago_HREF).HasMaxLength(10);

                entity.Property(e => e.Reservado_HREF).HasMaxLength(10);

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Company_Instalaciones_Excepcion>(entity =>
            {
                entity.ToTable("Company.Instalaciones_Excepcion");

                entity.Property(e => e.id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dias_Excepcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha_Fin).HasColumnType("date");

                entity.Property(e => e.Fecha_Inicio).HasColumnType("date");

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Company_Numeradores>(entity =>
            {
                entity.ToTable("Company.Numeradores");

                entity.Property(e => e.Fecha_Alta).HasColumnType("date");

                entity.Property(e => e.Fecha_Baja).HasColumnType("date");

                entity.Property(e => e.Serie).HasMaxLength(10);

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Company_Presupuesto>(entity =>
            {
                entity.ToTable("Company.Presupuesto");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Company_Recibos>(entity =>
            {
                entity.ToTable("Company.Recibos");

                entity.Property(e => e.FechaPago).HasColumnType("datetime");

                entity.Property(e => e.Fecha_Alta).HasColumnType("date");

                entity.Property(e => e.Fecha_Baja).HasColumnType("date");

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Company_Recibos_Detalle>(entity =>
            {
                entity.ToTable("Company.Recibos_Detalle");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Company_Tarifas>(entity =>
            {
                entity.ToTable("Company.Tarifas");

                entity.Property(e => e.Descripcion).HasMaxLength(255);

                entity.Property(e => e.Fecha_Alta).HasColumnType("date");

                entity.Property(e => e.Fecha_Baja).HasColumnType("date");

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Company_TipoPersonal>(entity =>
            {
                entity.ToTable("Company.TipoPersonal");

                entity.Property(e => e.id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Config_Parameter>(entity =>
            {
                entity.ToTable("Config.Parameter");

                entity.HasIndex(e => e.Parameter)
                    .HasName("Config.Parameter");

                entity.HasIndex(e => new { e.UID, e.UID_COMPANY })
                    .HasName("UIDS");

                entity.Property(e => e.Finalidad)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Parameter)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Valor)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Deporte_Tiempo>(entity =>
            {
                entity.ToTable("Deporte.Tiempo");

                entity.Property(e => e.FechaDesde).HasColumnType("date");

                entity.Property(e => e.Fechahasta).HasColumnType("date");

                entity.Property(e => e.Importe_Equipo).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Importe_Usuario).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Equipos_Jugadores>(entity =>
            {
                entity.ToTable("Equipos.Jugadores");

                entity.Property(e => e.Apodo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAlta)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaBaja).HasColumnType("datetime");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Fase_Equipos>(entity =>
            {
                entity.ToTable("Fase.Equipos");

                entity.Property(e => e.Color_1e)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Color_2e)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.D_Desde_Hasta)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Disponibilidad_D)
                    .IsRequired()
                    .HasDefaultValueSql("('True')");

                entity.Property(e => e.Disponibilidad_J)
                    .IsRequired()
                    .HasDefaultValueSql("('True')");

                entity.Property(e => e.Disponibilidad_L)
                    .IsRequired()
                    .HasDefaultValueSql("('True')");

                entity.Property(e => e.Disponibilidad_M)
                    .IsRequired()
                    .HasDefaultValueSql("('True')");

                entity.Property(e => e.Disponibilidad_S)
                    .IsRequired()
                    .HasDefaultValueSql("('True')");

                entity.Property(e => e.Disponibilidad_V)
                    .IsRequired()
                    .HasDefaultValueSql("('True')");

                entity.Property(e => e.Disponibilidad_X)
                    .IsRequired()
                    .HasDefaultValueSql("('True')");

                entity.Property(e => e.FechaAlta)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaBaja).HasColumnType("datetime");

                entity.Property(e => e.J_Desde_Hasta)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.L_Desde_Hasta)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.M_Desde_Hasta)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.S_Desde_Hasta)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.V_Desde_Hasta)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.X_Desde_Hasta)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Fase_Grupos>(entity =>
            {
                entity.ToTable("Fase.Grupos");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Grupos_Clasificaciones>(entity =>
            {
                entity.ToTable("Grupos.Clasificaciones");

                entity.Property(e => e.Fecha_Actualizacion)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Grupos_Resultados>(entity =>
            {
                entity.ToTable("Grupos.Resultados");

                entity.Property(e => e.Fecha_Registro)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Fecha_Resultado).HasColumnType("datetime");

                entity.Property(e => e.Partido_Reportado)
                    .IsRequired()
                    .HasDefaultValueSql("('False')");

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Instalaciones_Reserva>(entity =>
            {
                entity.ToTable("Instalaciones.Reserva");

                entity.Property(e => e.FechaAlta)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaAnulacion).HasColumnType("datetime");

                entity.Property(e => e.FechaReserva).HasColumnType("datetime");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Instalaciones_Reserva_Lin>(entity =>
            {
                entity.ToTable("Instalaciones.Reserva_Lin");

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Master_AddressType>(entity =>
            {
                entity.ToTable("Master.AddressType");

                entity.HasIndex(e => e.UID)
                    .HasName("UIDS");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Fecha_Alta).HasColumnType("date");

                entity.Property(e => e.Fecha_Baja).HasColumnType("date");

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Master_Area>(entity =>
            {
                entity.ToTable("Master.Area");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha_Alta).HasColumnType("date");

                entity.Property(e => e.Fecha_Baja).HasColumnType("date");

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Master_ClaseActividad>(entity =>
            {
                entity.ToTable("Master.ClaseActividad");

                entity.Property(e => e.Acronimo).HasColumnType("text");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha_Alta).HasColumnType("date");

                entity.Property(e => e.Fecha_Baja).HasColumnType("date");

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Master_Country>(entity =>
            {
                entity.ToTable("Master.Country");

                entity.HasIndex(e => e.UID)
                    .HasName("UIDS");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Continente)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion_eng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion_es)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha_Alta).HasColumnType("date");

                entity.Property(e => e.Fecha_Baja).HasColumnType("date");

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Master_Deporte>(entity =>
            {
                entity.ToTable("Master.Deporte");

                entity.Property(e => e.Descripcion).HasMaxLength(255);

                entity.Property(e => e.Fecha_Alta).HasColumnType("date");

                entity.Property(e => e.Fecha_Baja).HasColumnType("date");

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Master_Estado>(entity =>
            {
                entity.ToTable("Master.Estado");

                entity.Property(e => e.Descripcion).HasMaxLength(255);

                entity.Property(e => e.Fecha_Alta).HasColumnType("date");

                entity.Property(e => e.Fecha_Baja).HasColumnType("date");

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Master_EstadoRecibo>(entity =>
            {
                entity.ToTable("Master.EstadoRecibo");

                entity.Property(e => e.Descripcion).HasMaxLength(255);

                entity.Property(e => e.Fecha_Alta).HasColumnType("date");

                entity.Property(e => e.Fecha_Baja).HasColumnType("date");

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Master_Event>(entity =>
            {
                entity.ToTable("Master.Event");

                entity.Property(e => e.Acronimo)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha_Alta).HasColumnType("date");

                entity.Property(e => e.Fecha_Baja).HasColumnType("date");

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Master_FormasPago>(entity =>
            {
                entity.ToTable("Master.FormasPago");

                entity.Property(e => e.Descripcion).HasMaxLength(255);

                entity.Property(e => e.Fecha_Alta).HasColumnType("date");

                entity.Property(e => e.Fecha_Baja).HasColumnType("date");

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Master_Help>(entity =>
            {
                entity.ToTable("Master.Help");

                entity.Property(e => e.Cabecera)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Fecha_Alta).HasColumnType("date");

                entity.Property(e => e.Fecha_Baja).HasColumnType("date");
            });

            modelBuilder.Entity<Master_Jerarquia_Menus>(entity =>
            {
                entity.ToTable("Master.Jerarquia_Menus");

                entity.Property(e => e.Icono).HasMaxLength(50);

                entity.Property(e => e.Jerarquia).HasMaxLength(255);

                entity.Property(e => e.Menu).HasMaxLength(255);

                entity.Property(e => e.Orden).HasMaxLength(255);

                entity.Property(e => e.Perfil).HasMaxLength(255);

                entity.Property(e => e.Url).HasMaxLength(255);
            });

            modelBuilder.Entity<Master_LogErrores>(entity =>
            {
                entity.ToTable("Master.LogErrores");

                entity.Property(e => e.dt_Error_date).HasColumnType("datetime");

                entity.Property(e => e.vc_Error_detail).IsUnicode(false);

                entity.Property(e => e.vc_Error_message).IsUnicode(false);

                entity.Property(e => e.vc_Error_procedure)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Master_NivelDeporte>(entity =>
            {
                entity.ToTable("Master.NivelDeporte");

                entity.Property(e => e.Descripcion).HasMaxLength(255);

                entity.Property(e => e.Fecha_Alta).HasColumnType("date");

                entity.Property(e => e.Fecha_Baja).HasColumnType("date");

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Master_PartidaPresupuestaria>(entity =>
            {
                entity.ToTable("Master.PartidaPresupuestaria");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha_Alta).HasColumnType("date");

                entity.Property(e => e.Fecha_Baja).HasColumnType("date");

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Master_Procedimientos>(entity =>
            {
                entity.HasKey(e => new { e.vc_Procedimiento, e.dt_Fecha_revision })
                    .HasName("PK_Master_Procedimientos");

                entity.ToTable("Master.Procedimientos");

                entity.Property(e => e.vc_Procedimiento)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.dt_Fecha_revision).HasColumnType("datetime");

                entity.Property(e => e.vc_Comentario)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.vc_Descripcion).HasMaxLength(500);
            });

            modelBuilder.Entity<Master_ProjectType>(entity =>
            {
                entity.ToTable("Master.ProjectType");

                entity.Property(e => e.Color_HREF)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha_Alta).HasColumnType("date");

                entity.Property(e => e.Fecha_Baja).HasColumnType("date");

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Master_Tiempo>(entity =>
            {
                entity.ToTable("Master.Tiempo");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha_Alta).HasColumnType("date");

                entity.Property(e => e.Fecha_Baja).HasColumnType("date");

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Master_TipoDeporte>(entity =>
            {
                entity.ToTable("Master.TipoDeporte");

                entity.Property(e => e.Descripcion).HasMaxLength(255);

                entity.Property(e => e.Fecha_Alta).HasColumnType("date");

                entity.Property(e => e.Fecha_Baja).HasColumnType("date");

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Master_TipoDescuento>(entity =>
            {
                entity.ToTable("Master.TipoDescuento");

                entity.Property(e => e.Descripcion).HasMaxLength(255);

                entity.Property(e => e.Fecha_Alta).HasColumnType("date");

                entity.Property(e => e.Fecha_Baja).HasColumnType("date");

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Master_TipoEmpresa>(entity =>
            {
                entity.ToTable("Master.TipoEmpresa");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Fecha_Alta).HasColumnType("date");

                entity.Property(e => e.Fecha_Baja).HasColumnType("date");

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Master_TipoImpuesto>(entity =>
            {
                entity.ToTable("Master.TipoImpuesto");

                entity.Property(e => e.Descripcion).HasMaxLength(255);

                entity.Property(e => e.Fecha_Alta).HasColumnType("date");

                entity.Property(e => e.Fecha_Baja).HasColumnType("date");

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Master_TipoMovimiento>(entity =>
            {
                entity.ToTable("Master.TipoMovimiento");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha_Alta).HasColumnType("date");

                entity.Property(e => e.Fecha_Baja).HasColumnType("date");

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Master_TipoPersonal>(entity =>
            {
                entity.ToTable("Master.TipoPersonal");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha_Alta).HasColumnType("date");

                entity.Property(e => e.Fecha_Baja).HasColumnType("date");

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Master_TipoReserva>(entity =>
            {
                entity.ToTable("Master.TipoReserva");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha_Alta).HasColumnType("date");

                entity.Property(e => e.Fecha_Baja).HasColumnType("date");

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Master_Traducciones>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK_master.text");

                entity.ToTable("Master.Traducciones");

                entity.HasIndex(e => e.Code)
                    .HasName("CODIGO_TEXTO");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ENG)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ES)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Master_Version>(entity =>
            {
                entity.HasKey(e => e.UID)
                    .HasName("PK_master.Version");

                entity.ToTable("Master.Version");

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Descripcion).HasMaxLength(255);

                entity.Property(e => e.FechaVersion).HasColumnType("datetime");

                entity.Property(e => e.Version).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Person_Person>(entity =>
            {
                entity.ToTable("Person.Person");

                entity.HasIndex(e => e.UID)
                    .HasName("Person_UIDs");

                entity.HasIndex(e => new { e.UID_COMPANY, e.UID_DELEGACION, e.UID })
                    .HasName("_dta_index_person.Person_7_1314819746__K3_K27_K2");

                entity.HasIndex(e => new { e.id, e.Code, e.Nombre, e.Sexo, e.DNI, e.FechaNacimiento, e.Nacionalidad, e.UID_TIPOPERSONAL, e.Ciudad, e.Provincia, e.CodigoPostal, e.Titulacion, e.UID_DELEGACION, e.Direccion, e.Foto, e.Telefono, e.Telefono2, e.Email, e.Talla, e.UID_COMPANY, e.UID, e.Apellidos })
                    .HasName("_dta_index_person.Person_7_1314819746__K3_K2_K6_1_4_5_7_8_9_10_11_12_13_14_15_16_17_19_20_21_22_23_24_25_26_27");

                entity.Property(e => e.Apellidos).HasMaxLength(255);

                entity.Property(e => e.Ciudad).HasMaxLength(255);

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CodigoPostal).HasMaxLength(10);

                entity.Property(e => e.DNI)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion).HasMaxLength(255);

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.FechaNacimiento).HasColumnType("date");

                entity.Property(e => e.Fecha_Alta).HasColumnType("date");

                entity.Property(e => e.Fecha_Baja).HasColumnType("date");

                entity.Property(e => e.Foto).HasMaxLength(255);

                entity.Property(e => e.Nacionalidad)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre).HasMaxLength(255);

                entity.Property(e => e.Num_Cuenta)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Provincia).HasMaxLength(255);

                entity.Property(e => e.Sexo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.Talla)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono).HasMaxLength(15);

                entity.Property(e => e.Telefono2).HasMaxLength(15);

                entity.Property(e => e.Titulacion)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Productos_Familia>(entity =>
            {
                entity.ToTable("Productos.Familia");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha_Alta).HasColumnType("date");

                entity.Property(e => e.Fecha_Baja).HasColumnType("date");
            });

            modelBuilder.Entity<Productos_Producto>(entity =>
            {
                entity.ToTable("Productos.Producto");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha_Alta).HasColumnType("date");

                entity.Property(e => e.Fecha_Baja).HasColumnType("date");

                entity.Property(e => e.Referencia)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Project_Company>(entity =>
            {
                entity.ToTable("Project.Company");

                entity.HasIndex(e => new { e.UID_PROJECT, e.UID_COMPANY })
                    .HasName("IX_Project.Company")
                    .IsUnique();

                entity.Property(e => e.id).ValueGeneratedNever();

                entity.Property(e => e.Lider).HasMaxLength(1);

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Project_Fase>(entity =>
            {
                entity.ToTable("Project.Fase");

                entity.Property(e => e.D_Desde_Hasta)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha_Fin_Plan).HasColumnType("datetime");

                entity.Property(e => e.Fecha_Fin_Real).HasColumnType("datetime");

                entity.Property(e => e.Fecha_Inicio_Plan).HasColumnType("datetime");

                entity.Property(e => e.Fecha_Inicio_Real).HasColumnType("datetime");

                entity.Property(e => e.J_Desde_Hasta)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.L_Desde_Hasta)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.M_Desde_Hasta)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre).HasMaxLength(255);

                entity.Property(e => e.S_Desde_Hasta)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.V_Desde_Hasta)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.X_Desde_Hasta)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Project_Totales>(entity =>
            {
                entity.ToTable("Project.Totales");

                entity.HasIndex(e => new { e.Importe_Pto, e.Importe_Incurrido, e.UID_PROJECTCOMPANY, e.Ejercicio, e.Estipo })
                    .HasName("_dta_index_Project.Totales_7_1112391032__K3_K6_K21_7_8");

                entity.Property(e => e.id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Importe_Admin_Estado1)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Importe_Admin_Estado2)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Importe_Admin_Estado3)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Importe_Admin_Estado4)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Importe_Admin_Incurrido).HasColumnType("money");

                entity.Property(e => e.Importe_Admin_Pto).HasColumnType("money");

                entity.Property(e => e.Importe_Estado1).HasColumnType("money");

                entity.Property(e => e.Importe_Estado2).HasColumnType("money");

                entity.Property(e => e.Importe_Estado3).HasColumnType("money");

                entity.Property(e => e.Importe_Estado4).HasColumnType("money");

                entity.Property(e => e.Importe_Incurrido).HasColumnType("money");

                entity.Property(e => e.Importe_Otras_Estado1)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Importe_Otras_Estado2)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Importe_Otras_Estado3)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Importe_Otras_Estado4)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Importe_Otras_Incurrido).HasColumnType("money");

                entity.Property(e => e.Importe_Otras_Pto).HasColumnType("money");

                entity.Property(e => e.Importe_Pto).HasColumnType("money");

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Project_Users>(entity =>
            {
                entity.ToTable("Project.Users");

                entity.HasIndex(e => new { e.UID_PROJECTCOMPANY, e.UID_USER })
                    .HasName("IX_Project.Users")
                    .IsUnique();

                entity.Property(e => e.id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Security_EventLog>(entity =>
            {
                entity.ToTable("Security.EventLog");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Evento).HasMaxLength(50);

                entity.Property(e => e.Fecha_Registro).HasColumnType("datetime");

                entity.Property(e => e.IPClient).HasMaxLength(20);

                entity.Property(e => e.Tabla).HasMaxLength(50);

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Security_Function>(entity =>
            {
                entity.ToTable("Security.Function");

                entity.Property(e => e.Activo).HasDefaultValueSql("((1))");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Fecha_Alta).HasColumnType("date");

                entity.Property(e => e.Fecha_Baja).HasColumnType("date");

                entity.Property(e => e.Icono).HasMaxLength(50);

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Url).HasMaxLength(255);
            });

            modelBuilder.Entity<Security_Profile>(entity =>
            {
                entity.ToTable("Security.Profile");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Fecha_Alta).HasColumnType("date");

                entity.Property(e => e.Fecha_Baja).HasColumnType("date");

                entity.Property(e => e.Nivel).HasDefaultValueSql("((99))");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Security_ProfilePrivilege>(entity =>
            {
                entity.ToTable("Security.ProfilePrivilege");

                entity.HasIndex(e => new { e.Activo, e.UID_FUNCTION, e.UID_PROFILE })
                    .HasName("_dta_index_security.ProfilePrivilege_7_1607676775__K4_K3_5");

                entity.HasIndex(e => new { e.UID, e.UID_PROFILE, e.UID_FUNCTION })
                    .HasName("ProfilePrivilege_UIDS");

                entity.HasIndex(e => new { e.UID, e.Permisos, e.Activo, e.UID_PROFILE, e.UID_FUNCTION })
                    .HasName("_dta_index_security.ProfilePrivilege_7_1607676775__K5_K3_K4_2_7");

                entity.Property(e => e.Activo)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Fecha_Alta).HasColumnType("date");

                entity.Property(e => e.Fecha_Baja).HasColumnType("date");

                entity.Property(e => e.Permisos).HasDefaultValueSql("((1))");

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Security_Terminos>(entity =>
            {
                entity.ToTable("Security.Terminos");

                entity.Property(e => e.Fecha_Alta).HasColumnType("datetime");

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Security_User>(entity =>
            {
                entity.ToTable("Security.User");

                entity.Property(e => e.Activo)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Fecha_Alta).HasColumnType("date");

                entity.Property(e => e.Fecha_Baja).HasColumnType("date");

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Security_UserPrivilege>(entity =>
            {
                entity.ToTable("Security.UserPrivilege");

                entity.Property(e => e.id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Activo).HasDefaultValueSql("((1))");

                entity.Property(e => e.Fecha_Alta).HasColumnType("date");

                entity.Property(e => e.Fecha_Baja).HasColumnType("date");

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<UserToken>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.RefresToken).HasMaxLength(450);

                entity.Property(e => e.Token).HasMaxLength(450);

                entity.Property(e => e.User_Id)
                    .IsRequired()
                    .HasMaxLength(450);
            });

            modelBuilder.Entity<person_UnidadFamiliar>(entity =>
            {
                entity.ToTable("person.UnidadFamiliar");

                entity.HasIndex(e => e.UID_PERSON)
                    .HasName("IX_person.UnidadFamiliar")
                    .IsUnique();

                entity.Property(e => e.id).ValueGeneratedNever();

                entity.Property(e => e.Fecha_Alta).HasColumnType("date");

                entity.Property(e => e.Fecha_Baja).HasColumnType("date");
            });

            modelBuilder.Entity<project_Tarea>(entity =>
            {
                entity.ToTable("project.Tarea");

                entity.Property(e => e.id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Fecha_Fin_Plan).HasColumnType("datetime");

                entity.Property(e => e.Fecha_Fin_Real).HasColumnType("datetime");

                entity.Property(e => e.Fecha_Inicio_Plan).HasColumnType("datetime");

                entity.Property(e => e.Fecha_Inicio_Real).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Secuencia).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ts).IsRowVersion();
            });

            modelBuilder.Entity<project_project>(entity =>
            {
                entity.ToTable("project.project");

                entity.Property(e => e.Acronimo)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionCorta)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha_Fin_Plan).HasColumnType("datetime");

                entity.Property(e => e.Fecha_Fin_Plan_FT).HasColumnType("datetime");

                entity.Property(e => e.Fecha_Fin_Real).HasColumnType("datetime");

                entity.Property(e => e.Fecha_Inicio_Plan).HasColumnType("datetime");

                entity.Property(e => e.Fecha_Inicio_Plan_FT).HasColumnType("datetime");

                entity.Property(e => e.Fecha_Inicio_Real).HasColumnType("datetime");

                entity.Property(e => e.File_Logo).HasMaxLength(255);

                entity.Property(e => e.Titulo)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");
            });
        }
    }
}
