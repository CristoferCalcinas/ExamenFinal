using Microsoft.AspNetCore.Mvc;
using ProyectoBackendAdrian.Models;
using WebApplication3.Contexto;

namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HangarController : ControllerBase
    {
        private readonly ILogger<HangarController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;

        public HangarController(ILogger<HangarController> logger, AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
            [Route("")]
            [HttpGet]
        public IEnumerable<Hangar> GET()
        {
            return _aplicacionContexto.hangar.ToList();
        }

        [Route("")]
        [HttpPost]
        public IActionResult POST([FromBody] Hangar newHangar)
        {
            _aplicacionContexto.hangar.Add(newHangar);
            _aplicacionContexto.SaveChanges();
            return Ok(newHangar);
        }

        [Route("")]
        [HttpPut]
        public IActionResult PUT([FromBody] Hangar updateHangar)
        {
            _aplicacionContexto.hangar.Update(updateHangar);
            _aplicacionContexto.SaveChanges();
            return Ok(updateHangar);
        }

        [Route("")]
        [HttpDelete]
        public IActionResult DELETE(int idHangarDelete)
        {
            _aplicacionContexto.hangar.Remove(_aplicacionContexto.hangar.ToList().Where(x => x.numero_hangar == idHangarDelete).FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(idHangarDelete);
        }
    }
}
