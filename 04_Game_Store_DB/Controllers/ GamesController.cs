namespace GameStore.Controllers;
using GameStore.Data;
using GameStore.Models;

using Microsoft.AspNetCore.Mvc;

using Microsoft.EntityFrameworkCore; // You need this for async EF Core methods!

[ApiController]
[Route("api/games")]
public class GamesController : ControllerBase
{
    private readonly AppDbContext _context;

    public GamesController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
public async Task<ActionResult<List<Game>>> GetAllGames()
{
    var games = await _context.Games.ToListAsync();
    return Ok(games);
}
}