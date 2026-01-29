using CatImageApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CatImageApi.Controllers;

[ApiController]
[Route("/api/cats")]
public class CatFactsController : ControllerBase
{
    [HttpGet("facts")]
    public async Task<IActionResult> GetCatFact(string? b)
    {
        if (b != null)
        {

        }

        return Ok(new GetCatFactResponse() { Fact = "Cats are nice" });
    }
}
