using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Domain.Entities.Parametrizacion;
using PruebaTecnica.Domain.Entities.Prueba;
using PruebaTecnica.Services.Interfaces.Parametrizacion;
using PruebaTecnica.Services.Interfaces.Perfilamiento;
using PruebaTecnica.Services.Interfaces.Prueba;

namespace PruebaTecnica.Web.Controllers;

[Route("api/[controller]")]
public class PruebaController : ControllerBase
{
    private readonly IPruebaService _pruebaService;
    private readonly IParametroGeneralService _parService;

    public PruebaController
    (
        IPruebaService pruebaService,
        IParametroGeneralService parametroGeneralService
    )
    {
        _pruebaService = pruebaService;
        _parService = parametroGeneralService;
    }


    [HttpGet("consultarEstadocivil")]
    public async Task<ActionResult<List<ParametroDetallado>>> consultarEstado()
    {
        var Estados = await _parService.ConsultarParametroGeneralById(2);

        return Ok(Estados.ListaParametrosDetallados);
    }
    [HttpGet("consultarTiposDocumento")]
    public async Task<ActionResult<List<ParametroDetallado>>> consultarTipDoc()
    {
        var tipdoc = await _parService.ConsultarParametroGeneralById(3);

        return Ok(tipdoc.ListaParametrosDetallados);
    }
    [HttpGet("consultarPruebas")]
    public async Task<ActionResult<List<PruebaModel>>> consultarPruebas()
    {
        var pruebas = await _pruebaService.consulatPruebas();

        return Ok(pruebas.ToList());
    }
}
