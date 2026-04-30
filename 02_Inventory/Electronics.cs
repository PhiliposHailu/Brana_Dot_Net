public class Electronics: Item
{
    public int WarrantyMonths;
    public Electronics(string title, int warrantyMonths, double price) : base(title, price)
    {
        WarrantyMonths = warrantyMonths;
    }
     public override string GetDetails()
    {
        return ($"Title: {Title} | WarrantyMonths: {WarrantyMonths} | Price: {Price}");
    }
}