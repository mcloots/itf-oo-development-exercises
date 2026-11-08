using Xunit;
using Ch02ParcelDelivery;
using App = Ch02ParcelDelivery.Program;

namespace Ch02ParcelDelivery.Tests;

public class ExerciseTests
{
    [Theory]
    [InlineData(-1, false)]
    [InlineData(0, false)]
    [InlineData(1, true)]
    [InlineData(50, true)]
    [InlineData(2000, true)]
    [InlineData(2001, false)]
    public void WeightBoundaries(int hundredths, bool valid)
    {
        Assert.Equal(valid, App.IsValidWeight(hundredths / 100m));
    }
    [Theory]
    [InlineData(200, false, 700)]
    [InlineData(200, true, 1000)]
    [InlineData(50, false, 475)]
    [InlineData(2000, true, 3700)]
    [InlineData(340, false, 910)]
    public void DeliveryPrices(int hundredths, bool express, int cents)
    {
        Assert.Equal(cents / 100m, App.CalculateDeliveryPrice(hundredths / 100m, express));
    }

}
