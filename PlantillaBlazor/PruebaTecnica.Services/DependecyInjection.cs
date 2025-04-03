using Hangfire;
using Hangfire.SqlServer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PruebaTecnica.Domain.Common.Options.AppConfig;
using PruebaTecnica.Domain.Common.Options.Email;
using PruebaTecnica.Services.Implementations.Auditoria;
using PruebaTecnica.Services.Implementations.Email;
using PruebaTecnica.Services.Implementations.Encrypt;
using PruebaTecnica.Services.Implementations.Messages;
using PruebaTecnica.Services.Implementations.Otp;
using PruebaTecnica.Services.Implementations.Parametrizacion;
using PruebaTecnica.Services.Implementations.Perfilamiento;
using PruebaTecnica.Services.Implementations.Prueba;
using PruebaTecnica.Services.Implementations.Registraduria;
using PruebaTecnica.Services.Interfaces.Auditoria;
using PruebaTecnica.Services.Interfaces.Email;
using PruebaTecnica.Services.Interfaces.Encrypt;
using PruebaTecnica.Services.Interfaces.Messages;
using PruebaTecnica.Services.Interfaces.Otp;
using PruebaTecnica.Services.Interfaces.Parametrizacion;
using PruebaTecnica.Services.Interfaces.Perfilamiento;
using PruebaTecnica.Services.Interfaces.Prueba;

namespace PruebaTecnica.Services
{
    public static class DependecyInjection
    {
        private static IServiceCollection AddOptions(this IServiceCollection services)
        {
            //SMTP Configurations/Options
            services.ConfigureOptions<SmtpOptionsSetup>();

            //App config
            services.ConfigureOptions<AppConfigOptionsSetup>();

            return services;
        }
        private static IServiceCollection AddWpp(this IServiceCollection services)
        {
            services.AddScoped<IWhatsappMessageSender, WhatsappMessageSender>();

            services.AddHttpClient<IWhatsappMessageSender, WhatsappMessageSender>((serviceProvider, httpClient) =>
            {
                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer EAACjovydOgcBOwsi1l7o5y61ZA1rPTCTjdmHyFTZBpU8SeuxJRdxOZB7YJfF3SapDd5zwk3r8Q7tkOrkXhGrt0gER92JXOz6iGly71yFhCgXR1jjeZCb9Lq8x3ZAEUhJtk5eQPdQy9XA1FOWXsKJdyRc7DxNQaGqHEUzBYuv04XoOMXHZBVHy9vNuTnoZCqpQlW");
                httpClient.BaseAddress = new Uri("https://graph.facebook.com");
            })
            .ConfigurePrimaryHttpMessageHandler(() =>
            {
                return new SocketsHttpHandler
                {
                    PooledConnectionLifetime = TimeSpan.FromMinutes(5)
                };
            })
            .SetHandlerLifetime(Timeout.InfiniteTimeSpan);

            return services;
        }
        private static IServiceCollection AddSms(this IServiceCollection services)
        {
            services.AddScoped<ISMSMessageSender, SMSMessageSender>();

            services.AddHttpClient<ISMSMessageSender, SMSMessageSender>((serviceProvider, httpClient) =>
            {
                httpClient.DefaultRequestHeaders.Add("Authorization", "Basic RGVzYXJyb2xsb0V4YzpFeGNlbGxlbnRpYW0yMDIxKg==");
                httpClient.BaseAddress = new Uri("https://gtw.nrsgateway.com");
            })
            .ConfigurePrimaryHttpMessageHandler(() =>
            {
                return new SocketsHttpHandler
                {
                    PooledConnectionLifetime = TimeSpan.FromMinutes(5)
                };
            })
            .SetHandlerLifetime(Timeout.InfiniteTimeSpan);

            return services;
        }
        private static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<IAuditoriaService, AuditoriaService>();
            services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<IOtpService, OtpService>();
            services.AddScoped<IEncryptService, EncryptService>();

            #region Parametrizacion
            services.AddScoped<IParametroGeneralService, ParametroGeneralService>();
            #endregion

            #region Perfilamiento
            services.AddScoped<IModuloService, ModuloService>();
            services.AddScoped<IRolService, RolService>();
            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<ISessionService, SessionService>();
            #endregion

            services.AddScoped<IPruebaService, PruebaService>();

            return services;
        }
        private static IServiceCollection AddRegistraduria(this IServiceCollection services)
        {
            services.AddHttpClient<RegistraduriaService>((serviceProvider, httpClient) =>
            {
                httpClient.DefaultRequestHeaders.Add("Authorization", "Basic dXN1X2V4Y2VsbGVudGlhbTprViR1NUtqejJtQVZ0cXlR");
                httpClient.BaseAddress = new Uri("https://recani.olimpiait.com:8083");
            })
            .ConfigurePrimaryHttpMessageHandler(() =>
            {
                return new SocketsHttpHandler
                {
                    PooledConnectionLifetime = TimeSpan.FromMinutes(5)
                };
            })
            .SetHandlerLifetime(Timeout.InfiniteTimeSpan);

            return services;
        }
        private static IServiceCollection AddFluentValidation(this IServiceCollection services)
        {


            return services;
        }
        private static IServiceCollection AddHangfire(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHangfire(gconfiguration => gconfiguration
                        .SetDataCompatibilityLevel(CompatibilityLevel.Version_170)
                        .UseSimpleAssemblyNameTypeSerializer()
                        .UseRecommendedSerializerSettings()
                        .UseSqlServerStorage(configuration.GetConnectionString("DefaultConnection"), new SqlServerStorageOptions
                        {
                            CommandBatchMaxTimeout = TimeSpan.FromMinutes(5),
                            SlidingInvisibilityTimeout = TimeSpan.FromMinutes(5),
                            QueuePollInterval = TimeSpan.Zero,
                            UseRecommendedIsolationLevel = true,
                            DisableGlobalLocks = true,

                        }));

            services.AddHangfireServer(opt => opt.SchedulePollingInterval = TimeSpan.FromSeconds(5));

            return services;
        }
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddOptions();
            services.AddBusinessServices();
            services.AddWpp();
            services.AddSms();
            services.AddRegistraduria();
            services.AddFluentValidation();
            services.AddHangfire(configuration);

            return services;
        }
    }
}
