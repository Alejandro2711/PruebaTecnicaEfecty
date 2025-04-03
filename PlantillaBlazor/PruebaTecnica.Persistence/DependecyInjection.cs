using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using PruebaTecnica.Domain.Common.Options.Database;
using PruebaTecnica.Persistence.Data;
using PruebaTecnica.Persistence.Repositories.Implementations.Auditoria;
using PruebaTecnica.Persistence.Repositories.Implementations.Otp;
using PruebaTecnica.Persistence.Repositories.Implementations.Parametrizacion;
using PruebaTecnica.Persistence.Repositories.Implementations.Perfilamiento;
using PruebaTecnica.Persistence.Repositories.Implementations.Prueba;
using PruebaTecnica.Persistence.Repositories.Interfaces.Auditoria;
using PruebaTecnica.Persistence.Repositories.Interfaces.Otp;
using PruebaTecnica.Persistence.Repositories.Interfaces.Parametrizacion;
using PruebaTecnica.Persistence.Repositories.Interfaces.Perfilamiento;
using PruebaTecnica.Persistence.Repositories.Interfaces.Prueba;

namespace PruebaTecnica.Persistence
{
    public static class DependecyInjection
    {
        private static IServiceCollection AddEFCore(this IServiceCollection services, IConfiguration configuration)
        {
            services.ConfigureOptions<DatabaseOptionsSetup>();

            services.AddDbContextFactory<AppDbContext>(
                (serviceProvider, dbContextOptionsBuilder) =>
                {
                    var databaseOptions = serviceProvider.GetService<IOptions<DatabaseOptions>>()!.Value;

                    dbContextOptionsBuilder.UseSqlServer(databaseOptions.ConnectionString, sqlServerOptionsAction =>
                    {
                        sqlServerOptionsAction.EnableRetryOnFailure(databaseOptions.MaxRetryCount);
                        sqlServerOptionsAction.CommandTimeout(databaseOptions.CommandTimeout);
                        sqlServerOptionsAction.MigrationsAssembly(typeof(DependecyInjection).Assembly.FullName);
                    });
                    dbContextOptionsBuilder.EnableDetailedErrors(databaseOptions.EnableDetailedErrors);
                    dbContextOptionsBuilder.EnableSensitiveDataLogging(databaseOptions.EnableSensitiveDataLogging);
                });

            return services;
        }
        private static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IAuditoriaRepository, AuditoriaRepository>();
            services.AddScoped<IOtpRepository, OtpRepository>();
            #region Parametrizacion
            services.AddScoped<IParametroGeneralRepository, ParametroGeneralRepository>();
            services.AddScoped<IParametroDetalladoRepository, ParametroDetalladoRepository>();
            services.AddScoped<ICiudadRepository, CiudadRepository>();
            services.AddScoped<IDepartamentoRepository, DepartamentoRepository>();
            #endregion
            #region Perfilamiento
            services.AddScoped<IModuloRepository, ModuloRepository>();
            services.AddScoped<IRolRepository, RolRepository>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<ISolicitudCambioContraseñaRepository, SolicitudCambioContraseñaRepository>();
            services.AddScoped<ISessionRepository, SessionRepository>();
            #endregion
            services.AddScoped<IPruebaRepository, PruebaRepository>();

            return services;
        }
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            //EF Core
            services.AddEFCore(configuration);

            //Repositories
            services.AddRepositories();

            //Health check
            services.AddHealthChecks()
                    .AddSqlServer(configuration.GetConnectionString("DefaultConnection") ?? throw new Exception("Database conn string is missing"));

            return services;
        }

    }
}
