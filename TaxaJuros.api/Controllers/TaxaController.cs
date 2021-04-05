using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaxaJuros.api.Models;
using TaxaJuros.api.Models.Taxa;

namespace TaxaJuros.api.Controllers
{
    [Route("api/v1/taxa")]
    [ApiController]

    public class TaxaController : ControllerBase
    {

        [SwaggerResponse(statusCode: 200,"Sucesso", Type = typeof(CalcularViewModel))]
        [SwaggerResponse(statusCode: 400, "Campos obrigatórios vazios.", Type = typeof(ValidaCampoViewModelOutput))]
        [SwaggerResponse(statusCode: 500, "Erro interno.", Type = typeof(ErroGenericoViewModel))]

        [HttpPost]
        [Route("valor")]
        public IActionResult Taxa(TaxaViewModelInput taxaViewModelInput)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ValidaCampoViewModelOutput(ModelState.SelectMany(
                    sm => sm.Value.Errors).Select(s => s.ErrorMessage)));
                ;
                ;
            }
            return Ok(taxaViewModelInput);
        }

        [HttpPost]
        [Route("calcular")]

        public IActionResult Calcular(CalcularViewModel calcularViewModelInput)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ValidaCampoViewModelOutput(ModelState.SelectMany(
                    sm => sm.Value.Errors).Select(s => s.ErrorMessage)));
                ;
                ;
            }
            return Ok(calcularViewModelInput);
        }
    }
}
