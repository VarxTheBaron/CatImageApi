using CatImageApi.Models;
using Microsoft.AspNetCore.Mvc;
namespace CatImageApi.Controllers;

[ApiController]
[Route("/api/cats")]
public class RandomCatController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetRandomCats()
    {
        return Ok(new GetCatResponse()
        {
            Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/88/Ragdoll%2C_blue_mitted.JPG/1280px-Ragdoll%2C_blue_mitted.JPG",
            Description = "Nice ragdoll kitty."
        });
    }
}
