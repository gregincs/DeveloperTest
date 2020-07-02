using Api1.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DeveloperTest.Controllers
{
    [ApiController]
    [Route("taxajuros")]
    public class TaxaJurosController : ControllerBase
    {
        private readonly ILogger<TaxaJurosController> _logger;

        public TaxaJurosController(ILogger<TaxaJurosController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<ResponseJuros> Get()
        {
            _logger.LogInformation("Getting interest rate");
            var taxa = new ResponseJuros()
            {
                Taxa = 0.01m
            };

            return taxa;
        }
    }
}
