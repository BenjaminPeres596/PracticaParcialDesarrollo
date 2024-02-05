using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ParcialAPI.Controllers
{
    public class CiudadController : Controller
    {

        private static List<Ciudad> Ciudades = new List<Ciudad>
        {
            new Ciudad { Nombre = "La Plata" },
            new Ciudad { Nombre = "Paris" },
            new Ciudad { Nombre = "Hawai" }
        };
        private static List<Ciudad> CiudadesSeleccionadas = new List<Ciudad>();

        [HttpGet("GetCiudadesSeleccionada", Name = "GetCiudadesSeleccionadas")]
        public ActionResult GetCiudadesSeleccionadas()
        {
            return Ok(CiudadesSeleccionadas);
        }

        [HttpPost("CiudadSeleccionada", Name = "CiudadSeleccionada")]
        public ActionResult IngresarCiudad(string NombreCiudad)
        {
            var buscador = Ciudades.FirstOrDefault(c => c.Nombre == NombreCiudad);
            if (buscador == null) 
            { 
                return NotFound();
            }
            else
            {
                CiudadesSeleccionadas.Add(buscador);
                return CreatedAtAction(nameof(GetCiudadesSeleccionadas), buscador);
            }
        }
    }
}
