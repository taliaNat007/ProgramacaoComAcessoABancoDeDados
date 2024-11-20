using API_Gestao_Facil.DataContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Gestao_Facil.Controllers
{
    [ApiController]
    [Route("servidores")]
    public class ServidorController : Controller
    {
        private readonly AppDbContext _context;

        public ServidorController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            try
            {
                var listaServidores = await _context.Servidores.ToListAsync();

                return Ok();
            }
            catch (Exception e)
            {

                return Problem(e.Message);
            }
        }
        
        [HttpGet("{id}")]
        public IActionResult GetByID(int id)
        {
            try
            {
                return Ok();
            }
            catch (Exception e)
            {

                return Problem(e.Message);
            }
        }
        
        [HttpPost]
        public IActionResult Post()
        {
            try
            {
                return Ok();
            }
            catch (Exception e)
            {

                return Problem(e.Message);
            }
        }
        
        [HttpPut("{id}")]
        public IActionResult Put(int id)
        {
            try
            {
                return Ok();
            }
            catch (Exception e)
            {

                return Problem(e.Message);
            }
        }
        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                return Ok();
            }
            catch (Exception e)
            {

                return Problem(e.Message);
            }
        }

        
    }
}
