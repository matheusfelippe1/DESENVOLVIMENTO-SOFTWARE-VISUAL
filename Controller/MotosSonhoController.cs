using Microsoft.AspNetCore.Mvc;
using Motocicleta.Model;

namespace Motocicleta.Controllers
{
    [ApiController]
    [Route("{controller}")]
    public class MotosSonhoController : ControllerBase
    {
        private static List<MotosSonho> MotosSonhos = new List<MotosSonho>();

        [HttpPost]
        public void addMotosSonho([FromBody] MotosSonho Foguetao)
        {
            MotosSonhos.Add(Foguetao);
        }

        [HttpGet]
        public IActionResult GetMotosSonho()
        {
            return Ok(MotosSonhos);
        }

        [HttpGet ("{id}")]
        public IActionResult GetMotosSonhoById(int id)
        {
            MotosSonho motosSonhos = MotosSonhos.FirstOrDefault(motosSonhos => motosSonhos.Id == id);
            if (motosSonhos != null)
            {
                return Ok(motosSonhos);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
