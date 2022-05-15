using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoUnimed.Context;
using ProjetoUnimed.Models;

namespace ProjetoUnimed.Controllers
{
    [ApiController]
    public class PessoaController : ControllerBase
    {
        [HttpGet]
        [Route(template:"Pessoas")]
        public async Task<IActionResult> GetAsync ()
        {
            using var context = new UnimedContext();
            var pessoas = await context.Pessoas.AsNoTracking().ToListAsync();
            
            return Ok(pessoas);
        }

        [HttpGet]
        [Route(template:"Pessoas/{id}")]
        public async Task<IActionResult> GetByIdAsync ([FromRoute] int id)
        {
            using var context = new UnimedContext();
            var pessoa = await context.Pessoas.AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == id);

            return pessoa == null ? NotFound() : Ok(pessoa);
        }
    }
}