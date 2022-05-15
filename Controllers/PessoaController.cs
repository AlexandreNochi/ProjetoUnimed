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
        public async Task<IActionResult> Get ()
        {
            using var context = new UnimedContext();
            var pessoas = await context.Pessoas.AsNoTracking().ToListAsync();
            return Ok(pessoas);
        }
    }
}