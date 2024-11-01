using ConversorDeMedidas.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace ConversorDeMedidas.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConversorController : ControllerBase
    {
        private readonly ConversorService _conversorService;

        public ConversorController()
        {
            _conversorService = new ConversorService();
        }

        [HttpGet("convert")]
        public ActionResult<double> Convert(double valor, string unidadeOrigem, string unidadeDestino)
        {
            if (unidadeOrigem == unidadeDestino)
            {
                return BadRequest("Favor selecionar opções diferentes para conversão"); 
 
            }
            var resultado = _conversorService.Converter(valor, unidadeOrigem, unidadeDestino);
            return Ok(resultado);
        }
    }
}
