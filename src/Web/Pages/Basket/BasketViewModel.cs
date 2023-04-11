namespace Microsoft.eShopWeb.Web.Pages.Basket;

public class BasketViewModel
{
    public int Id { get; set; }
    public List<BasketItemViewModel> Items { get; set; } = new List<BasketItemViewModel>();
    public string? BuyerId { get; set; }

    public bool WasPromotionApplied { get; set; }

    public decimal Total()
    {
        var total = Math.Round(Items.Sum(x => x.UnitPrice * x.Quantity), 2);
        if (total > 55)
        {
            this.WasPromotionApplied = true;
            total = Math.Round(total * new decimal(0.9), 2); // this line should be missing in the bug
        }

        return total;
    }
}
