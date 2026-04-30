InventoryManager manager = new InventoryManager();
List<Book> books = [
    new Book("The Great Gatsby", "F. Scott Fitzgerald", 5000),
    new Book("To Kill a Mockingbird", "Harper Lee", 3000),
    new Book("1984", "George Orwell", 4000),
    new Book("Pride and Prejudice", "Jane Austen", 2500),
    new Book("The Catcher in the Rye", "J.D. Salinger", 3500)
];

List<Electronics> electronics = [
    new Electronics("Smartphone", 1, 99999),
    new Electronics("Laptop", 2, 149999),
    new Electronics("Headphones", 3, 19999),
    new Electronics("Smartwatch", 4, 29999),
    new Electronics("Tablet", 5, 49999)
];

for (int i = 0; i < books.Count; i++)
{
    manager.AddItem(books[i]);
}
for (int i = 0; i < electronics.Count; i++)
{
    manager.AddItem(electronics[i]);
}

// List<Item> allItems = manager.GetAllItems();
// Console.WriteLine("All Items:");
// foreach (var item in allItems)
// {    Console.WriteLine($"{item.Title} - {item.Price} cents");
// }   

// List<Item> itemsUnder4000 = manager.GetItemsUnderPrice(4000);
// Console.WriteLine("\nItems under 4000 cents:");
// foreach (var item in itemsUnder4000)
// {    Console.WriteLine($"{item.Title} - {item.Price} cents");
// }

foreach (var item in manager.GetAllItems())
{
    Console.WriteLine(item.GetDetails());
}