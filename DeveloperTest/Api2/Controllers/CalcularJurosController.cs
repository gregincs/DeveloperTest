using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api2.Core;
using Api2.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Api2.Controllers
{
    [ApiController]
    [Route("calcularjuros")]
    public class CalcularJurosController : ControllerBase
    {
        private readonly ILogger<CalcularJurosController> _logger;
        private readonly ICalcularJuro _calcularJuro;
        public CalcularJurosController(ILogger<CalcularJurosController> logger, ICalcularJuro calcularJuro)
        {
            _logger = logger;
            _calcularJuro = calcularJuro;
        }

        [HttpGet]
        public async Task<ActionResult<ResponseCalculoJuros>> GetAsync([FromQuery]decimal ValorInicial, [FromQuery]int Meses)
        {
            _logger.LogInformation("Calculando juros");
            return await _calcularJuro.JuroPorMesesAsync(ValorInicial, Meses);
        }
    }
}
