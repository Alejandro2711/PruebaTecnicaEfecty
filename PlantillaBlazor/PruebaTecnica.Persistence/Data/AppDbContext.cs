using Microsoft.EntityFrameworkCore;
using PruebaTecnica.Domain.Entities.Auditoria;
using PruebaTecnica.Domain.Entities.Parametrizacion;
using PruebaTecnica.Domain.Entities.Perfilamiento;
using PruebaTecnica.Domain.Entities.Prueba;
using PruebaTecnica.Persistence.Data.TablesConfigurations.Auditoria;
using PruebaTecnica.Persistence.Data.TablesConfigurations.Parametrizacion;
using PruebaTecnica.Persistence.Data.TablesConfigurations.Perfilamiento;
using PruebaTecnica.Persistence.Data.TablesConfigurations.Prueba;

namespace PruebaTecnica.Persistence.Data
{
    /// <summary>
    /// DbContext que gestiona todas las operaciones de base de datos del aplicativo
    /// </summary>
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        #region Perfilamiento

        public DbSet<Modulo> Modulos { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<RolModulo> RolModulo { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<SolicitudRecuperacionClave> SolicitudesRecuperacionClave { get; set; }
        public DbSet<AuditoriaLoginUsuario> AuditoriaLoginUsuario { get; set; }
        public DbSet<Session> Sessions { get; set; }

        #endregion

        #region Auditoria

        public DbSet<AuditoriaDescargaArchivo> AuditoriaDescargaArchivos { get; set; }
        public DbSet<AuditoriaEnvioEmail> AuditoriaEnvioEmail { get; set; }
        public DbSet<AuditoriaAdjuntoEmail> AuditoriaAdjuntosEmail { get; set; }
        public DbSet<AuditoriaNavegacion> AuditoriaNavegacion { get; set; }
        public DbSet<AuditoriaOtp> AuditoriaOtp { get; set; }
        public DbSet<AuditoriaEnvioSMS> AuditoriaEnvioSMS { get; set; }
        public DbSet<AuditoriaEnvioWpp> AuditoriaEnvioWpp { get; set; }
        public DbSet<AuditoriaEvento> AuditoriaEventos { get; set; }
        public DbSet<AuditoriaConsumoRegistraduria> AuditoriaConsumoRegistraduria { get; set; }

        #endregion

        #region Parametrizacion

        public DbSet<ParametroGeneral> ParametrosGenerales { get; set; }
        public DbSet<ParametroDetallado> ParametrosDetallados { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Ciudad> Ciudades { get; set; }

        #endregion

        public DbSet<PruebaModel> Pruebas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Perfilamiento

            modelBuilder.ApplyConfiguration(new ModuloConfig());
            modelBuilder.ApplyConfiguration(new RolConfig());
            modelBuilder.ApplyConfiguration(new RolModuloConfig());
            modelBuilder.ApplyConfiguration(new UsuarioConfig());
            modelBuilder.ApplyConfiguration(new SolicitudRecuperacionClaveConfig());
            modelBuilder.ApplyConfiguration(new AuditoriaLoginUsuarioConfig());
            modelBuilder.ApplyConfiguration(new AuditoriaEnvioSMSConfig());
            modelBuilder.ApplyConfiguration(new SessionsConfig());

            #endregion

            #region Auditoria

            modelBuilder.ApplyConfiguration(new AuditoriaDescargaArchivosConfig());
            modelBuilder.ApplyConfiguration(new AuditoriaEnvioEmailConfig());
            modelBuilder.ApplyConfiguration(new AuditoriaAdjuntoEmailConfig());
            modelBuilder.ApplyConfiguration(new AuditoriaNavegacionConfig());
            modelBuilder.ApplyConfiguration(new AuditoriaOtpConfig());
            modelBuilder.ApplyConfiguration(new AuditoriaEnvioSMSConfig());
            modelBuilder.ApplyConfiguration(new AuditoriaEnvioWppConfig());
            modelBuilder.ApplyConfiguration(new AuditoriaEventosConfig());
            modelBuilder.ApplyConfiguration(new AuditoriaConsumoRegistraduriaConfig());

            #endregion

            #region Parametrizacion

            modelBuilder.ApplyConfiguration(new PGeneralConfig());
            modelBuilder.ApplyConfiguration(new PDetalladoConfig());
            modelBuilder.ApplyConfiguration(new DepartamentoConfig());
            modelBuilder.ApplyConfiguration(new CiudadConfig());

            #endregion

            modelBuilder.ApplyConfiguration(new PruebaConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}
