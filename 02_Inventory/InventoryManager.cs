public class InventoryManager : IInventoryManager
{
    private List<Item> MyList {set; get;  }
    public InventoryManager()
    {
        MyList = [];
    }
    public void AddItem(Item item)
    {
        MyList.Add(item);
    }
    public List<Item> GetAllItems()
    {
        return MyList;
    }
    public List<Item> GetItemsUnderPrice(double maxPrice)
    {
        return MyList.Where(item => item.Price <= maxPrice).ToList();
    }
}