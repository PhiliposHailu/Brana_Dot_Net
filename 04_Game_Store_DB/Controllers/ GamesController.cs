namespace GameStore.Controllers;
using GameStore.Data;
using GameStore.Models;

using Microsoft.AspNetCore.Mvc;

using Microsoft.EntityFrameworkCore; // we need this for async EF Core methods!

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

    [HttpGet("{id}")]
    public async Task<ActionResult<Game>> GetGameById(string id)
    {
        var game = await _context.Games.FindAsync(id);
        if (game == null)
        {
            return NotFound();
        }
        return Ok(game);
    }

    [HttpPost]
    public async Task<ActionResult<Game>> PostGame(Game game)
    {
        _context.Games.Add(game);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetGameById), new { id = game.Id }, game);
    }

[   HttpDelete("{id}")]
    public async Task<ActionResult<Game>> DeleteGame(string id)
    {
        var game = await _context.Games.FindAsync(id);
        if (game == null)
        {
            return NotFound();
        }
        _context.Games.Remove(game);
        await _context.SaveChangesAsync();
        return NoContent();
    }

}