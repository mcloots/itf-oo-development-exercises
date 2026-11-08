using Xunit;
using Ch03WaterBottle;

namespace Ch03WaterBottle.Tests;

public class ExerciseTests
{
    [Fact]
    public void ActionsPreserveValidContents()
    {
        var bottle = new WaterBottle("Blue", 750);
        Assert.Equal(0, bottle.GetContents());
        Assert.True(bottle.Fill(500));
        Assert.True(bottle.Drink(200));
        Assert.False(bottle.Fill(500));
        Assert.Equal(300, bottle.GetContents());
        Assert.False(bottle.Drink(301));
        Assert.Equal(300, bottle.GetContents());
        Assert.True(bottle.Fill(450));
        Assert.Equal(750, bottle.GetContents());
        Assert.True(bottle.Drink(750));
        Assert.Equal(0, bottle.GetContents());
        Assert.Equal(0, new WaterBottle("Other", 750).GetContents());
    }
    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public void RefusedAmountsLeaveContents(int amount)
    {
        var bottle = new WaterBottle("Blue", 750);
        bottle.Fill(100);
        Assert.False(bottle.Fill(amount));
        Assert.False(bottle.Drink(amount));
        Assert.Equal(100, bottle.GetContents());
    }
    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public void InvalidCapacityUsesDefault(int capacity)
    {
        var bottle = new WaterBottle(" ", capacity);
        Assert.Equal(500, bottle.GetCapacity());
        Assert.Equal("Bottle", bottle.GetLabel());
        bottle.SetLabel("Mine");
        Assert.Equal("Mine", bottle.GetLabel());
        bottle.SetLabel("");
        Assert.Equal("Bottle", bottle.GetLabel());
    }

}
