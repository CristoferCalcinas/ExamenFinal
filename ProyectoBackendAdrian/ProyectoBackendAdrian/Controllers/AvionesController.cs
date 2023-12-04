using Microsoft.AspNetCore.Mvc;
using ProyectoBackendAdrian.Models;
using WebApplication3.Contexto;

namespace WebApplication3.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AvionesController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        
        public AvionesController(ILogger<AvionesController> logger, AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<Aviones> GET()
        {
            return _aplicacionContexto.aviones.ToList();
        }

        [HttpPost]
        [Route("")]
        public IActionResult POST([FromBody] Aviones newAvion)
        {
            _aplicacionContexto.aviones.Add(newAvion);
            _aplicacionContexto.SaveChanges();
            return Ok(newAvion);
        }

        [HttpPut]
        [Route("")]
        public IActionResult PUT([FromBody] Aviones avionUpdate)
        {
            _aplicacionContexto.aviones.Update(avionUpdate);
            _aplicacionContexto.SaveChanges();
            return Ok(avionUpdate);
        }

        [HttpDelete]
        [Route("")]
        public IActionResult DELETE(int idAvionDelete)
        {
            _aplicacionContexto.aviones.Remove(_aplicacionContexto.aviones.ToList().Where(x=>x.numero == idAvionDelete).FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(idAvionDelete);
        }
    }
}
