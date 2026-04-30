public interface IInventoryManager
{
    void AddItem(Item item);
    List<Item> GetAllItems();
    List<Item> GetItemsUnderPrice(double maxPrice);
}