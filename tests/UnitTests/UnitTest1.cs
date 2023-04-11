using Microsoft.eShopWeb.Web.Pages.Basket;

namespace UnitTests;

public class UnitTest1
{
    [Fact]
    public void ShouldApplyPromo()
    {
        var basketViewModel = new BasketViewModel();
        var itemToAdd = new BasketItemViewModel()
        {
            UnitPrice = new decimal(60),
            Quantity = 2
        };

        basketViewModel.Items.Add(itemToAdd);

        var total = basketViewModel.Total();
        Assert.Equal(new decimal(60.0 * 2 * .9), total);
    }
}

