namespace GameStore.Models;
public class Game(string id, string title, string developer)
{
    public string Id { get; set; } = id;
    public string Title { get; set; } = title;
    public string Developer { get; set; } = developer;
}