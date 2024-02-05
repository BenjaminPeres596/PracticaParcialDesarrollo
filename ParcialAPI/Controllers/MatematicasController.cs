using Microsoft.AspNetCore.Mvc;
using Matematicas;
using Servicios;

namespace ParcialAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MatematicasController : ControllerBase
    {
        private readonly ILogger<MatematicasController> _logger;
        private readonly IOperacionesServicio _OperacionesServicio;

        public MatematicasController(ILogger<MatematicasController> logger, IOperacionesServicio OperacionesServicio)
        {
            _logger = logger;
            _OperacionesServicio = OperacionesServicio;
        }

        OpMat claseMatematicas = new OpMat();

        [HttpGet("Sumar", Name = "Sumar")]
        public ActionResult Sumar(int primerEntero, int segundoEntero)
        {
            var Resultado = claseMatematicas.Sumar(primerEntero, segundoEntero);
            return Ok(Resultado);
        }
        [HttpGet("Multiplicar", Name = "Multplicar")]
        public ActionResult Multiplicar(int primerEntero, int segundoEntero)
        {
            var Resultado = claseMatematicas.Multiplicar(primerEntero, segundoEntero);
            return Ok(Resultado);
        }

        [HttpGet("SumarService", Name = "SumarService")]
        public ActionResult SumarService (int primerEntero, int segundoEntero)
        {
            var resultado = _OperacionesServicio.Suma(primerEntero, segundoEntero);
            return Ok(resultado);
        }
    }
}