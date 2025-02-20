using Xunit;
using OrderProcessingApp.Models;

public class DiscountTests
{
    [Fact]
    public void TestLoyalCustomerDiscount()
    {
        var order = new Order
        {
            Amount = 150,
            CustomerType = "Loyal"
        };

        if (order.Amount >= 100 && order.CustomerType == "Loyal")
        {
            order.Discount = order.Amount * 0.1m;
        }
        else
        {
            order.Discount = 0;
        }

        order.FinalAmount = order.Amount - order.Discount;

        Assert.Equal(15, order.Discount);
        Assert.Equal(135, order.FinalAmount);
    }

    [Fact]
    public void TestNonLoyalCustomerNoDiscount()
    {
        var order = new Order
        {
            Amount = 150,
            CustomerType = "New"
        };

        if (order.Amount >= 100 && order.CustomerType == "Loyal")
        {
            order.Discount = order.Amount * 0.1m;
        }
        else
        {
            order.Discount = 0;
        }

        order.FinalAmount = order.Amount - order.Discount;

        Assert.Equal(0, order.Discount);
        Assert.Equal(150, order.FinalAmount);
    }
}
