using Microsoft.AspNetCore.Mvc;

namespace TaxaJuros.api.Controllers
{
    [Route("api/v1/calcular")]
    [ApiController]

    public class ValorAtualizadoController : ControllerBase
    {       

        [HttpPost]
        [Route("valoratualizado")]
        public IActionResult ValorAtualizado(double valorAtualizado)
        {
           
            return Ok(valorAtualizado);
        }

        
    }
}
