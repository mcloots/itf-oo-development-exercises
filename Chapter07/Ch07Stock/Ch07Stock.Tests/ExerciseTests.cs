using Xunit;
using Ch07Stock;

namespace Ch07Stock.Tests;

public class ExerciseTests
{
    [Fact]
    public void RefusalThenSuccessAndExactDepletion()
    {
        var item = new StockItem("P1", 10);
        Assert.Equal("P1", item.Code);
        item.Take(4);
        Assert.Equal(6, item.Quantity);
        Assert.Throws<StockOperationException>(() => item.Take(7));
        Assert.Equal(6, item.Quantity);
        item.Take(2);
        Assert.Equal(4, item.Quantity);
        item.Take(4);
        Assert.Equal(0, item.Quantity);
        Assert.Throws<StockOperationException>(() => item.Take(1));
        Assert.Equal(0, item.Quantity);
    }
    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    [InlineData(11)]
    public void InvalidAmountsPreserveQuantity(int amount)
    {
        var item = new StockItem("P1", 10);
        Assert.Throws<StockOperationException>(() => item.Take(amount));
        Assert.Equal(10, item.Quantity);
    }
    [Fact]
    public void ConstructionAndExceptionType()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new StockItem("P1", -1));
        Assert.Equal(0, new StockItem("P1", 0).Quantity);
        Assert.IsAssignableFrom<Exception>(new StockOperationException("Reason"));
        Assert.Equal("Reason", new StockOperationException("Reason").Message);
    }

}
