using CatImageApi.Data;
using CatImageApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CatImageApi.Controllers;

[ApiController]
[Route("/api/cats")]
public class CatFactsController : ControllerBase
{
    [HttpGet("facts")]
    public async Task<IActionResult> GetCatFact(string? b, CatDbContext db)
    {
        if (b != null)
        {

        }

        var facts = db.CatFacts.ToList();
        var response = new GetCatFactResponse(facts[Random.Shared.Next(0, facts.Count)]);

        return Ok(response);
    }
}
