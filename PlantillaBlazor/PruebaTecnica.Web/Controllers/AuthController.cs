﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Domain.Entities.Perfilamiento;
using PruebaTecnica.Services.Interfaces.Encrypt;
using PruebaTecnica.Services.Interfaces.Otp;
using PruebaTecnica.Services.Interfaces.Perfilamiento;
using System.Security.Claims;

namespace PruebaTecnica.Web.Controllers
{
    public class AuthController : Controller
    {
        private readonly IEncryptService _encryptService;
        private readonly IOtpService _otpService;
        private readonly IUsuarioService _usuarioService;
        private readonly ISessionService _sessionService;
        private readonly ILogger<AuthController> _logger;
        public AuthController
        (
            IEncryptService encryptService,
            IOtpService otpService,
            IUsuarioService usuarioService,
            ISessionService sessionService,
            ILogger<AuthController> logger
        )
        {
            _encryptService = encryptService;
            _otpService = otpService;
            _usuarioService = usuarioService;
            _sessionService = sessionService;
            _logger = logger;
        }

        [HttpGet("/auth/login")]
        [AllowAnonymous]
        public async Task<IActionResult> LogInUser(string data)
        {
            try
            {
                var parametros = _encryptService.DesencriptarParametros(data);


                string usuario = parametros["idOtp"];

                var usuarioaux = await _usuarioService.GetUsuarioByUser(usuario);

                if (usuarioaux is null) return Unauthorized();

                //Creación de la cookie

                var rememberMe = false;

                bool.TryParse(parametros["rememberme"], out rememberMe);

                string idAuditoria = parametros["id"];
                string url = $"{Request.Scheme}://{Request.Host.Value}";

                var session = new Session()
                {
                    FechaUltimoIngreso = DateTime.Now,
                    Host = url,
                    IdAuditoriaLogin = long.Parse(idAuditoria),
                    IdUsuario = usuarioaux.Id,
                    IpAddress = HttpContext.Connection.RemoteIpAddress.ToString(),
                    IsActive = true,
                    RememberMe = rememberMe,
                };

                var resultSession = await _sessionService.ProcesarIngresoUsuario(session);

                if (!resultSession.IsSuccess)
                {
                    return Unauthorized();
                }

                long idSession = resultSession.Value;

                var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
                identity.AddClaim(new Claim("IdUsuario", usuarioaux.Id.ToString()));
                identity.AddClaim(new Claim("IdSession", idSession.ToString()));
                identity.AddClaim(new Claim("IdAuditoria", idAuditoria.ToString()));
                identity.AddClaim(new Claim("RememberMe", rememberMe.ToString()));
                identity.AddClaim(new Claim("Url", url));
                identity.AddClaim(new Claim("TipoUsuario", "Normal"));

                var principal = new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync(principal, GetAuthenticationProperties(rememberMe));

                return Redirect("/Home");
            }
            catch (Exception exe)
            {
                _logger.LogError(exe, $"Error al procesar authenticación desde controlador");
            }

            return Unauthorized();
        }

        private AuthenticationProperties GetAuthenticationProperties(bool isPersistent)
        {
            return new AuthenticationProperties()
            {
                IsPersistent = isPersistent,
            };
        }

        [HttpGet("/auth/logout")]
        [Authorize]
        public async Task<IActionResult> LogOutUser()
        {
            var sessionId = User.Claims.FirstOrDefault(c => c.Type == "IdSession")!.Value;

            await _sessionService.InhabilitarSession(long.Parse(sessionId));

            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return Redirect("/");
        }
    }
}
