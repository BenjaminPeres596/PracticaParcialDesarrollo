using Microsoft.AspNetCore.Mvc;

namespace ParcialAPI.Controllers
{
    public class ConcatenadorController : ControllerBase
    {
        private readonly ILogger<ConcatenadorController> _logger;

        public ConcatenadorController(ILogger<ConcatenadorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("Concatenar", Name = "Concatenar")]
        public ActionResult Concatenar(string palabra1, string palabra2)
        {
            var resultado = string.Concat(palabra1, palabra2);
            return Ok(resultado);
        }
    }
}
