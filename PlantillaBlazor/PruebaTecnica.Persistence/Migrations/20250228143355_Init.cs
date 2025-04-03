using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PruebaTecnica.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Aud");

            migrationBuilder.EnsureSchema(
                name: "Seg");

            migrationBuilder.EnsureSchema(
                name: "Par");

            migrationBuilder.CreateTable(
                name: "AuditoriaConsumoRegistraduria",
                schema: "Aud",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaInicioConsulta = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaFinConsulta = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StatusCodeRespuesta = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BodyRequest = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JsonResponse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Error = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CedulaConsultada = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IpConsulta = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UsuarioConsulta = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UrlRequest = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodigoErrorCedula = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EstadoCedula = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DepartamentoExpedicionDocumento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaExpedicionDocumento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MunicipioExpedicionDocumento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrimerNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SegundoNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrimerApellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SegundoApellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaAdicion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUltimaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioAdiciono = table.Column<long>(type: "bigint", nullable: true),
                    IdUsuarioUltimaActualizacion = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditoriaConsumoRegistraduria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AuditoriaDescargaArchivos",
                schema: "Aud",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RutaOriginal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RutaDescargada = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreArchivo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExtensionArchivo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PesoArchivo = table.Column<long>(type: "bigint", nullable: false),
                    Usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IpAddress = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    FechaAdicion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUltimaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioAdiciono = table.Column<long>(type: "bigint", nullable: true),
                    IdUsuarioUltimaActualizacion = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditoriaDescargaArchivos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AuditoriaEnvioEmail",
                schema: "Aud",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmailDestinatario = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EmailCC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailBCC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Asunto = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EmailEmisor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MensajeHTML = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FueEnviado = table.Column<bool>(type: "bit", nullable: false),
                    DescripcionError = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pantalla = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Concepto = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NumeroIdentificacionProceso = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Host = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Puerto = table.Column<int>(type: "int", nullable: true),
                    SslEnabled = table.Column<bool>(type: "bit", nullable: true),
                    FechaAdicion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUltimaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioAdiciono = table.Column<long>(type: "bigint", nullable: true),
                    IdUsuarioUltimaActualizacion = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditoriaEnvioEmail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AuditoriaEnvioSMS",
                schema: "Aud",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CelularDestinatario = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Mensaje = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FechaEnvio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FueEnviado = table.Column<bool>(type: "bit", nullable: false),
                    IdentificacionProceso = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Concepto = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Pantalla = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    StatusCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Error = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContenidoRespuesta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContenidoBody = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrlRequest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdicion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUltimaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioAdiciono = table.Column<long>(type: "bigint", nullable: true),
                    IdUsuarioUltimaActualizacion = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditoriaEnvioSMS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AuditoriaEnvioWpp",
                schema: "Aud",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CelularDestinatario = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Mensaje = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FechaEnvio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FueEnviado = table.Column<bool>(type: "bit", nullable: false),
                    IdentificacionProceso = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Concepto = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Pantalla = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    StatusCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Error = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContenidoRespuesta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContenidoBody = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrlRequest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdicion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUltimaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioAdiciono = table.Column<long>(type: "bigint", nullable: true),
                    IdUsuarioUltimaActualizacion = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditoriaEnvioWpp", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AuditoriaNavegacion",
                schema: "Aud",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserAgent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Navegador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VersionNavegador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlataformaNavegador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UrlActual = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Idioma = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CookiesHabilitadas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnchoPantalla = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AltoPantalla = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfundidadColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreSO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VersionSO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Latitud = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Longitud = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IpAddress = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdUsuarioAccion = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsLocationPermitted = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaAdicion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUltimaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioAdiciono = table.Column<long>(type: "bigint", nullable: true),
                    IdUsuarioUltimaActualizacion = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditoriaNavegacion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AuditoriaOtp",
                schema: "Aud",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    FechaValidacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    IdentificacionProceso = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TipoProceso = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    MetodosEnvio = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FechaAdicion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUltimaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioAdiciono = table.Column<long>(type: "bigint", nullable: true),
                    IdUsuarioUltimaActualizacion = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditoriaOtp", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departamento",
                schema: "Par",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Modulo",
                schema: "Seg",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreModulo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TipoModulo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Nivel = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    FechaAdicion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUltimaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioAdiciono = table.Column<long>(type: "bigint", nullable: true),
                    IdUsuarioUltimaActualizacion = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modulo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParametroGeneral",
                schema: "Par",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    FechaAdicion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUltimaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioAdiciono = table.Column<long>(type: "bigint", nullable: true),
                    IdUsuarioUltimaActualizacion = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParametroGeneral", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rol",
                schema: "Seg",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    FechaAdicion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUltimaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioAdiciono = table.Column<long>(type: "bigint", nullable: true),
                    IdUsuarioUltimaActualizacion = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rol", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AuditoriaAdjuntoEmail",
                schema: "Aud",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RutaAbsolutaAdjunto = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NombreAdjunto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdAuditoriaEnvioEmail = table.Column<long>(type: "bigint", nullable: false),
                    FechaAdicion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUltimaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioAdiciono = table.Column<long>(type: "bigint", nullable: true),
                    IdUsuarioUltimaActualizacion = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditoriaAdjuntoEmail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuditoriaAdjuntoEmail_AuditoriaEnvioEmail_IdAuditoriaEnvioEmail",
                        column: x => x.IdAuditoriaEnvioEmail,
                        principalSchema: "Aud",
                        principalTable: "AuditoriaEnvioEmail",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Ciudad",
                schema: "Par",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdDepartamento = table.Column<long>(type: "bigint", nullable: true),
                    CodigoDane = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudad", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ciudad_Departamento_IdDepartamento",
                        column: x => x.IdDepartamento,
                        principalSchema: "Par",
                        principalTable: "Departamento",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ParametroDetallado",
                schema: "Par",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    IdParametroGeneral = table.Column<long>(type: "bigint", nullable: false),
                    FechaAdicion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUltimaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioAdiciono = table.Column<long>(type: "bigint", nullable: true),
                    IdUsuarioUltimaActualizacion = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParametroDetallado", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParametroDetallado_ParametroGeneral_IdParametroGeneral",
                        column: x => x.IdParametroGeneral,
                        principalSchema: "Par",
                        principalTable: "ParametroGeneral",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RolModulo",
                schema: "Seg",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdRol = table.Column<long>(type: "bigint", nullable: false),
                    IdModulo = table.Column<long>(type: "bigint", nullable: false),
                    FechaAdicion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUltimaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioAdiciono = table.Column<long>(type: "bigint", nullable: true),
                    IdUsuarioUltimaActualizacion = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolModulo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RolModulo_Modulo_IdModulo",
                        column: x => x.IdModulo,
                        principalSchema: "Seg",
                        principalTable: "Modulo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RolModulo_Rol_IdRol",
                        column: x => x.IdRol,
                        principalSchema: "Seg",
                        principalTable: "Rol",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                schema: "Seg",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NombreUsuario = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Clave = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IdRol = table.Column<long>(type: "bigint", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    FechaUltimoCambioContraseña = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MustChangePassword = table.Column<bool>(type: "bit", nullable: false),
                    Celular = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsTwoFAEnabled = table.Column<bool>(type: "bit", nullable: false),
                    FechaUltimoIngreso = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TipoUsuario = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FechaAdicion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUltimaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioAdiciono = table.Column<long>(type: "bigint", nullable: true),
                    IdUsuarioUltimaActualizacion = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuario_Rol_IdRol",
                        column: x => x.IdRol,
                        principalSchema: "Seg",
                        principalTable: "Rol",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AuditoriaEventos",
                schema: "Aud",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Accion = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IdUsuarioAccion = table.Column<long>(type: "bigint", nullable: false),
                    IpAddress = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Concepto = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IdentificadorProceso = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FechaAdicion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUltimaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioAdiciono = table.Column<long>(type: "bigint", nullable: true),
                    IdUsuarioUltimaActualizacion = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditoriaEventos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuditoriaEventos_Usuario_IdUsuarioAccion",
                        column: x => x.IdUsuarioAccion,
                        principalSchema: "Seg",
                        principalTable: "Usuario",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AuditoriaLoginUsuario",
                schema: "Seg",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUsuario = table.Column<long>(type: "bigint", nullable: false),
                    FechaLogin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IpLogin = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FechaCierreSesion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IpCierreSesion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MotivoCierreSesion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaAdicion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUltimaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioAdiciono = table.Column<long>(type: "bigint", nullable: true),
                    IdUsuarioUltimaActualizacion = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditoriaLoginUsuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuditoriaLoginUsuario_Usuario_IdUsuario",
                        column: x => x.IdUsuario,
                        principalSchema: "Seg",
                        principalTable: "Usuario",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Session",
                schema: "Seg",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUsuario = table.Column<long>(type: "bigint", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    RememberMe = table.Column<bool>(type: "bit", nullable: false),
                    FechaUltimoIngreso = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaInactivacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Host = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdAuditoriaLogin = table.Column<long>(type: "bigint", nullable: true),
                    IpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoUsuario = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FechaAdicion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUltimaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioAdiciono = table.Column<long>(type: "bigint", nullable: true),
                    IdUsuarioUltimaActualizacion = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Session", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Session_Usuario_IdUsuario",
                        column: x => x.IdUsuario,
                        principalSchema: "Seg",
                        principalTable: "Usuario",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SolicitudRecuperacionClave",
                schema: "Seg",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUsuario = table.Column<long>(type: "bigint", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    FechaFinalizacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IpAccionInicial = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    IpAccionFinal = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    MotivoCambioContraseña = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FechaAdicion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUltimaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioAdiciono = table.Column<long>(type: "bigint", nullable: true),
                    IdUsuarioUltimaActualizacion = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolicitudRecuperacionClave", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SolicitudRecuperacionClave_Usuario_IdUsuario",
                        column: x => x.IdUsuario,
                        principalSchema: "Seg",
                        principalTable: "Usuario",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                schema: "Par",
                table: "Departamento",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 5L, "ANTIOQUIA" },
                    { 8L, "ATLANTICO" },
                    { 11L, "BOGOTA" },
                    { 13L, "BOLIVAR" },
                    { 15L, "BOYACA" },
                    { 17L, "CALDAS" },
                    { 18L, "CAQUETA" },
                    { 19L, "CAUCA" },
                    { 20L, "CESAR" },
                    { 23L, "CORDOBA" },
                    { 25L, "CUNDINAMARCA" },
                    { 27L, "CHOCO" },
                    { 41L, "HUILA" },
                    { 44L, "LA GUAJIRA" },
                    { 47L, "MAGDALENA" },
                    { 50L, "META" },
                    { 52L, "NARIÑO" },
                    { 54L, "N. DE SANTANDER" },
                    { 63L, "QUINDIO" },
                    { 66L, "RISARALDA" },
                    { 68L, "SANTANDER" },
                    { 70L, "SUCRE" },
                    { 73L, "TOLIMA" },
                    { 76L, "VALLE DEL CAUCA" },
                    { 81L, "ARAUCA" },
                    { 85L, "CASANARE" },
                    { 86L, "PUTUMAYO" },
                    { 88L, "SAN ANDRES" },
                    { 91L, "AMAZONAS" },
                    { 94L, "GUAINIA" },
                    { 95L, "GUAVIARE" },
                    { 97L, "VAUPES" },
                    { 99L, "VICHADA" }
                });

            migrationBuilder.InsertData(
                schema: "Seg",
                table: "Modulo",
                columns: new[] { "Id", "FechaAdicion", "FechaUltimaActualizacion", "IdUsuarioAdiciono", "IdUsuarioUltimaActualizacion", "Nivel", "NombreModulo", "TipoModulo" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1L, null, "1", "Configuración", "Módulo" },
                    { 2L, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1L, null, "1.1", "Perfilamiento", "Submódulo" },
                    { 3L, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1L, null, "1.1.1", "Usuarios", "Submódulo" },
                    { 4L, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1L, null, "1.1.2", "Roles", "Submódulo" },
                    { 5L, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1L, null, "1.1.3", "Módulos", "Submódulo" },
                    { 6L, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1L, null, "1.2", "Parametrización", "Submódulo" }
                });

            migrationBuilder.InsertData(
                schema: "Par",
                table: "ParametroGeneral",
                columns: new[] { "Id", "FechaAdicion", "FechaUltimaActualizacion", "IdUsuarioAdiciono", "IdUsuarioUltimaActualizacion", "Nombre" },
                values: new object[] { 1L, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1L, null, "SiNo" });

            migrationBuilder.InsertData(
                schema: "Seg",
                table: "Rol",
                columns: new[] { "Id", "FechaAdicion", "FechaUltimaActualizacion", "IdUsuarioAdiciono", "IdUsuarioUltimaActualizacion", "IsActive", "Nombre" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1L, null, true, "Administrador" },
                    { 100L, new DateTime(2024, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1L, null, true, "Default" }
                });

            migrationBuilder.InsertData(
                schema: "Par",
                table: "Ciudad",
                columns: new[] { "Id", "CodigoDane", "IdDepartamento", "Nombre" },
                values: new object[,]
                {
                    { 1L, "05001", 5L, "MEDELLÍN" },
                    { 2L, "05002", 5L, "ABEJORRAL" },
                    { 3L, "05004", 5L, "ABRIAQUÍ" },
                    { 4L, "05021", 5L, "ALEJANDRÍA" },
                    { 5L, "05030", 5L, "AMAGÁ" },
                    { 6L, "05031", 5L, "AMALFI" },
                    { 7L, "05034", 5L, "ANDES" },
                    { 8L, "05036", 5L, "ANGELÓPOLIS" },
                    { 9L, "05038", 5L, "ANGOSTURA" },
                    { 10L, "05040", 5L, "ANORÍ" },
                    { 11L, "05042", 5L, "SANTA FÉ DE ANTIOQUIA" },
                    { 12L, "05044", 5L, "ANZÁ" },
                    { 13L, "05045", 5L, "APARTADÓ" },
                    { 14L, "05051", 5L, "ARBOLETES" },
                    { 15L, "05055", 5L, "ARGELIA" },
                    { 16L, "05059", 5L, "ARMENIA" },
                    { 17L, "05079", 5L, "BARBOSA" },
                    { 18L, "05086", 5L, "BELMIRA" },
                    { 19L, "05088", 5L, "BELLO" },
                    { 20L, "05091", 5L, "BETANIA" },
                    { 21L, "05093", 5L, "BETULIA" },
                    { 22L, "05101", 5L, "CIUDAD BOLÍVAR" },
                    { 23L, "05107", 5L, "BRICEÑO" },
                    { 24L, "05113", 5L, "BURITICÁ" },
                    { 25L, "05120", 5L, "CÁCERES" },
                    { 26L, "05125", 5L, "CAICEDO" },
                    { 27L, "05129", 5L, "CALDAS" },
                    { 28L, "05134", 5L, "CAMPAMENTO" },
                    { 29L, "05138", 5L, "CAÑASGORDAS" },
                    { 30L, "05142", 5L, "CARACOLÍ" },
                    { 31L, "05145", 5L, "CARAMANTA" },
                    { 32L, "05147", 5L, "CAREPA" },
                    { 33L, "05148", 5L, "EL CARMEN DE VIBORAL" },
                    { 34L, "05150", 5L, "CAROLINA" },
                    { 35L, "05154", 5L, "CAUCASIA" },
                    { 36L, "05172", 5L, "CHIGORODÓ" },
                    { 37L, "05190", 5L, "CISNEROS" },
                    { 38L, "05197", 5L, "COCORNÁ" },
                    { 39L, "05206", 5L, "CONCEPCIÓN" },
                    { 40L, "05209", 5L, "CONCORDIA" },
                    { 41L, "05212", 5L, "COPACABANA" },
                    { 42L, "05234", 5L, "DABEIBA" },
                    { 43L, "05237", 5L, "DONMATÍAS" },
                    { 44L, "05240", 5L, "EBÉJICO" },
                    { 45L, "05250", 5L, "EL BAGRE" },
                    { 46L, "05264", 5L, "ENTRERRÍOS" },
                    { 47L, "05266", 5L, "ENVIGADO" },
                    { 48L, "05282", 5L, "FREDONIA" },
                    { 49L, "05284", 5L, "FRONTINO" },
                    { 50L, "05306", 5L, "GIRALDO" },
                    { 51L, "05308", 5L, "GIRARDOTA" },
                    { 52L, "05310", 5L, "GÓMEZ PLATA" },
                    { 53L, "05313", 5L, "GRANADA" },
                    { 54L, "05315", 5L, "GUADALUPE" },
                    { 55L, "05318", 5L, "GUARNE" },
                    { 56L, "05321", 5L, "GUATAPÉ" },
                    { 57L, "05347", 5L, "HELICONIA" },
                    { 58L, "05353", 5L, "HISPANIA" },
                    { 59L, "05360", 5L, "ITAGÜÍ" },
                    { 60L, "05361", 5L, "ITUANGO" },
                    { 61L, "05364", 5L, "JARDÍN" },
                    { 62L, "05368", 5L, "JERICÓ" },
                    { 63L, "05376", 5L, "LA CEJA" },
                    { 64L, "05380", 5L, "LA ESTRELLA" },
                    { 65L, "05390", 5L, "LA PINTADA" },
                    { 66L, "05400", 5L, "LA UNIÓN" },
                    { 67L, "05411", 5L, "LIBORINA" },
                    { 68L, "05425", 5L, "MACEO" },
                    { 69L, "05440", 5L, "MARINILLA" },
                    { 70L, "05467", 5L, "MONTEBELLO" },
                    { 71L, "05475", 5L, "MURINDÓ" },
                    { 72L, "05480", 5L, "MUTATÁ" },
                    { 73L, "05483", 5L, "NARIÑO" },
                    { 74L, "05490", 5L, "NECOCLÍ" },
                    { 75L, "05495", 5L, "NECHÍ" },
                    { 76L, "05501", 5L, "OLAYA" },
                    { 77L, "05541", 5L, "PEÑOL" },
                    { 78L, "05543", 5L, "PEQUE" },
                    { 79L, "05576", 5L, "PUEBLORRICO" },
                    { 80L, "05579", 5L, "PUERTO BERRÍO" },
                    { 81L, "05585", 5L, "PUERTO NARE" },
                    { 82L, "05591", 5L, "PUERTO TRIUNFO" },
                    { 83L, "05604", 5L, "REMEDIOS" },
                    { 84L, "05607", 5L, "RETIRO" },
                    { 85L, "05615", 5L, "RIONEGRO" },
                    { 86L, "05628", 5L, "SABANALARGA" },
                    { 87L, "05631", 5L, "SABANETA" },
                    { 88L, "05642", 5L, "SALGAR" },
                    { 89L, "05647", 5L, "SAN ANDRÉS DE CUERQUÍA" },
                    { 90L, "05649", 5L, "SAN CARLOS" },
                    { 91L, "05652", 5L, "SAN FRANCISCO" },
                    { 92L, "05656", 5L, "SAN JERÓNIMO" },
                    { 93L, "05658", 5L, "SAN JOSÉ DE LA MONTAÑA" },
                    { 94L, "05659", 5L, "SAN JUAN DE URABÁ" },
                    { 95L, "05660", 5L, "SAN LUIS" },
                    { 96L, "05664", 5L, "SAN PEDRO DE LOS MILAGROS" },
                    { 97L, "05665", 5L, "SAN PEDRO DE URABÁ" },
                    { 98L, "05667", 5L, "SAN RAFAEL" },
                    { 99L, "05670", 5L, "SAN ROQUE" },
                    { 100L, "05674", 5L, "SAN VICENTE FERRER" },
                    { 101L, "05679", 5L, "SANTA BÁRBARA" },
                    { 102L, "05686", 5L, "SANTA ROSA DE OSOS" },
                    { 103L, "05690", 5L, "SANTO DOMINGO" },
                    { 104L, "05697", 5L, "EL SANTUARIO" },
                    { 105L, "05736", 5L, "SEGOVIA" },
                    { 106L, "05756", 5L, "SONSÓN" },
                    { 107L, "05761", 5L, "SOPETRÁN" },
                    { 108L, "05789", 5L, "TÁMESIS" },
                    { 109L, "05790", 5L, "TARAZÁ" },
                    { 110L, "05792", 5L, "TARSO" },
                    { 111L, "05809", 5L, "TITIRIBÍ" },
                    { 112L, "05819", 5L, "TOLEDO" },
                    { 113L, "05837", 5L, "TURBO" },
                    { 114L, "05842", 5L, "URAMITA" },
                    { 115L, "05847", 5L, "URRAO" },
                    { 116L, "05854", 5L, "VALDIVIA" },
                    { 117L, "05856", 5L, "VALPARAÍSO" },
                    { 118L, "05858", 5L, "VEGACHÍ" },
                    { 119L, "05861", 5L, "VENECIA" },
                    { 120L, "05873", 5L, "VIGÍA DEL FUERTE" },
                    { 121L, "05885", 5L, "YALÍ" },
                    { 122L, "05887", 5L, "YARUMAL" },
                    { 123L, "05890", 5L, "YOLOMBÓ" },
                    { 124L, "05893", 5L, "YONDÓ" },
                    { 125L, "05895", 5L, "ZARAGOZA" },
                    { 126L, "08001", 8L, "BARRANQUILLA" },
                    { 127L, "08078", 8L, "BARANOA" },
                    { 128L, "08137", 8L, "CAMPO DE LA CRUZ" },
                    { 129L, "08141", 8L, "CANDELARIA" },
                    { 130L, "08296", 8L, "GALAPA" },
                    { 131L, "08372", 8L, "JUAN DE ACOSTA" },
                    { 132L, "08421", 8L, "LURUACO" },
                    { 133L, "08433", 8L, "MALAMBO" },
                    { 134L, "08436", 8L, "MANATÍ" },
                    { 135L, "08520", 8L, "PALMAR DE VARELA" },
                    { 136L, "08549", 8L, "PIOJÓ" },
                    { 137L, "08558", 8L, "POLONUEVO" },
                    { 138L, "08560", 8L, "PONEDERA" },
                    { 139L, "08573", 8L, "PUERTO COLOMBIA" },
                    { 140L, "08606", 8L, "REPELÓN" },
                    { 141L, "08634", 8L, "SABANAGRANDE" },
                    { 142L, "08638", 8L, "SABANALARGA" },
                    { 143L, "08675", 8L, "SANTA LUCÍA" },
                    { 144L, "08685", 8L, "SANTO TOMÁS" },
                    { 145L, "08758", 8L, "SOLEDAD" },
                    { 146L, "08770", 8L, "SUAN" },
                    { 147L, "08832", 8L, "TUBARÁ" },
                    { 148L, "08849", 8L, "USIACURÍ" },
                    { 149L, "11001", 11L, "BOGOTÁ, D.C." },
                    { 150L, "13001", 13L, "CARTAGENA DE INDIAS" },
                    { 151L, "13006", 13L, "ACHÍ" },
                    { 152L, "13030", 13L, "ALTOS DEL ROSARIO" },
                    { 153L, "13042", 13L, "ARENAL" },
                    { 154L, "13052", 13L, "ARJONA" },
                    { 155L, "13062", 13L, "ARROYOHONDO" },
                    { 156L, "13074", 13L, "BARRANCO DE LOBA" },
                    { 157L, "13140", 13L, "CALAMAR" },
                    { 158L, "13160", 13L, "CANTAGALLO" },
                    { 159L, "13188", 13L, "CICUCO" },
                    { 160L, "13212", 13L, "CÓRDOBA" },
                    { 161L, "13222", 13L, "CLEMENCIA" },
                    { 162L, "13244", 13L, "EL CARMEN DE BOLÍVAR" },
                    { 163L, "13248", 13L, "EL GUAMO" },
                    { 164L, "13268", 13L, "EL PEÑÓN" },
                    { 165L, "13300", 13L, "HATILLO DE LOBA" },
                    { 166L, "13430", 13L, "MAGANGUÉ" },
                    { 167L, "13433", 13L, "MAHATES" },
                    { 168L, "13440", 13L, "MARGARITA" },
                    { 169L, "13442", 13L, "MARÍA LA BAJA" },
                    { 170L, "13458", 13L, "MONTECRISTO" },
                    { 171L, "13468", 13L, "MOMPÓS" },
                    { 172L, "13473", 13L, "MORALES" },
                    { 173L, "13490", 13L, "NOROSÍ" },
                    { 174L, "13549", 13L, "PINILLOS" },
                    { 175L, "13580", 13L, "REGIDOR" },
                    { 176L, "13600", 13L, "RÍO VIEJO" },
                    { 177L, "13620", 13L, "SAN CRISTÓBAL" },
                    { 178L, "13647", 13L, "SAN ESTANISLAO" },
                    { 179L, "13650", 13L, "SAN FERNANDO" },
                    { 180L, "13654", 13L, "SAN JACINTO" },
                    { 181L, "13655", 13L, "SAN JACINTO DEL CAUCA" },
                    { 182L, "13657", 13L, "SAN JUAN NEPOMUCENO" },
                    { 183L, "13667", 13L, "SAN MARTÍN DE LOBA" },
                    { 184L, "13670", 13L, "SAN PABLO" },
                    { 185L, "13673", 13L, "SANTA CATALINA" },
                    { 186L, "13683", 13L, "SANTA ROSA" },
                    { 187L, "13688", 13L, "SANTA ROSA DEL SUR" },
                    { 188L, "13744", 13L, "SIMITÍ" },
                    { 189L, "13760", 13L, "SOPLAVIENTO" },
                    { 190L, "13780", 13L, "TALAIGUA NUEVO" },
                    { 191L, "13810", 13L, "TIQUISIO" },
                    { 192L, "13836", 13L, "TURBACO" },
                    { 193L, "13838", 13L, "TURBANÁ" },
                    { 194L, "13873", 13L, "VILLANUEVA" },
                    { 195L, "13894", 13L, "ZAMBRANO" },
                    { 196L, "15001", 15L, "TUNJA" },
                    { 197L, "15022", 15L, "ALMEIDA" },
                    { 198L, "15047", 15L, "AQUITANIA" },
                    { 199L, "15051", 15L, "ARCABUCO" },
                    { 200L, "15087", 15L, "BELÉN" },
                    { 201L, "15090", 15L, "BERBEO" },
                    { 202L, "15092", 15L, "BETÉITIVA" },
                    { 203L, "15097", 15L, "BOAVITA" },
                    { 204L, "15104", 15L, "BOYACÁ" },
                    { 205L, "15106", 15L, "BRICEÑO" },
                    { 206L, "15109", 15L, "BUENAVISTA" },
                    { 207L, "15114", 15L, "BUSBANZÁ" },
                    { 208L, "15131", 15L, "CALDAS" },
                    { 209L, "15135", 15L, "CAMPOHERMOSO" },
                    { 210L, "15162", 15L, "CERINZA" },
                    { 211L, "15172", 15L, "CHINAVITA" },
                    { 212L, "15176", 15L, "CHIQUINQUIRÁ" },
                    { 213L, "15180", 15L, "CHISCAS" },
                    { 214L, "15183", 15L, "CHITA" },
                    { 215L, "15185", 15L, "CHITARAQUE" },
                    { 216L, "15187", 15L, "CHIVATÁ" },
                    { 217L, "15189", 15L, "CIÉNEGA" },
                    { 218L, "15204", 15L, "CÓMBITA" },
                    { 219L, "15212", 15L, "COPER" },
                    { 220L, "15215", 15L, "CORRALES" },
                    { 221L, "15218", 15L, "COVARACHÍA" },
                    { 222L, "15223", 15L, "CUBARÁ" },
                    { 223L, "15224", 15L, "CUCAITA" },
                    { 224L, "15226", 15L, "CUÍTIVA" },
                    { 225L, "15232", 15L, "CHÍQUIZA" },
                    { 226L, "15236", 15L, "CHIVOR" },
                    { 227L, "15238", 15L, "DUITAMA" },
                    { 228L, "15244", 15L, "EL COCUY" },
                    { 229L, "15248", 15L, "EL ESPINO" },
                    { 230L, "15272", 15L, "FIRAVITOBA" },
                    { 231L, "15276", 15L, "FLORESTA" },
                    { 232L, "15293", 15L, "GACHANTIVÁ" },
                    { 233L, "15296", 15L, "GÁMEZA" },
                    { 234L, "15299", 15L, "GARAGOA" },
                    { 235L, "15317", 15L, "GUACAMAYAS" },
                    { 236L, "15322", 15L, "GUATEQUE" },
                    { 237L, "15325", 15L, "GUAYATÁ" },
                    { 238L, "15332", 15L, "GÜICÁN DE LA SIERRA" },
                    { 239L, "15362", 15L, "IZA" },
                    { 240L, "15367", 15L, "JENESANO" },
                    { 241L, "15368", 15L, "JERICÓ" },
                    { 242L, "15377", 15L, "LABRANZAGRANDE" },
                    { 243L, "15380", 15L, "LA CAPILLA" },
                    { 244L, "15401", 15L, "LA VICTORIA" },
                    { 245L, "15403", 15L, "LA UVITA" },
                    { 246L, "15407", 15L, "VILLA DE LEYVA" },
                    { 247L, "15425", 15L, "MACANAL" },
                    { 248L, "15442", 15L, "MARIPÍ" },
                    { 249L, "15455", 15L, "MIRAFLORES" },
                    { 250L, "15464", 15L, "MONGUA" },
                    { 251L, "15466", 15L, "MONGUÍ" },
                    { 252L, "15469", 15L, "MONIQUIRÁ" },
                    { 253L, "15476", 15L, "MOTAVITA" },
                    { 254L, "15480", 15L, "MUZO" },
                    { 255L, "15491", 15L, "NOBSA" },
                    { 256L, "15494", 15L, "NUEVO COLÓN" },
                    { 257L, "15500", 15L, "OICATÁ" },
                    { 258L, "15507", 15L, "OTANCHE" },
                    { 259L, "15511", 15L, "PACHAVITA" },
                    { 260L, "15514", 15L, "PÁEZ" },
                    { 261L, "15516", 15L, "PAIPA" },
                    { 262L, "15518", 15L, "PAJARITO" },
                    { 263L, "15522", 15L, "PANQUEBA" },
                    { 264L, "15531", 15L, "PAUNA" },
                    { 265L, "15533", 15L, "PAYA" },
                    { 266L, "15537", 15L, "PAZ DE RÍO" },
                    { 267L, "15542", 15L, "PESCA" },
                    { 268L, "15550", 15L, "PISBA" },
                    { 269L, "15572", 15L, "PUERTO BOYACÁ" },
                    { 270L, "15580", 15L, "QUÍPAMA" },
                    { 271L, "15599", 15L, "RAMIRIQUÍ" },
                    { 272L, "15600", 15L, "RÁQUIRA" },
                    { 273L, "15621", 15L, "RONDÓN" },
                    { 274L, "15632", 15L, "SABOYÁ" },
                    { 275L, "15638", 15L, "SÁCHICA" },
                    { 276L, "15646", 15L, "SAMACÁ" },
                    { 277L, "15660", 15L, "SAN EDUARDO" },
                    { 278L, "15664", 15L, "SAN JOSÉ DE PARE" },
                    { 279L, "15667", 15L, "SAN LUIS DE GACENO" },
                    { 280L, "15673", 15L, "SAN MATEO" },
                    { 281L, "15676", 15L, "SAN MIGUEL DE SEMA" },
                    { 282L, "15681", 15L, "SAN PABLO DE BORBUR" },
                    { 283L, "15686", 15L, "SANTANA" },
                    { 284L, "15690", 15L, "SANTA MARÍA" },
                    { 285L, "15693", 15L, "SANTA ROSA DE VITERBO" },
                    { 286L, "15696", 15L, "SANTA SOFÍA" },
                    { 287L, "15720", 15L, "SATIVANORTE" },
                    { 288L, "15723", 15L, "SATIVASUR" },
                    { 289L, "15740", 15L, "SIACHOQUE" },
                    { 290L, "15753", 15L, "SOATÁ" },
                    { 291L, "15755", 15L, "SOCOTÁ" },
                    { 292L, "15757", 15L, "SOCHA" },
                    { 293L, "15759", 15L, "SOGAMOSO" },
                    { 294L, "15761", 15L, "SOMONDOCO" },
                    { 295L, "15762", 15L, "SORA" },
                    { 296L, "15763", 15L, "SOTAQUIRÁ" },
                    { 297L, "15764", 15L, "SORACÁ" },
                    { 298L, "15774", 15L, "SUSACÓN" },
                    { 299L, "15776", 15L, "SUTAMARCHÁN" },
                    { 300L, "15778", 15L, "SUTATENZA" },
                    { 301L, "15790", 15L, "TASCO" },
                    { 302L, "15798", 15L, "TENZA" },
                    { 303L, "15804", 15L, "TIBANÁ" },
                    { 304L, "15806", 15L, "TIBASOSA" },
                    { 305L, "15808", 15L, "TINJACÁ" },
                    { 306L, "15810", 15L, "TIPACOQUE" },
                    { 307L, "15814", 15L, "TOCA" },
                    { 308L, "15816", 15L, "TOGÜÍ" },
                    { 309L, "15820", 15L, "TÓPAGA" },
                    { 310L, "15822", 15L, "TOTA" },
                    { 311L, "15832", 15L, "TUNUNGUÁ" },
                    { 312L, "15835", 15L, "TURMEQUÉ" },
                    { 313L, "15837", 15L, "TUTA" },
                    { 314L, "15839", 15L, "TUTAZÁ" },
                    { 315L, "15842", 15L, "ÚMBITA" },
                    { 316L, "15861", 15L, "VENTAQUEMADA" },
                    { 317L, "15879", 15L, "VIRACACHÁ" },
                    { 318L, "15897", 15L, "ZETAQUIRA" },
                    { 319L, "17001", 17L, "MANIZALES" },
                    { 320L, "17013", 17L, "AGUADAS" },
                    { 321L, "17042", 17L, "ANSERMA" },
                    { 322L, "17050", 17L, "ARANZAZU" },
                    { 323L, "17088", 17L, "BELALCÁZAR" },
                    { 324L, "17174", 17L, "CHINCHINÁ" },
                    { 325L, "17272", 17L, "FILADELFIA" },
                    { 326L, "17380", 17L, "LA DORADA" },
                    { 327L, "17388", 17L, "LA MERCED" },
                    { 328L, "17433", 17L, "MANZANARES" },
                    { 329L, "17442", 17L, "MARMATO" },
                    { 330L, "17444", 17L, "MARQUETALIA" },
                    { 331L, "17446", 17L, "MARULANDA" },
                    { 332L, "17486", 17L, "NEIRA" },
                    { 333L, "17495", 17L, "NORCASIA" },
                    { 334L, "17513", 17L, "PÁCORA" },
                    { 335L, "17524", 17L, "PALESTINA" },
                    { 336L, "17541", 17L, "PENSILVANIA" },
                    { 337L, "17614", 17L, "RIOSUCIO" },
                    { 338L, "17616", 17L, "RISARALDA" },
                    { 339L, "17653", 17L, "SALAMINA" },
                    { 340L, "17662", 17L, "SAMANÁ" },
                    { 341L, "17665", 17L, "SAN JOSÉ" },
                    { 342L, "17777", 17L, "SUPÍA" },
                    { 343L, "17867", 17L, "VICTORIA" },
                    { 344L, "17873", 17L, "VILLAMARÍA" },
                    { 345L, "17877", 17L, "VITERBO" },
                    { 346L, "18001", 18L, "FLORENCIA" },
                    { 347L, "18029", 18L, "ALBANIA" },
                    { 348L, "18094", 18L, "BELÉN DE LOS ANDAQUÍES" },
                    { 349L, "18150", 18L, "CARTAGENA DEL CHAIRÁ" },
                    { 350L, "18205", 18L, "CURILLO" },
                    { 351L, "18247", 18L, "EL DONCELLO" },
                    { 352L, "18256", 18L, "EL PAUJÍL" },
                    { 353L, "18410", 18L, "LA MONTAÑITA" },
                    { 354L, "18460", 18L, "MILÁN" },
                    { 355L, "18479", 18L, "MORELIA" },
                    { 356L, "18592", 18L, "PUERTO RICO" },
                    { 357L, "18610", 18L, "SAN JOSÉ DEL FRAGUA" },
                    { 358L, "18753", 18L, "SAN VICENTE DEL CAGUÁN" },
                    { 359L, "18756", 18L, "SOLANO" },
                    { 360L, "18785", 18L, "SOLITA" },
                    { 361L, "18860", 18L, "VALPARAÍSO" },
                    { 362L, "19001", 19L, "POPAYÁN" },
                    { 363L, "19022", 19L, "ALMAGUER" },
                    { 364L, "19050", 19L, "ARGELIA" },
                    { 365L, "19075", 19L, "BALBOA" },
                    { 366L, "19100", 19L, "BOLÍVAR" },
                    { 367L, "19110", 19L, "BUENOS AIRES" },
                    { 368L, "19130", 19L, "CAJIBÍO" },
                    { 369L, "19137", 19L, "CALDONO" },
                    { 370L, "19142", 19L, "CALOTO" },
                    { 371L, "19212", 19L, "CORINTO" },
                    { 372L, "19256", 19L, "EL TAMBO" },
                    { 373L, "19290", 19L, "FLORENCIA" },
                    { 374L, "19300", 19L, "GUACHENÉ" },
                    { 375L, "19318", 19L, "GUAPI" },
                    { 376L, "19355", 19L, "INZÁ" },
                    { 377L, "19364", 19L, "JAMBALÓ" },
                    { 378L, "19392", 19L, "LA SIERRA" },
                    { 379L, "19397", 19L, "LA VEGA" },
                    { 380L, "19418", 19L, "LÓPEZ DE MICAY" },
                    { 381L, "19450", 19L, "MERCADERES" },
                    { 382L, "19455", 19L, "MIRANDA" },
                    { 383L, "19473", 19L, "MORALES" },
                    { 384L, "19513", 19L, "PADILLA" },
                    { 385L, "19517", 19L, "PÁEZ" },
                    { 386L, "19532", 19L, "PATÍA" },
                    { 387L, "19533", 19L, "PIAMONTE" },
                    { 388L, "19548", 19L, "PIENDAMÓ - TUNÍA" },
                    { 389L, "19573", 19L, "PUERTO TEJADA" },
                    { 390L, "19585", 19L, "PURACÉ" },
                    { 391L, "19622", 19L, "ROSAS" },
                    { 392L, "19693", 19L, "SAN SEBASTIÁN" },
                    { 393L, "19698", 19L, "SANTANDER DE QUILICHAO" },
                    { 394L, "19701", 19L, "SANTA ROSA" },
                    { 395L, "19743", 19L, "SILVIA" },
                    { 396L, "19760", 19L, "SOTARÁ PAISPAMBA" },
                    { 397L, "19780", 19L, "SUÁREZ" },
                    { 398L, "19785", 19L, "SUCRE" },
                    { 399L, "19807", 19L, "TIMBÍO" },
                    { 400L, "19809", 19L, "TIMBIQUÍ" },
                    { 401L, "19821", 19L, "TORIBÍO" },
                    { 402L, "19824", 19L, "TOTORÓ" },
                    { 403L, "19845", 19L, "VILLA RICA" },
                    { 404L, "20001", 20L, "VALLEDUPAR" },
                    { 405L, "20011", 20L, "AGUACHICA" },
                    { 406L, "20013", 20L, "AGUSTÍN CODAZZI" },
                    { 407L, "20032", 20L, "ASTREA" },
                    { 408L, "20045", 20L, "BECERRIL" },
                    { 409L, "20060", 20L, "BOSCONIA" },
                    { 410L, "20175", 20L, "CHIMICHAGUA" },
                    { 411L, "20178", 20L, "CHIRIGUANÁ" },
                    { 412L, "20228", 20L, "CURUMANÍ" },
                    { 413L, "20238", 20L, "EL COPEY" },
                    { 414L, "20250", 20L, "EL PASO" },
                    { 415L, "20295", 20L, "GAMARRA" },
                    { 416L, "20310", 20L, "GONZÁLEZ" },
                    { 417L, "20383", 20L, "LA GLORIA" },
                    { 418L, "20400", 20L, "LA JAGUA DE IBIRICO" },
                    { 419L, "20443", 20L, "MANAURE BALCÓN DEL CESAR" },
                    { 420L, "20517", 20L, "PAILITAS" },
                    { 421L, "20550", 20L, "PELAYA" },
                    { 422L, "20570", 20L, "PUEBLO BELLO" },
                    { 423L, "20614", 20L, "RÍO DE ORO" },
                    { 424L, "20621", 20L, "LA PAZ" },
                    { 425L, "20710", 20L, "SAN ALBERTO" },
                    { 426L, "20750", 20L, "SAN DIEGO" },
                    { 427L, "20770", 20L, "SAN MARTÍN" },
                    { 428L, "20787", 20L, "TAMALAMEQUE" },
                    { 429L, "23001", 23L, "MONTERÍA" },
                    { 430L, "23068", 23L, "AYAPEL" },
                    { 431L, "23079", 23L, "BUENAVISTA" },
                    { 432L, "23090", 23L, "CANALETE" },
                    { 433L, "23162", 23L, "CERETÉ" },
                    { 434L, "23168", 23L, "CHIMÁ" },
                    { 435L, "23182", 23L, "CHINÚ" },
                    { 436L, "23189", 23L, "CIÉNAGA DE ORO" },
                    { 437L, "23300", 23L, "COTORRA" },
                    { 438L, "23350", 23L, "LA APARTADA" },
                    { 439L, "23417", 23L, "LORICA" },
                    { 440L, "23419", 23L, "LOS CÓRDOBAS" },
                    { 441L, "23464", 23L, "MOMIL" },
                    { 442L, "23466", 23L, "MONTELÍBANO" },
                    { 443L, "23500", 23L, "MOÑITOS" },
                    { 444L, "23555", 23L, "PLANETA RICA" },
                    { 445L, "23570", 23L, "PUEBLO NUEVO" },
                    { 446L, "23574", 23L, "PUERTO ESCONDIDO" },
                    { 447L, "23580", 23L, "PUERTO LIBERTADOR" },
                    { 448L, "23586", 23L, "PURÍSIMA DE LA CONCEPCIÓN" },
                    { 449L, "23660", 23L, "SAHAGÚN" },
                    { 450L, "23670", 23L, "SAN ANDRÉS DE SOTAVENTO" },
                    { 451L, "23672", 23L, "SAN ANTERO" },
                    { 452L, "23675", 23L, "SAN BERNARDO DEL VIENTO" },
                    { 453L, "23678", 23L, "SAN CARLOS" },
                    { 454L, "23682", 23L, "SAN JOSÉ DE URÉ" },
                    { 455L, "23686", 23L, "SAN PELAYO" },
                    { 456L, "23807", 23L, "TIERRALTA" },
                    { 457L, "23815", 23L, "TUCHÍN" },
                    { 458L, "23855", 23L, "VALENCIA" },
                    { 459L, "25001", 25L, "AGUA DE DIOS" },
                    { 460L, "25019", 25L, "ALBÁN" },
                    { 461L, "25035", 25L, "ANAPOIMA" },
                    { 462L, "25040", 25L, "ANOLAIMA" },
                    { 463L, "25053", 25L, "ARBELÁEZ" },
                    { 464L, "25086", 25L, "BELTRÁN" },
                    { 465L, "25095", 25L, "BITUIMA" },
                    { 466L, "25099", 25L, "BOJACÁ" },
                    { 467L, "25120", 25L, "CABRERA" },
                    { 468L, "25123", 25L, "CACHIPAY" },
                    { 469L, "25126", 25L, "CAJICÁ" },
                    { 470L, "25148", 25L, "CAPARRAPÍ" },
                    { 471L, "25151", 25L, "CÁQUEZA" },
                    { 472L, "25154", 25L, "CARMEN DE CARUPA" },
                    { 473L, "25168", 25L, "CHAGUANÍ" },
                    { 474L, "25175", 25L, "CHÍA" },
                    { 475L, "25178", 25L, "CHIPAQUE" },
                    { 476L, "25181", 25L, "CHOACHÍ" },
                    { 477L, "25183", 25L, "CHOCONTÁ" },
                    { 478L, "25200", 25L, "COGUA" },
                    { 479L, "25214", 25L, "COTA" },
                    { 480L, "25224", 25L, "CUCUNUBÁ" },
                    { 481L, "25245", 25L, "EL COLEGIO" },
                    { 482L, "25258", 25L, "EL PEÑÓN" },
                    { 483L, "25260", 25L, "EL ROSAL" },
                    { 484L, "25269", 25L, "FACATATIVÁ" },
                    { 485L, "25279", 25L, "FÓMEQUE" },
                    { 486L, "25281", 25L, "FOSCA" },
                    { 487L, "25286", 25L, "FUNZA" },
                    { 488L, "25288", 25L, "FÚQUENE" },
                    { 489L, "25290", 25L, "FUSAGASUGÁ" },
                    { 490L, "25293", 25L, "GACHALÁ" },
                    { 491L, "25295", 25L, "GACHANCIPÁ" },
                    { 492L, "25297", 25L, "GACHETÁ" },
                    { 493L, "25299", 25L, "GAMA" },
                    { 494L, "25307", 25L, "GIRARDOT" },
                    { 495L, "25312", 25L, "GRANADA" },
                    { 496L, "25317", 25L, "GUACHETÁ" },
                    { 497L, "25320", 25L, "GUADUAS" },
                    { 498L, "25322", 25L, "GUASCA" },
                    { 499L, "25324", 25L, "GUATAQUÍ" },
                    { 500L, "25326", 25L, "GUATAVITA" },
                    { 501L, "25328", 25L, "GUAYABAL DE SÍQUIMA" },
                    { 502L, "25335", 25L, "GUAYABETAL" },
                    { 503L, "25339", 25L, "GUTIÉRREZ" },
                    { 504L, "25368", 25L, "JERUSALÉN" },
                    { 505L, "25372", 25L, "JUNÍN" },
                    { 506L, "25377", 25L, "LA CALERA" },
                    { 507L, "25386", 25L, "LA MESA" },
                    { 508L, "25394", 25L, "LA PALMA" },
                    { 509L, "25398", 25L, "LA PEÑA" },
                    { 510L, "25402", 25L, "LA VEGA" },
                    { 511L, "25407", 25L, "LENGUAZAQUE" },
                    { 512L, "25426", 25L, "MACHETÁ" },
                    { 513L, "25430", 25L, "MADRID" },
                    { 514L, "25436", 25L, "MANTA" },
                    { 515L, "25438", 25L, "MEDINA" },
                    { 516L, "25473", 25L, "MOSQUERA" },
                    { 517L, "25483", 25L, "NARIÑO" },
                    { 518L, "25486", 25L, "NEMOCÓN" },
                    { 519L, "25488", 25L, "NILO" },
                    { 520L, "25489", 25L, "NIMAIMA" },
                    { 521L, "25491", 25L, "NOCAIMA" },
                    { 522L, "25506", 25L, "VENECIA" },
                    { 523L, "25513", 25L, "PACHO" },
                    { 524L, "25518", 25L, "PAIME" },
                    { 525L, "25524", 25L, "PANDI" },
                    { 526L, "25530", 25L, "PARATEBUENO" },
                    { 527L, "25535", 25L, "PASCA" },
                    { 528L, "25572", 25L, "PUERTO SALGAR" },
                    { 529L, "25580", 25L, "PULÍ" },
                    { 530L, "25592", 25L, "QUEBRADANEGRA" },
                    { 531L, "25594", 25L, "QUETAME" },
                    { 532L, "25596", 25L, "QUIPILE" },
                    { 533L, "25599", 25L, "APULO" },
                    { 534L, "25612", 25L, "RICAURTE" },
                    { 535L, "25645", 25L, "SAN ANTONIO DEL TEQUENDAMA" },
                    { 536L, "25649", 25L, "SAN BERNARDO" },
                    { 537L, "25653", 25L, "SAN CAYETANO" },
                    { 538L, "25658", 25L, "SAN FRANCISCO" },
                    { 539L, "25662", 25L, "SAN JUAN DE RIOSECO" },
                    { 540L, "25718", 25L, "SASAIMA" },
                    { 541L, "25736", 25L, "SESQUILÉ" },
                    { 542L, "25740", 25L, "SIBATÉ" },
                    { 543L, "25743", 25L, "SILVANIA" },
                    { 544L, "25745", 25L, "SIMIJACA" },
                    { 545L, "25754", 25L, "SOACHA" },
                    { 546L, "25758", 25L, "SOPÓ" },
                    { 547L, "25769", 25L, "SUBACHOQUE" },
                    { 548L, "25772", 25L, "SUESCA" },
                    { 549L, "25777", 25L, "SUPATÁ" },
                    { 550L, "25779", 25L, "SUSA" },
                    { 551L, "25781", 25L, "SUTATAUSA" },
                    { 552L, "25785", 25L, "TABIO" },
                    { 553L, "25793", 25L, "TAUSA" },
                    { 554L, "25797", 25L, "TENA" },
                    { 555L, "25799", 25L, "TENJO" },
                    { 556L, "25805", 25L, "TIBACUY" },
                    { 557L, "25807", 25L, "TIBIRITA" },
                    { 558L, "25815", 25L, "TOCAIMA" },
                    { 559L, "25817", 25L, "TOCANCIPÁ" },
                    { 560L, "25823", 25L, "TOPAIPÍ" },
                    { 561L, "25839", 25L, "UBALÁ" },
                    { 562L, "25841", 25L, "UBAQUE" },
                    { 563L, "25843", 25L, "VILLA DE SAN DIEGO DE UBATÉ" },
                    { 564L, "25845", 25L, "UNE" },
                    { 565L, "25851", 25L, "ÚTICA" },
                    { 566L, "25862", 25L, "VERGARA" },
                    { 567L, "25867", 25L, "VIANÍ" },
                    { 568L, "25871", 25L, "VILLAGÓMEZ" },
                    { 569L, "25873", 25L, "VILLAPINZÓN" },
                    { 570L, "25875", 25L, "VILLETA" },
                    { 571L, "25878", 25L, "VIOTÁ" },
                    { 572L, "25885", 25L, "YACOPÍ" },
                    { 573L, "25898", 25L, "ZIPACÓN" },
                    { 574L, "25899", 25L, "ZIPAQUIRÁ" },
                    { 575L, "27001", 27L, "QUIBDÓ" },
                    { 576L, "27006", 27L, "ACANDÍ" },
                    { 577L, "27025", 27L, "ALTO BAUDÓ" },
                    { 578L, "27050", 27L, "ATRATO" },
                    { 579L, "27073", 27L, "BAGADÓ" },
                    { 580L, "27075", 27L, "BAHÍA SOLANO" },
                    { 581L, "27077", 27L, "BAJO BAUDÓ" },
                    { 582L, "27099", 27L, "BOJAYÁ" },
                    { 583L, "27135", 27L, "EL CANTÓN DEL SAN PABLO" },
                    { 584L, "27150", 27L, "CARMEN DEL DARIÉN" },
                    { 585L, "27160", 27L, "CÉRTEGUI" },
                    { 586L, "27205", 27L, "CONDOTO" },
                    { 587L, "27245", 27L, "EL CARMEN DE ATRATO" },
                    { 588L, "27250", 27L, "EL LITORAL DEL SAN JUAN" },
                    { 589L, "27361", 27L, "ISTMINA" },
                    { 590L, "27372", 27L, "JURADÓ" },
                    { 591L, "27413", 27L, "LLORÓ" },
                    { 592L, "27425", 27L, "MEDIO ATRATO" },
                    { 593L, "27430", 27L, "MEDIO BAUDÓ" },
                    { 594L, "27450", 27L, "MEDIO SAN JUAN" },
                    { 595L, "27491", 27L, "NÓVITA" },
                    { 596L, "27495", 27L, "NUQUÍ" },
                    { 597L, "27580", 27L, "RÍO IRÓ" },
                    { 598L, "27600", 27L, "RÍO QUITO" },
                    { 599L, "27615", 27L, "RIOSUCIO" },
                    { 600L, "27660", 27L, "SAN JOSÉ DEL PALMAR" },
                    { 601L, "27745", 27L, "SIPÍ" },
                    { 602L, "27787", 27L, "TADÓ" },
                    { 603L, "27800", 27L, "UNGUÍA" },
                    { 604L, "27810", 27L, "UNIÓN PANAMERICANA" },
                    { 605L, "41001", 41L, "NEIVA" },
                    { 606L, "41006", 41L, "ACEVEDO" },
                    { 607L, "41013", 41L, "AGRADO" },
                    { 608L, "41016", 41L, "AIPE" },
                    { 609L, "41020", 41L, "ALGECIRAS" },
                    { 610L, "41026", 41L, "ALTAMIRA" },
                    { 611L, "41078", 41L, "BARAYA" },
                    { 612L, "41132", 41L, "CAMPOALEGRE" },
                    { 613L, "41206", 41L, "COLOMBIA" },
                    { 614L, "41244", 41L, "ELÍAS" },
                    { 615L, "41298", 41L, "GARZÓN" },
                    { 616L, "41306", 41L, "GIGANTE" },
                    { 617L, "41319", 41L, "GUADALUPE" },
                    { 618L, "41349", 41L, "HOBO" },
                    { 619L, "41357", 41L, "ÍQUIRA" },
                    { 620L, "41359", 41L, "ISNOS" },
                    { 621L, "41378", 41L, "LA ARGENTINA" },
                    { 622L, "41396", 41L, "LA PLATA" },
                    { 623L, "41483", 41L, "NÁTAGA" },
                    { 624L, "41503", 41L, "OPORAPA" },
                    { 625L, "41518", 41L, "PAICOL" },
                    { 626L, "41524", 41L, "PALERMO" },
                    { 627L, "41530", 41L, "PALESTINA" },
                    { 628L, "41548", 41L, "PITAL" },
                    { 629L, "41551", 41L, "PITALITO" },
                    { 630L, "41615", 41L, "RIVERA" },
                    { 631L, "41660", 41L, "SALADOBLANCO" },
                    { 632L, "41668", 41L, "SAN AGUSTÍN" },
                    { 633L, "41676", 41L, "SANTA MARÍA" },
                    { 634L, "41770", 41L, "SUAZA" },
                    { 635L, "41791", 41L, "TARQUI" },
                    { 636L, "41797", 41L, "TESALIA" },
                    { 637L, "41799", 41L, "TELLO" },
                    { 638L, "41801", 41L, "TERUEL" },
                    { 639L, "41807", 41L, "TIMANÁ" },
                    { 640L, "41872", 41L, "VILLAVIEJA" },
                    { 641L, "41885", 41L, "YAGUARÁ" },
                    { 642L, "44001", 44L, "RIOHACHA" },
                    { 643L, "44035", 44L, "ALBANIA" },
                    { 644L, "44078", 44L, "BARRANCAS" },
                    { 645L, "44090", 44L, "DIBULLA" },
                    { 646L, "44098", 44L, "DISTRACCIÓN" },
                    { 647L, "44110", 44L, "EL MOLINO" },
                    { 648L, "44279", 44L, "FONSECA" },
                    { 649L, "44378", 44L, "HATONUEVO" },
                    { 650L, "44420", 44L, "LA JAGUA DEL PILAR" },
                    { 651L, "44430", 44L, "MAICAO" },
                    { 652L, "44560", 44L, "MANAURE" },
                    { 653L, "44650", 44L, "SAN JUAN DEL CESAR" },
                    { 654L, "44847", 44L, "URIBIA" },
                    { 655L, "44855", 44L, "URUMITA" },
                    { 656L, "44874", 44L, "VILLANUEVA" },
                    { 657L, "47001", 47L, "SANTA MARTA" },
                    { 658L, "47030", 47L, "ALGARROBO" },
                    { 659L, "47053", 47L, "ARACATACA" },
                    { 660L, "47058", 47L, "ARIGUANÍ" },
                    { 661L, "47161", 47L, "CERRO DE SAN ANTONIO" },
                    { 662L, "47170", 47L, "CHIVOLO" },
                    { 663L, "47189", 47L, "CIÉNAGA" },
                    { 664L, "47205", 47L, "CONCORDIA" },
                    { 665L, "47245", 47L, "EL BANCO" },
                    { 666L, "47258", 47L, "EL PIÑÓN" },
                    { 667L, "47268", 47L, "EL RETÉN" },
                    { 668L, "47288", 47L, "FUNDACIÓN" },
                    { 669L, "47318", 47L, "GUAMAL" },
                    { 670L, "47460", 47L, "NUEVA GRANADA" },
                    { 671L, "47541", 47L, "PEDRAZA" },
                    { 672L, "47545", 47L, "PIJIÑO DEL CARMEN" },
                    { 673L, "47551", 47L, "PIVIJAY" },
                    { 674L, "47555", 47L, "PLATO" },
                    { 675L, "47570", 47L, "PUEBLOVIEJO" },
                    { 676L, "47605", 47L, "REMOLINO" },
                    { 677L, "47660", 47L, "SABANAS DE SAN ÁNGEL" },
                    { 678L, "47675", 47L, "SALAMINA" },
                    { 679L, "47692", 47L, "SAN SEBASTIÁN DE BUENAVISTA" },
                    { 680L, "47703", 47L, "SAN ZENÓN" },
                    { 681L, "47707", 47L, "SANTA ANA" },
                    { 682L, "47720", 47L, "SANTA BÁRBARA DE PINTO" },
                    { 683L, "47745", 47L, "SITIONUEVO" },
                    { 684L, "47798", 47L, "TENERIFE" },
                    { 685L, "47960", 47L, "ZAPAYÁN" },
                    { 686L, "47980", 47L, "ZONA BANANERA" },
                    { 687L, "50001", 50L, "VILLAVICENCIO" },
                    { 688L, "50006", 50L, "ACACÍAS" },
                    { 689L, "50110", 50L, "BARRANCA DE UPÍA" },
                    { 690L, "50124", 50L, "CABUYARO" },
                    { 691L, "50150", 50L, "CASTILLA LA NUEVA" },
                    { 692L, "50223", 50L, "CUBARRAL" },
                    { 693L, "50226", 50L, "CUMARAL" },
                    { 694L, "50245", 50L, "EL CALVARIO" },
                    { 695L, "50251", 50L, "EL CASTILLO" },
                    { 696L, "50270", 50L, "EL DORADO" },
                    { 697L, "50287", 50L, "FUENTE DE ORO" },
                    { 698L, "50313", 50L, "GRANADA" },
                    { 699L, "50318", 50L, "GUAMAL" },
                    { 700L, "50325", 50L, "MAPIRIPÁN" },
                    { 701L, "50330", 50L, "MESETAS" },
                    { 702L, "50350", 50L, "LA MACARENA" },
                    { 703L, "50370", 50L, "URIBE" },
                    { 704L, "50400", 50L, "LEJANÍAS" },
                    { 705L, "50450", 50L, "PUERTO CONCORDIA" },
                    { 706L, "50568", 50L, "PUERTO GAITÁN" },
                    { 707L, "50573", 50L, "PUERTO LÓPEZ" },
                    { 708L, "50577", 50L, "PUERTO LLERAS" },
                    { 709L, "50590", 50L, "PUERTO RICO" },
                    { 710L, "50606", 50L, "RESTREPO" },
                    { 711L, "50680", 50L, "SAN CARLOS DE GUAROA" },
                    { 712L, "50683", 50L, "SAN JUAN DE ARAMA" },
                    { 713L, "50686", 50L, "SAN JUANITO" },
                    { 714L, "50689", 50L, "SAN MARTÍN" },
                    { 715L, "50711", 50L, "VISTAHERMOSA" },
                    { 716L, "52001", 52L, "PASTO" },
                    { 717L, "52019", 52L, "ALBÁN" },
                    { 718L, "52022", 52L, "ALDANA" },
                    { 719L, "52036", 52L, "ANCUYA" },
                    { 720L, "52051", 52L, "ARBOLEDA" },
                    { 721L, "52079", 52L, "BARBACOAS" },
                    { 722L, "52083", 52L, "BELÉN" },
                    { 723L, "52110", 52L, "BUESACO" },
                    { 724L, "52203", 52L, "COLÓN" },
                    { 725L, "52207", 52L, "CONSACÁ" },
                    { 726L, "52210", 52L, "CONTADERO" },
                    { 727L, "52215", 52L, "CÓRDOBA" },
                    { 728L, "52224", 52L, "CUASPUD CARLOSAMA" },
                    { 729L, "52227", 52L, "CUMBAL" },
                    { 730L, "52233", 52L, "CUMBITARA" },
                    { 731L, "52240", 52L, "CHACHAGÜÍ" },
                    { 732L, "52250", 52L, "EL CHARCO" },
                    { 733L, "52254", 52L, "EL PEÑOL" },
                    { 734L, "52256", 52L, "EL ROSARIO" },
                    { 735L, "52258", 52L, "EL TABLÓN DE GÓMEZ" },
                    { 736L, "52260", 52L, "EL TAMBO" },
                    { 737L, "52287", 52L, "FUNES" },
                    { 738L, "52317", 52L, "GUACHUCAL" },
                    { 739L, "52320", 52L, "GUAITARILLA" },
                    { 740L, "52323", 52L, "GUALMATÁN" },
                    { 741L, "52352", 52L, "ILES" },
                    { 742L, "52354", 52L, "IMUÉS" },
                    { 743L, "52356", 52L, "IPIALES" },
                    { 744L, "52378", 52L, "LA CRUZ" },
                    { 745L, "52381", 52L, "LA FLORIDA" },
                    { 746L, "52385", 52L, "LA LLANADA" },
                    { 747L, "52390", 52L, "LA TOLA" },
                    { 748L, "52399", 52L, "LA UNIÓN" },
                    { 749L, "52405", 52L, "LEIVA" },
                    { 750L, "52411", 52L, "LINARES" },
                    { 751L, "52418", 52L, "LOS ANDES" },
                    { 752L, "52427", 52L, "MAGÜÍ" },
                    { 753L, "52435", 52L, "MALLAMA" },
                    { 754L, "52473", 52L, "MOSQUERA" },
                    { 755L, "52480", 52L, "NARIÑO" },
                    { 756L, "52490", 52L, "OLAYA HERRERA" },
                    { 757L, "52506", 52L, "OSPINA" },
                    { 758L, "52520", 52L, "FRANCISCO PIZARRO" },
                    { 759L, "52540", 52L, "POLICARPA" },
                    { 760L, "52560", 52L, "POTOSÍ" },
                    { 761L, "52565", 52L, "PROVIDENCIA" },
                    { 762L, "52573", 52L, "PUERRES" },
                    { 763L, "52585", 52L, "PUPIALES" },
                    { 764L, "52612", 52L, "RICAURTE" },
                    { 765L, "52621", 52L, "ROBERTO PAYÁN" },
                    { 766L, "52678", 52L, "SAMANIEGO" },
                    { 767L, "52683", 52L, "SANDONÁ" },
                    { 768L, "52685", 52L, "SAN BERNARDO" },
                    { 769L, "52687", 52L, "SAN LORENZO" },
                    { 770L, "52693", 52L, "SAN PABLO" },
                    { 771L, "52694", 52L, "SAN PEDRO DE CARTAGO" },
                    { 772L, "52696", 52L, "SANTA BÁRBARA" },
                    { 773L, "52699", 52L, "SANTACRUZ" },
                    { 774L, "52720", 52L, "SAPUYES" },
                    { 775L, "52786", 52L, "TAMINANGO" },
                    { 776L, "52788", 52L, "TANGUA" },
                    { 777L, "52835", 52L, "SAN ANDRÉS DE TUMACO" },
                    { 778L, "52838", 52L, "TÚQUERRES" },
                    { 779L, "52885", 52L, "YACUANQUER" },
                    { 780L, "54001", 54L, "SAN JOSÉ DE CÚCUTA" },
                    { 781L, "54003", 54L, "ÁBREGO" },
                    { 782L, "54051", 54L, "ARBOLEDAS" },
                    { 783L, "54099", 54L, "BOCHALEMA" },
                    { 784L, "54109", 54L, "BUCARASICA" },
                    { 785L, "54125", 54L, "CÁCOTA" },
                    { 786L, "54128", 54L, "CÁCHIRA" },
                    { 787L, "54172", 54L, "CHINÁCOTA" },
                    { 788L, "54174", 54L, "CHITAGÁ" },
                    { 789L, "54206", 54L, "CONVENCIÓN" },
                    { 790L, "54223", 54L, "CUCUTILLA" },
                    { 791L, "54239", 54L, "DURANIA" },
                    { 792L, "54245", 54L, "EL CARMEN" },
                    { 793L, "54250", 54L, "EL TARRA" },
                    { 794L, "54261", 54L, "EL ZULIA" },
                    { 795L, "54313", 54L, "GRAMALOTE" },
                    { 796L, "54344", 54L, "HACARÍ" },
                    { 797L, "54347", 54L, "HERRÁN" },
                    { 798L, "54377", 54L, "LABATECA" },
                    { 799L, "54385", 54L, "LA ESPERANZA" },
                    { 800L, "54398", 54L, "LA PLAYA" },
                    { 801L, "54405", 54L, "LOS PATIOS" },
                    { 802L, "54418", 54L, "LOURDES" },
                    { 803L, "54480", 54L, "MUTISCUA" },
                    { 804L, "54498", 54L, "OCAÑA" },
                    { 805L, "54518", 54L, "PAMPLONA" },
                    { 806L, "54520", 54L, "PAMPLONITA" },
                    { 807L, "54553", 54L, "PUERTO SANTANDER" },
                    { 808L, "54599", 54L, "RAGONVALIA" },
                    { 809L, "54660", 54L, "SALAZAR" },
                    { 810L, "54670", 54L, "SAN CALIXTO" },
                    { 811L, "54673", 54L, "SAN CAYETANO" },
                    { 812L, "54680", 54L, "SANTIAGO" },
                    { 813L, "54720", 54L, "SARDINATA" },
                    { 814L, "54743", 54L, "SILOS" },
                    { 815L, "54800", 54L, "TEORAMA" },
                    { 816L, "54810", 54L, "TIBÚ" },
                    { 817L, "54820", 54L, "TOLEDO" },
                    { 818L, "54871", 54L, "VILLA CARO" },
                    { 819L, "54874", 54L, "VILLA DEL ROSARIO" },
                    { 820L, "63001", 63L, "ARMENIA" },
                    { 821L, "63111", 63L, "BUENAVISTA" },
                    { 822L, "63130", 63L, "CALARCÁ" },
                    { 823L, "63190", 63L, "CIRCASIA" },
                    { 824L, "63212", 63L, "CÓRDOBA" },
                    { 825L, "63272", 63L, "FILANDIA" },
                    { 826L, "63302", 63L, "GÉNOVA" },
                    { 827L, "63401", 63L, "LA TEBAIDA" },
                    { 828L, "63470", 63L, "MONTENEGRO" },
                    { 829L, "63548", 63L, "PIJAO" },
                    { 830L, "63594", 63L, "QUIMBAYA" },
                    { 831L, "63690", 63L, "SALENTO" },
                    { 832L, "66001", 66L, "PEREIRA" },
                    { 833L, "66045", 66L, "APÍA" },
                    { 834L, "66075", 66L, "BALBOA" },
                    { 835L, "66088", 66L, "BELÉN DE UMBRÍA" },
                    { 836L, "66170", 66L, "DOSQUEBRADAS" },
                    { 837L, "66318", 66L, "GUÁTICA" },
                    { 838L, "66383", 66L, "LA CELIA" },
                    { 839L, "66400", 66L, "LA VIRGINIA" },
                    { 840L, "66440", 66L, "MARSELLA" },
                    { 841L, "66456", 66L, "MISTRATÓ" },
                    { 842L, "66572", 66L, "PUEBLO RICO" },
                    { 843L, "66594", 66L, "QUINCHÍA" },
                    { 844L, "66682", 66L, "SANTA ROSA DE CABAL" },
                    { 845L, "66687", 66L, "SANTUARIO" },
                    { 846L, "68001", 68L, "BUCARAMANGA" },
                    { 847L, "68013", 68L, "AGUADA" },
                    { 848L, "68020", 68L, "ALBANIA" },
                    { 849L, "68051", 68L, "ARATOCA" },
                    { 850L, "68077", 68L, "BARBOSA" },
                    { 851L, "68079", 68L, "BARICHARA" },
                    { 852L, "68081", 68L, "BARRANCABERMEJA" },
                    { 853L, "68092", 68L, "BETULIA" },
                    { 854L, "68101", 68L, "BOLÍVAR" },
                    { 855L, "68121", 68L, "CABRERA" },
                    { 856L, "68132", 68L, "CALIFORNIA" },
                    { 857L, "68147", 68L, "CAPITANEJO" },
                    { 858L, "68152", 68L, "CARCASÍ" },
                    { 859L, "68160", 68L, "CEPITÁ" },
                    { 860L, "68162", 68L, "CERRITO" },
                    { 861L, "68167", 68L, "CHARALÁ" },
                    { 862L, "68169", 68L, "CHARTA" },
                    { 863L, "68176", 68L, "CHIMA" },
                    { 864L, "68179", 68L, "CHIPATÁ" },
                    { 865L, "68190", 68L, "CIMITARRA" },
                    { 866L, "68207", 68L, "CONCEPCIÓN" },
                    { 867L, "68209", 68L, "CONFINES" },
                    { 868L, "68211", 68L, "CONTRATACIÓN" },
                    { 869L, "68217", 68L, "COROMORO" },
                    { 870L, "68229", 68L, "CURITÍ" },
                    { 871L, "68235", 68L, "EL CARMEN DE CHUCURI" },
                    { 872L, "68245", 68L, "EL GUACAMAYO" },
                    { 873L, "68250", 68L, "EL PEÑÓN" },
                    { 874L, "68255", 68L, "EL PLAYÓN" },
                    { 875L, "68264", 68L, "ENCINO" },
                    { 876L, "68266", 68L, "ENCISO" },
                    { 877L, "68271", 68L, "FLORIÁN" },
                    { 878L, "68276", 68L, "FLORIDABLANCA" },
                    { 879L, "68296", 68L, "GALÁN" },
                    { 880L, "68298", 68L, "GÁMBITA" },
                    { 881L, "68307", 68L, "GIRÓN" },
                    { 882L, "68318", 68L, "GUACA" },
                    { 883L, "68320", 68L, "GUADALUPE" },
                    { 884L, "68322", 68L, "GUAPOTÁ" },
                    { 885L, "68324", 68L, "GUAVATÁ" },
                    { 886L, "68327", 68L, "GÜEPSA" },
                    { 887L, "68344", 68L, "HATO" },
                    { 888L, "68368", 68L, "JESÚS MARÍA" },
                    { 889L, "68370", 68L, "JORDÁN" },
                    { 890L, "68377", 68L, "LA BELLEZA" },
                    { 891L, "68385", 68L, "LANDÁZURI" },
                    { 892L, "68397", 68L, "LA PAZ" },
                    { 893L, "68406", 68L, "LEBRIJA" },
                    { 894L, "68418", 68L, "LOS SANTOS" },
                    { 895L, "68425", 68L, "MACARAVITA" },
                    { 896L, "68432", 68L, "MÁLAGA" },
                    { 897L, "68444", 68L, "MATANZA" },
                    { 898L, "68464", 68L, "MOGOTES" },
                    { 899L, "68468", 68L, "MOLAGAVITA" },
                    { 900L, "68498", 68L, "OCAMONTE" },
                    { 901L, "68500", 68L, "OIBA" },
                    { 902L, "68502", 68L, "ONZAGA" },
                    { 903L, "68522", 68L, "PALMAR" },
                    { 904L, "68524", 68L, "PALMAS DEL SOCORRO" },
                    { 905L, "68533", 68L, "PÁRAMO" },
                    { 906L, "68547", 68L, "PIEDECUESTA" },
                    { 907L, "68549", 68L, "PINCHOTE" },
                    { 908L, "68572", 68L, "PUENTE NACIONAL" },
                    { 909L, "68573", 68L, "PUERTO PARRA" },
                    { 910L, "68575", 68L, "PUERTO WILCHES" },
                    { 911L, "68615", 68L, "RIONEGRO" },
                    { 912L, "68655", 68L, "SABANA DE TORRES" },
                    { 913L, "68669", 68L, "SAN ANDRÉS" },
                    { 914L, "68673", 68L, "SAN BENITO" },
                    { 915L, "68679", 68L, "SAN GIL" },
                    { 916L, "68682", 68L, "SAN JOAQUÍN" },
                    { 917L, "68684", 68L, "SAN JOSÉ DE MIRANDA" },
                    { 918L, "68686", 68L, "SAN MIGUEL" },
                    { 919L, "68689", 68L, "SAN VICENTE DE CHUCURÍ" },
                    { 920L, "68705", 68L, "SANTA BÁRBARA" },
                    { 921L, "68720", 68L, "SANTA HELENA DEL OPÓN" },
                    { 922L, "68745", 68L, "SIMACOTA" },
                    { 923L, "68755", 68L, "SOCORRO" },
                    { 924L, "68770", 68L, "SUAITA" },
                    { 925L, "68773", 68L, "SUCRE" },
                    { 926L, "68780", 68L, "SURATÁ" },
                    { 927L, "68820", 68L, "TONA" },
                    { 928L, "68855", 68L, "VALLE DE SAN JOSÉ" },
                    { 929L, "68861", 68L, "VÉLEZ" },
                    { 930L, "68867", 68L, "VETAS" },
                    { 931L, "68872", 68L, "VILLANUEVA" },
                    { 932L, "68895", 68L, "ZAPATOCA" },
                    { 933L, "70001", 70L, "SINCELEJO" },
                    { 934L, "70110", 70L, "BUENAVISTA" },
                    { 935L, "70124", 70L, "CAIMITO" },
                    { 936L, "70204", 70L, "COLOSÓ" },
                    { 937L, "70215", 70L, "COROZAL" },
                    { 938L, "70221", 70L, "COVEÑAS" },
                    { 939L, "70230", 70L, "CHALÁN" },
                    { 940L, "70233", 70L, "EL ROBLE" },
                    { 941L, "70235", 70L, "GALERAS" },
                    { 942L, "70265", 70L, "GUARANDA" },
                    { 943L, "70400", 70L, "LA UNIÓN" },
                    { 944L, "70418", 70L, "LOS PALMITOS" },
                    { 945L, "70429", 70L, "MAJAGUAL" },
                    { 946L, "70473", 70L, "MORROA" },
                    { 947L, "70508", 70L, "OVEJAS" },
                    { 948L, "70523", 70L, "PALMITO" },
                    { 949L, "70670", 70L, "SAMPUÉS" },
                    { 950L, "70678", 70L, "SAN BENITO ABAD" },
                    { 951L, "70702", 70L, "SAN JUAN DE BETULIA" },
                    { 952L, "70708", 70L, "SAN MARCOS" },
                    { 953L, "70713", 70L, "SAN ONOFRE" },
                    { 954L, "70717", 70L, "SAN PEDRO" },
                    { 955L, "70742", 70L, "SAN LUIS DE SINCÉ" },
                    { 956L, "70771", 70L, "SUCRE" },
                    { 957L, "70820", 70L, "SANTIAGO DE TOLÚ" },
                    { 958L, "70823", 70L, "SAN JOSÉ DE TOLUVIEJO" },
                    { 959L, "73001", 73L, "IBAGUÉ" },
                    { 960L, "73024", 73L, "ALPUJARRA" },
                    { 961L, "73026", 73L, "ALVARADO" },
                    { 962L, "73030", 73L, "AMBALEMA" },
                    { 963L, "73043", 73L, "ANZOÁTEGUI" },
                    { 964L, "73055", 73L, "ARMERO" },
                    { 965L, "73067", 73L, "ATACO" },
                    { 966L, "73124", 73L, "CAJAMARCA" },
                    { 967L, "73148", 73L, "CARMEN DE APICALÁ" },
                    { 968L, "73152", 73L, "CASABIANCA" },
                    { 969L, "73168", 73L, "CHAPARRAL" },
                    { 970L, "73200", 73L, "COELLO" },
                    { 971L, "73217", 73L, "COYAIMA" },
                    { 972L, "73226", 73L, "CUNDAY" },
                    { 973L, "73236", 73L, "DOLORES" },
                    { 974L, "73268", 73L, "ESPINAL" },
                    { 975L, "73270", 73L, "FALAN" },
                    { 976L, "73275", 73L, "FLANDES" },
                    { 977L, "73283", 73L, "FRESNO" },
                    { 978L, "73319", 73L, "GUAMO" },
                    { 979L, "73347", 73L, "HERVEO" },
                    { 980L, "73349", 73L, "HONDA" },
                    { 981L, "73352", 73L, "ICONONZO" },
                    { 982L, "73408", 73L, "LÉRIDA" },
                    { 983L, "73411", 73L, "LÍBANO" },
                    { 984L, "73443", 73L, "SAN SEBASTIÁN DE MARIQUITA" },
                    { 985L, "73449", 73L, "MELGAR" },
                    { 986L, "73461", 73L, "MURILLO" },
                    { 987L, "73483", 73L, "NATAGAIMA" },
                    { 988L, "73504", 73L, "ORTEGA" },
                    { 989L, "73520", 73L, "PALOCABILDO" },
                    { 990L, "73547", 73L, "PIEDRAS" },
                    { 991L, "73555", 73L, "PLANADAS" },
                    { 992L, "73563", 73L, "PRADO" },
                    { 993L, "73585", 73L, "PURIFICACIÓN" },
                    { 994L, "73616", 73L, "RIOBLANCO" },
                    { 995L, "73622", 73L, "RONCESVALLES" },
                    { 996L, "73624", 73L, "ROVIRA" },
                    { 997L, "73671", 73L, "SALDAÑA" },
                    { 998L, "73675", 73L, "SAN ANTONIO" },
                    { 999L, "73678", 73L, "SAN LUIS" },
                    { 1000L, "73686", 73L, "SANTA ISABEL" },
                    { 1001L, "73770", 73L, "SUÁREZ" },
                    { 1002L, "73854", 73L, "VALLE DE SAN JUAN" },
                    { 1003L, "73861", 73L, "VENADILLO" },
                    { 1004L, "73870", 73L, "VILLAHERMOSA" },
                    { 1005L, "73873", 73L, "VILLARRICA" },
                    { 1006L, "76001", 76L, "CALI" },
                    { 1007L, "76020", 76L, "ALCALÁ" },
                    { 1008L, "76036", 76L, "ANDALUCÍA" },
                    { 1009L, "76041", 76L, "ANSERMANUEVO" },
                    { 1010L, "76054", 76L, "ARGELIA" },
                    { 1011L, "76100", 76L, "BOLÍVAR" },
                    { 1012L, "76109", 76L, "BUENAVENTURA" },
                    { 1013L, "76111", 76L, "GUADALAJARA DE BUGA" },
                    { 1014L, "76113", 76L, "BUGALAGRANDE" },
                    { 1015L, "76122", 76L, "CAICEDONIA" },
                    { 1016L, "76126", 76L, "CALIMA" },
                    { 1017L, "76130", 76L, "CANDELARIA" },
                    { 1018L, "76147", 76L, "CARTAGO" },
                    { 1019L, "76233", 76L, "DAGUA" },
                    { 1020L, "76243", 76L, "EL ÁGUILA" },
                    { 1021L, "76246", 76L, "EL CAIRO" },
                    { 1022L, "76248", 76L, "EL CERRITO" },
                    { 1023L, "76250", 76L, "EL DOVIO" },
                    { 1024L, "76275", 76L, "FLORIDA" },
                    { 1025L, "76306", 76L, "GINEBRA" },
                    { 1026L, "76318", 76L, "GUACARÍ" },
                    { 1027L, "76364", 76L, "JAMUNDÍ" },
                    { 1028L, "76377", 76L, "LA CUMBRE" },
                    { 1029L, "76400", 76L, "LA UNIÓN" },
                    { 1030L, "76403", 76L, "LA VICTORIA" },
                    { 1031L, "76497", 76L, "OBANDO" },
                    { 1032L, "76520", 76L, "PALMIRA" },
                    { 1033L, "76563", 76L, "PRADERA" },
                    { 1034L, "76606", 76L, "RESTREPO" },
                    { 1035L, "76616", 76L, "RIOFRÍO" },
                    { 1036L, "76622", 76L, "ROLDANILLO" },
                    { 1037L, "76670", 76L, "SAN PEDRO" },
                    { 1038L, "76736", 76L, "SEVILLA" },
                    { 1039L, "76823", 76L, "TORO" },
                    { 1040L, "76828", 76L, "TRUJILLO" },
                    { 1041L, "76834", 76L, "TULUÁ" },
                    { 1042L, "76845", 76L, "ULLOA" },
                    { 1043L, "76863", 76L, "VERSALLES" },
                    { 1044L, "76869", 76L, "VIJES" },
                    { 1045L, "76890", 76L, "YOTOCO" },
                    { 1046L, "76892", 76L, "YUMBO" },
                    { 1047L, "76895", 76L, "ZARZAL" },
                    { 1048L, "81001", 81L, "ARAUCA" },
                    { 1049L, "81065", 81L, "ARAUQUITA" },
                    { 1050L, "81220", 81L, "CRAVO NORTE" },
                    { 1051L, "81300", 81L, "FORTUL" },
                    { 1052L, "81591", 81L, "PUERTO RONDÓN" },
                    { 1053L, "81736", 81L, "SARAVENA" },
                    { 1054L, "81794", 81L, "TAME" },
                    { 1055L, "85001", 85L, "YOPAL" },
                    { 1056L, "85010", 85L, "AGUAZUL" },
                    { 1057L, "85015", 85L, "CHÁMEZA" },
                    { 1058L, "85125", 85L, "HATO COROZAL" },
                    { 1059L, "85136", 85L, "LA SALINA" },
                    { 1060L, "85139", 85L, "MANÍ" },
                    { 1061L, "85162", 85L, "MONTERREY" },
                    { 1062L, "85225", 85L, "NUNCHÍA" },
                    { 1063L, "85230", 85L, "OROCUÉ" },
                    { 1064L, "85250", 85L, "PAZ DE ARIPORO" },
                    { 1065L, "85263", 85L, "PORE" },
                    { 1066L, "85279", 85L, "RECETOR" },
                    { 1067L, "85300", 85L, "SABANALARGA" },
                    { 1068L, "85315", 85L, "SÁCAMA" },
                    { 1069L, "85325", 85L, "SAN LUIS DE PALENQUE" },
                    { 1070L, "85400", 85L, "TÁMARA" },
                    { 1071L, "85410", 85L, "TAURAMENA" },
                    { 1072L, "85430", 85L, "TRINIDAD" },
                    { 1073L, "85440", 85L, "VILLANUEVA" },
                    { 1074L, "86001", 86L, "MOCOA" },
                    { 1075L, "86219", 86L, "COLÓN" },
                    { 1076L, "86320", 86L, "ORITO" },
                    { 1077L, "86568", 86L, "PUERTO ASÍS" },
                    { 1078L, "86569", 86L, "PUERTO CAICEDO" },
                    { 1079L, "86571", 86L, "PUERTO GUZMÁN" },
                    { 1080L, "86573", 86L, "PUERTO LEGUÍZAMO" },
                    { 1081L, "86749", 86L, "SIBUNDOY" },
                    { 1082L, "86755", 86L, "SAN FRANCISCO" },
                    { 1083L, "86757", 86L, "SAN MIGUEL" },
                    { 1084L, "86760", 86L, "SANTIAGO" },
                    { 1085L, "86865", 86L, "VALLE DEL GUAMUEZ" },
                    { 1086L, "86885", 86L, "VILLAGARZÓN" },
                    { 1087L, "88001", 88L, "SAN ANDRÉS" },
                    { 1088L, "88564", 88L, "PROVIDENCIA" },
                    { 1089L, "91001", 91L, "LETICIA" },
                    { 1090L, "91263", 91L, "EL ENCANTO" },
                    { 1091L, "91405", 91L, "LA CHORRERA" },
                    { 1092L, "91407", 91L, "LA PEDRERA" },
                    { 1093L, "91430", 91L, "LA VICTORIA" },
                    { 1094L, "91460", 91L, "MIRITÍ - PARANÁ" },
                    { 1095L, "91530", 91L, "PUERTO ALEGRÍA" },
                    { 1096L, "91536", 91L, "PUERTO ARICA" },
                    { 1097L, "91540", 91L, "PUERTO NARIÑO" },
                    { 1098L, "91669", 91L, "PUERTO SANTANDER" },
                    { 1099L, "91798", 91L, "TARAPACÁ" },
                    { 1100L, "94001", 94L, "INÍRIDA" },
                    { 1101L, "94343", 94L, "BARRANCOMINAS*" },
                    { 1102L, "94883", 94L, "SAN FELIPE" },
                    { 1103L, "94884", 94L, "PUERTO COLOMBIA" },
                    { 1104L, "94885", 94L, "LA GUADALUPE" },
                    { 1105L, "94886", 94L, "CACAHUAL" },
                    { 1106L, "94887", 94L, "PANA PANA" },
                    { 1107L, "94888", 94L, "MORICHAL" },
                    { 1108L, "95001", 95L, "SAN JOSÉ DEL GUAVIARE" },
                    { 1109L, "95015", 95L, "CALAMAR" },
                    { 1110L, "95025", 95L, "EL RETORNO" },
                    { 1111L, "95200", 95L, "MIRAFLORES" },
                    { 1112L, "97001", 97L, "MITÚ" },
                    { 1113L, "97161", 97L, "CARURÚ" },
                    { 1114L, "97511", 97L, "PACOA" },
                    { 1115L, "97666", 97L, "TARAIRA" },
                    { 1116L, "97777", 97L, "PAPUNAHUA" },
                    { 1117L, "97889", 97L, "YAVARATÉ" },
                    { 1118L, "99001", 99L, "PUERTO CARREÑO" },
                    { 1119L, "99524", 99L, "LA PRIMAVERA" },
                    { 1120L, "99624", 99L, "SANTA ROSALÍA" },
                    { 1121L, "99773", 99L, "CUMARIBO" }
                });

            migrationBuilder.InsertData(
                schema: "Par",
                table: "ParametroDetallado",
                columns: new[] { "Id", "FechaAdicion", "FechaUltimaActualizacion", "IdParametroGeneral", "IdUsuarioAdiciono", "IdUsuarioUltimaActualizacion", "Nombre" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1L, 1L, null, "Si" },
                    { 2L, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1L, 1L, null, "No" }
                });

            migrationBuilder.InsertData(
                schema: "Seg",
                table: "RolModulo",
                columns: new[] { "Id", "FechaAdicion", "FechaUltimaActualizacion", "IdModulo", "IdRol", "IdUsuarioAdiciono", "IdUsuarioUltimaActualizacion" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1L, 1L, 1L, null },
                    { 2L, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2L, 1L, 1L, null },
                    { 3L, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3L, 1L, 1L, null },
                    { 4L, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4L, 1L, 1L, null },
                    { 5L, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5L, 1L, 1L, null },
                    { 6L, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6L, 1L, 1L, null }
                });

            migrationBuilder.InsertData(
                schema: "Seg",
                table: "Usuario",
                columns: new[] { "Id", "Apellidos", "Celular", "Clave", "Email", "FechaAdicion", "FechaUltimaActualizacion", "FechaUltimoCambioContraseña", "FechaUltimoIngreso", "IdRol", "IdUsuarioAdiciono", "IdUsuarioUltimaActualizacion", "IsActive", "IsTwoFAEnabled", "MustChangePassword", "NombreUsuario", "Nombres", "TipoUsuario" },
                values: new object[] { 1L, "Administrador", "3174575592", "B9A465912169BEF97138C76EFDFD5BB34FDC5FA58855AC187817AE07E80ABE5E-5929B1B6239B2767DDEDDABC98823ADF", "alejandro010916@hotmail.com", new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, null, null, true, false, true, "Administrador", "Administrador", "Normal" });

            migrationBuilder.CreateIndex(
                name: "IX_AuditoriaAdjuntoEmail_IdAuditoriaEnvioEmail",
                schema: "Aud",
                table: "AuditoriaAdjuntoEmail",
                column: "IdAuditoriaEnvioEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AuditoriaAdjuntoEmail_RutaAbsolutaAdjunto",
                schema: "Aud",
                table: "AuditoriaAdjuntoEmail",
                column: "RutaAbsolutaAdjunto");

            migrationBuilder.CreateIndex(
                name: "IX_AuditoriaConsumoRegistraduria_CedulaConsultada",
                schema: "Aud",
                table: "AuditoriaConsumoRegistraduria",
                column: "CedulaConsultada");

            migrationBuilder.CreateIndex(
                name: "IX_AuditoriaConsumoRegistraduria_CodigoErrorCedula",
                schema: "Aud",
                table: "AuditoriaConsumoRegistraduria",
                column: "CodigoErrorCedula");

            migrationBuilder.CreateIndex(
                name: "IX_AuditoriaConsumoRegistraduria_EstadoCedula",
                schema: "Aud",
                table: "AuditoriaConsumoRegistraduria",
                column: "EstadoCedula");

            migrationBuilder.CreateIndex(
                name: "IX_AuditoriaConsumoRegistraduria_StatusCodeRespuesta",
                schema: "Aud",
                table: "AuditoriaConsumoRegistraduria",
                column: "StatusCodeRespuesta");

            migrationBuilder.CreateIndex(
                name: "IX_AuditoriaConsumoRegistraduria_UsuarioConsulta",
                schema: "Aud",
                table: "AuditoriaConsumoRegistraduria",
                column: "UsuarioConsulta");

            migrationBuilder.CreateIndex(
                name: "IX_AuditoriaEnvioEmail_Concepto",
                schema: "Aud",
                table: "AuditoriaEnvioEmail",
                column: "Concepto");

            migrationBuilder.CreateIndex(
                name: "IX_AuditoriaEnvioEmail_EmailDestinatario",
                schema: "Aud",
                table: "AuditoriaEnvioEmail",
                column: "EmailDestinatario");

            migrationBuilder.CreateIndex(
                name: "IX_AuditoriaEnvioEmail_FueEnviado",
                schema: "Aud",
                table: "AuditoriaEnvioEmail",
                column: "FueEnviado");

            migrationBuilder.CreateIndex(
                name: "IX_AuditoriaEnvioEmail_NumeroIdentificacionProceso",
                schema: "Aud",
                table: "AuditoriaEnvioEmail",
                column: "NumeroIdentificacionProceso");

            migrationBuilder.CreateIndex(
                name: "IX_AuditoriaEnvioSMS_CelularDestinatario",
                schema: "Aud",
                table: "AuditoriaEnvioSMS",
                column: "CelularDestinatario");

            migrationBuilder.CreateIndex(
                name: "IX_AuditoriaEnvioSMS_FechaEnvio",
                schema: "Aud",
                table: "AuditoriaEnvioSMS",
                column: "FechaEnvio");

            migrationBuilder.CreateIndex(
                name: "IX_AuditoriaEnvioSMS_FueEnviado",
                schema: "Aud",
                table: "AuditoriaEnvioSMS",
                column: "FueEnviado");

            migrationBuilder.CreateIndex(
                name: "IX_AuditoriaEnvioSMS_IdentificacionProceso",
                schema: "Aud",
                table: "AuditoriaEnvioSMS",
                column: "IdentificacionProceso");

            migrationBuilder.CreateIndex(
                name: "IX_AuditoriaEnvioSMS_Pantalla",
                schema: "Aud",
                table: "AuditoriaEnvioSMS",
                column: "Pantalla");

            migrationBuilder.CreateIndex(
                name: "IX_AuditoriaEnvioWpp_CelularDestinatario",
                schema: "Aud",
                table: "AuditoriaEnvioWpp",
                column: "CelularDestinatario");

            migrationBuilder.CreateIndex(
                name: "IX_AuditoriaEnvioWpp_FechaEnvio",
                schema: "Aud",
                table: "AuditoriaEnvioWpp",
                column: "FechaEnvio");

            migrationBuilder.CreateIndex(
                name: "IX_AuditoriaEnvioWpp_FueEnviado",
                schema: "Aud",
                table: "AuditoriaEnvioWpp",
                column: "FueEnviado");

            migrationBuilder.CreateIndex(
                name: "IX_AuditoriaEnvioWpp_IdentificacionProceso",
                schema: "Aud",
                table: "AuditoriaEnvioWpp",
                column: "IdentificacionProceso");

            migrationBuilder.CreateIndex(
                name: "IX_AuditoriaEnvioWpp_Pantalla",
                schema: "Aud",
                table: "AuditoriaEnvioWpp",
                column: "Pantalla");

            migrationBuilder.CreateIndex(
                name: "IX_AuditoriaEventos_Accion",
                schema: "Aud",
                table: "AuditoriaEventos",
                column: "Accion");

            migrationBuilder.CreateIndex(
                name: "IX_AuditoriaEventos_Concepto",
                schema: "Aud",
                table: "AuditoriaEventos",
                column: "Concepto");

            migrationBuilder.CreateIndex(
                name: "IX_AuditoriaEventos_IdentificadorProceso",
                schema: "Aud",
                table: "AuditoriaEventos",
                column: "IdentificadorProceso");

            migrationBuilder.CreateIndex(
                name: "IX_AuditoriaEventos_IdUsuarioAccion",
                schema: "Aud",
                table: "AuditoriaEventos",
                column: "IdUsuarioAccion");

            migrationBuilder.CreateIndex(
                name: "IX_AuditoriaLoginUsuario_Descripcion",
                schema: "Seg",
                table: "AuditoriaLoginUsuario",
                column: "Descripcion");

            migrationBuilder.CreateIndex(
                name: "IX_AuditoriaLoginUsuario_FechaAdicion",
                schema: "Seg",
                table: "AuditoriaLoginUsuario",
                column: "FechaAdicion");

            migrationBuilder.CreateIndex(
                name: "IX_AuditoriaLoginUsuario_IdUsuario",
                schema: "Seg",
                table: "AuditoriaLoginUsuario",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_AuditoriaNavegacion_IdUsuarioAccion",
                schema: "Aud",
                table: "AuditoriaNavegacion",
                column: "IdUsuarioAccion");

            migrationBuilder.CreateIndex(
                name: "IX_AuditoriaNavegacion_IpAddress",
                schema: "Aud",
                table: "AuditoriaNavegacion",
                column: "IpAddress");

            migrationBuilder.CreateIndex(
                name: "IX_AuditoriaNavegacion_UrlActual",
                schema: "Aud",
                table: "AuditoriaNavegacion",
                column: "UrlActual");

            migrationBuilder.CreateIndex(
                name: "IX_AuditoriaOtp_Codigo",
                schema: "Aud",
                table: "AuditoriaOtp",
                column: "Codigo");

            migrationBuilder.CreateIndex(
                name: "IX_AuditoriaOtp_Estado",
                schema: "Aud",
                table: "AuditoriaOtp",
                column: "Estado");

            migrationBuilder.CreateIndex(
                name: "IX_AuditoriaOtp_FechaAdicion",
                schema: "Aud",
                table: "AuditoriaOtp",
                column: "FechaAdicion");

            migrationBuilder.CreateIndex(
                name: "IX_AuditoriaOtp_FechaValidacion",
                schema: "Aud",
                table: "AuditoriaOtp",
                column: "FechaValidacion");

            migrationBuilder.CreateIndex(
                name: "IX_AuditoriaOtp_IdentificacionProceso",
                schema: "Aud",
                table: "AuditoriaOtp",
                column: "IdentificacionProceso");

            migrationBuilder.CreateIndex(
                name: "IX_AuditoriaOtp_TipoProceso",
                schema: "Aud",
                table: "AuditoriaOtp",
                column: "TipoProceso");

            migrationBuilder.CreateIndex(
                name: "IX_Ciudad_IdDepartamento",
                schema: "Par",
                table: "Ciudad",
                column: "IdDepartamento");

            migrationBuilder.CreateIndex(
                name: "IX_ParametroDetallado_IdParametroGeneral",
                schema: "Par",
                table: "ParametroDetallado",
                column: "IdParametroGeneral");

            migrationBuilder.CreateIndex(
                name: "IX_RolModulo_IdModulo",
                schema: "Seg",
                table: "RolModulo",
                column: "IdModulo");

            migrationBuilder.CreateIndex(
                name: "IX_RolModulo_IdRol",
                schema: "Seg",
                table: "RolModulo",
                column: "IdRol");

            migrationBuilder.CreateIndex(
                name: "IX_Session_FechaUltimoIngreso",
                schema: "Seg",
                table: "Session",
                column: "FechaUltimoIngreso");

            migrationBuilder.CreateIndex(
                name: "IX_Session_IdAuditoriaLogin",
                schema: "Seg",
                table: "Session",
                column: "IdAuditoriaLogin");

            migrationBuilder.CreateIndex(
                name: "IX_Session_IdUsuario",
                schema: "Seg",
                table: "Session",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Session_IsActive",
                schema: "Seg",
                table: "Session",
                column: "IsActive");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudRecuperacionClave_Estado",
                schema: "Seg",
                table: "SolicitudRecuperacionClave",
                column: "Estado");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudRecuperacionClave_IdUsuario",
                schema: "Seg",
                table: "SolicitudRecuperacionClave",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudRecuperacionClave_MotivoCambioContraseña",
                schema: "Seg",
                table: "SolicitudRecuperacionClave",
                column: "MotivoCambioContraseña");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_Email",
                schema: "Seg",
                table: "Usuario",
                column: "Email");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_IdRol",
                schema: "Seg",
                table: "Usuario",
                column: "IdRol");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_IsActive",
                schema: "Seg",
                table: "Usuario",
                column: "IsActive");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_NombreUsuario",
                schema: "Seg",
                table: "Usuario",
                column: "NombreUsuario",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditoriaAdjuntoEmail",
                schema: "Aud");

            migrationBuilder.DropTable(
                name: "AuditoriaConsumoRegistraduria",
                schema: "Aud");

            migrationBuilder.DropTable(
                name: "AuditoriaDescargaArchivos",
                schema: "Aud");

            migrationBuilder.DropTable(
                name: "AuditoriaEnvioSMS",
                schema: "Aud");

            migrationBuilder.DropTable(
                name: "AuditoriaEnvioWpp",
                schema: "Aud");

            migrationBuilder.DropTable(
                name: "AuditoriaEventos",
                schema: "Aud");

            migrationBuilder.DropTable(
                name: "AuditoriaLoginUsuario",
                schema: "Seg");

            migrationBuilder.DropTable(
                name: "AuditoriaNavegacion",
                schema: "Aud");

            migrationBuilder.DropTable(
                name: "AuditoriaOtp",
                schema: "Aud");

            migrationBuilder.DropTable(
                name: "Ciudad",
                schema: "Par");

            migrationBuilder.DropTable(
                name: "ParametroDetallado",
                schema: "Par");

            migrationBuilder.DropTable(
                name: "RolModulo",
                schema: "Seg");

            migrationBuilder.DropTable(
                name: "Session",
                schema: "Seg");

            migrationBuilder.DropTable(
                name: "SolicitudRecuperacionClave",
                schema: "Seg");

            migrationBuilder.DropTable(
                name: "AuditoriaEnvioEmail",
                schema: "Aud");

            migrationBuilder.DropTable(
                name: "Departamento",
                schema: "Par");

            migrationBuilder.DropTable(
                name: "ParametroGeneral",
                schema: "Par");

            migrationBuilder.DropTable(
                name: "Modulo",
                schema: "Seg");

            migrationBuilder.DropTable(
                name: "Usuario",
                schema: "Seg");

            migrationBuilder.DropTable(
                name: "Rol",
                schema: "Seg");
        }
    }
}
