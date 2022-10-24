using GeradorPersonagemRpg.Api.Domain.Entities;
using GeradorPersonagemRpg.Api.Domain.Enums.Vampiro;
using Microsoft.AspNetCore.Mvc;

namespace GeradorPersonagemRpg.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class VampiroController : BaseController
{
    [HttpGet("exemplo")]
    public IActionResult Index()
    {
        var vampiro = new Vampiro(Cla.Brujah, TipoVampiro.Neofito);
        
        return Ok(vampiro);
    }

    [HttpPost]
    public IActionResult Post(Cla cla, TipoVampiro tipoVampiro)
    {
        var vampiro = new Vampiro(cla, tipoVampiro);
        
        return Ok(vampiro);
    }

    [HttpPost("criar")]
    public IActionResult Criar(Vampiro vampiro)
    {
        return Ok();
    }
}