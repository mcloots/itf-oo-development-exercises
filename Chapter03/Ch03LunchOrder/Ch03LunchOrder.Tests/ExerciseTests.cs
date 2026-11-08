using Xunit;
using Ch03LunchOrder;

namespace Ch03LunchOrder.Tests;

public class ExerciseTests
{
    [Fact]
    public void QuantityUpdatesAndTotals()
    {
        var order = new LunchOrder("Cheese", 4.50m, 3);
        Assert.Equal("Cheese", order.GetSandwichName());
        Assert.Equal(4.50m, order.GetUnitPrice());
        Assert.Equal(13.50m, order.CalculateTotal());
        order.SetQuantity(5);
        Assert.Equal(22.50m, order.CalculateTotal());
        order.SetQuantity(0);
        Assert.Equal(5, order.GetQuantity());
        order.SetQuantity(20);
        order.SetQuantity(21);
        Assert.Equal(20, order.GetQuantity());
        Assert.Equal(90m, order.CalculateTotal());
        Assert.Contains("Cheese", order.GetDescription());
    }
    [Theory]
    [InlineData(-2)]
    [InlineData(0)]
    [InlineData(21)]
    public void InvalidConstructionAndUpdates(int quantity)
    {
        var order = new LunchOrder(" ", -1m, quantity);
        Assert.Equal("Lunch", order.GetSandwichName());
        Assert.Equal(0m, order.GetUnitPrice());
        Assert.Equal(1, order.GetQuantity());
        order.SetQuantity(2);
        order.SetQuantity(quantity);
        Assert.Equal(2, order.GetQuantity());
    }

}
