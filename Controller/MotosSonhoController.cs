using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Motocicleta.Data;
using Motocicleta.Model;

namespace Motocicleta.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class MotosSonhoController : ControllerBase
    {
        private static List<MotosSonho> MotosSonhosList = new List<MotosSonho>();
        private readonly Context _context;

        public MotosSonhoController(Context context)
        {
            _context = context;
        }

        [HttpPost]
        public void addMotosSonho([FromBody] MotosSonho Foguetao)
        {
            _context.MotoSonho.Add(Foguetao);
            _context.SaveChanges();
        }

        [HttpGet]
        public IActionResult GetMotosSonho()
        {
            return Ok(_context.MotoSonho.ToList());
        }

        [HttpGet ("{id}")]
        public ActionResult GetMotosSonhoById(int id)
        {
            MotosSonho motosSonhos = _context.MotoSonho.FirstOrDefault(motosSonhos => motosSonhos.Id == id);
            if (motosSonhos != null)
            {
                return Ok(motosSonhos);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpDelete("{id}")]
        public void Remove(int id)
        {
            var motosSonhos = _context.MotoSonho.FirstOrDefault(motosSonhos => motosSonhos.Id == id);
            if(motosSonhos != null)
            {
                _context.MotoSonho.Remove(motosSonhos);
                _context.SaveChanges();
            }
        }
    }
}
