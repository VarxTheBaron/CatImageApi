using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CatImageApi.Data;
using CatImageApi.Models;

namespace CatImageApi.Controllers
{
    [ApiController]
    [Route("api/cats")]
    public class CatController : ControllerBase
    {
        private readonly CatDbContext _context;

        public CatController(CatDbContext context)
        {
            _context = context;
        }

        // GET: api/cat/random - Få en slumpmässig katt
        [HttpGet("random")]
        public async Task<ActionResult<Cat>> GetRandomCat()
        {
            var count = await _context.Cats.CountAsync();
            if (count == 0)
                return NotFound("Inga katter i databasen");

            var random = new Random();
            var skip = random.Next(0, count);

            var cat = await _context.Cats
                .Skip(skip)
                .Select(c => new GetCatResponse(c))
                .FirstOrDefaultAsync();

            return Ok(cat);
        }

    }
}