using System.Dynamic;

public class Book : Item
{
    public string Author { get; set; }
    public Book(string title, string author, double price) : base(title, price)
    {
        Author = author;
    }
    public override string GetDetails()
    {
        return ($"Title: {Title} | Author: {Author} | Price: {Price}");
    }
}