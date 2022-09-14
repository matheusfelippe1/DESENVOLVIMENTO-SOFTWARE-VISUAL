using Microsoft.AspNetCore.Mvc;
using Motocicleta.Model;

namespace Motocicleta.Controllers
{
    [ApiController]
    [Route("{Controller}")]
    public class MotoConquistadaController : ControllerBase
    {
        private static List<MotoConquistada> MotoConquistadas = new List<MotoConquistada>();

        [HttpPost]
        public void addMotoConquistada([FromBody] MotoConquistada conquista)
        {
            MotoConquistadas.Add(conquista);
        }

        [HttpGet]
        public IActionResult GetMotoConquistada()
        {
            return Ok(MotoConquistadas);
        }

        [HttpGet("{id}")]
        public IActionResult GetMotoConquistadaById(int id)
        {
            MotoConquistada motoConquistada = MotoConquistadas.FirstOrDefault(motosConquistada => motosConquistada.Id == id);
            if (motoConquistada != null)
            {
                return Ok(motoConquistada);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
