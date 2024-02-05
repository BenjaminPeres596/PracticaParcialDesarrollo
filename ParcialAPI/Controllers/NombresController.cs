using Microsoft.AspNetCore.Mvc;

namespace ParcialAPI.Controllers
{
    public class NombresController : ControllerBase
    {
        private readonly ILogger<NombresController> _logger;

        public NombresController(ILogger<NombresController> logger)
        {
            _logger = logger;
        }

        [HttpGet ("ListarNombres",Name = "ListarNombres")]
        public ActionResult<IEnumerable<Nombre>> Get()
        {
            var Nombres = new List<Nombre>
            {
                new Nombre { Name = "Benjamin" },
                new Nombre { Name = "Juan" },
                new Nombre { Name = "Mariano" }
            };
            return Ok(Nombres);
        }
    }
}
