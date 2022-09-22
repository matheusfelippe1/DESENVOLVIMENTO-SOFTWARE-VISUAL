using Microsoft.AspNetCore.Mvc;
using Motocicleta.Data;
using Motocicleta.Model;

namespace Motocicleta.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class MotoConquistadaController : ControllerBase
    {
        private static List<MotoConquistada> motoConquistadaList = new List<MotoConquistada>();
        private readonly Context _context;

        public MotoConquistadaController(Context context)
        {
            _context = context;
        }

        [HttpPost]
        public void AddMoto([FromBody] MotoConquistada moto)
        {
            _context.MotoConquistada.Add(moto);
            _context.SaveChanges();
        }

        [HttpGet]
        public IActionResult GetMotoConquistada()
        {
            return Ok(_context.MotoConquistada.ToList());
        }

        [HttpGet("{id}")]
        public ActionResult GetMotoConquistadaById(int id)
        {
            MotoConquistada motoConquistada = _context.MotoConquistada.FirstOrDefault(motoConquistada => motoConquistada.Id == id);
            if (motoConquistada != null)
            {
                return Ok(motoConquistada);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpDelete("{id}")]
        public void Deletar(int id)
        {
            var motoConquistada = _context.MotoConquistada.FirstOrDefault(motoConquistada => motoConquistada.Id == id);
            if(motoConquistada != null)
            {
                _context.MotoConquistada.Remove(motoConquistada);
                _context.SaveChanges();
            }
        }
    }
}
