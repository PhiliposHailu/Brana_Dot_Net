public abstract class Item
{
    public int Id { get; set; }
    public string Title { get; set; }
    public double Price { get; set; }
    public Item(string title, double price)
    {
        Title = title;
        Price = price;
    }

    public abstract string GetDetails();
}