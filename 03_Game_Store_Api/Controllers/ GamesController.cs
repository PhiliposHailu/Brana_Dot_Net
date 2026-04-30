namespace GameStore.Controllers;
using GameStore.Models;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/games")]
public class GamesController : ControllerBase
{
    private static List<Game> games = new List<Game>
    {
        new Game("1", "Elden Ring", "FromSoftware"),
        new Game("2", "The Witcher 3", "CD Projekt Red"),
        new Game("3", "Hades", "Supergiant Games")
    };

    [HttpGet]
    public ActionResult<List<Game>> GetAllGames()
    {
        return games;
    }

    [HttpGet("{id}")]
    public ActionResult<Game> GetGameById(string id)
    {
        var game = games.FirstOrDefault(g => g.Id == id);
        if (game == null)
        {
            return NotFound();
        }
        return Ok(game);
    }

    [HttpPost]
    public ActionResult PostGame(Game game)
    {
        games.Add(game);
        return Created();
    }

    [HttpDelete("{id}")]
    public ActionResult DeleteGame(string id)
    {
        var game = games.FirstOrDefault(g => g.Id == id);
        if (game == null)
        {
            return NotFound();
        }
        games.Remove(game);
        return NoContent();
    }
}