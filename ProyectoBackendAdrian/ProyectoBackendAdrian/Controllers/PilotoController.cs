using Microsoft.AspNetCore.Mvc;
using ProyectoBackendAdrian.Models;
using WebApplication3.Contexto;

namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PilotoController : ControllerBase
    {

            private readonly ILogger<PilotoController> _logger;
            private readonly AplicacionContexto _aplicacionContexto;

            public PilotoController(ILogger<PilotoController> logger, AplicacionContexto aplicacionContexto)
            {
                _logger = logger;
                _aplicacionContexto = aplicacionContexto;
            }
            [Route("")]
            [HttpGet]
            public IEnumerable<Piloto> GET()
            {
                return _aplicacionContexto.piloto.ToList();
            }

            [Route("")]
            [HttpPost]
            public IActionResult POST([FromBody] Piloto newPiloto)
            {
                _aplicacionContexto.piloto.Add(newPiloto);
                _aplicacionContexto.SaveChanges();
                return Ok(newPiloto);
            }

            [Route("")]
            [HttpPut]
            public IActionResult PUT([FromBody] Piloto updatePiloto)
            {
                _aplicacionContexto.piloto.Update(updatePiloto);
                _aplicacionContexto.SaveChanges();
                return Ok(updatePiloto);
            }

            [Route("")]
            [HttpDelete]
            public IActionResult DELETE(int idPilotoDelete)
            {
                _aplicacionContexto.piloto.Remove(_aplicacionContexto.piloto.ToList().Where(x => x.numero_licencia== idPilotoDelete).FirstOrDefault());
                _aplicacionContexto.SaveChanges();
                return Ok(idPilotoDelete);
            }

        }
    
}