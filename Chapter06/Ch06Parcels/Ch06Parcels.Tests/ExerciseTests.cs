using Xunit;
using Ch06Parcels;

namespace Ch06Parcels.Tests;

public class ExerciseTests
{
    [Theory]
    [InlineData(4, 800, 1400)]
    [InlineData(0, 0, 0)]
    [InlineData(-1, 0, 0)]
    [InlineData(7, 1400, 2450)]
    public void InheritedShippingCalculation(int weight, int normalCents, int expressCents)
    {
        var normal = new Parcel("P1", weight);
        var express = new ExpressParcel("E1", weight, "TR42");
        Assert.IsAssignableFrom<Parcel>(express);
        Assert.Equal(Math.Max(0, weight), normal.Weight);
        Assert.Equal(2m, normal.RatePerKg);
        Assert.Equal(3.5m, express.RatePerKg);
        Assert.Equal(normalCents / 100m, normal.GetShippingCost());
        Assert.Equal(expressCents / 100m, express.GetShippingCost());
        Assert.Equal("E1", express.Code);
        Assert.Equal("TR42", express.TrackingCode);
        Assert.Equal("Tracking: TR42", express.GetTrackingDescription());
    }
    [Fact]
    public void ProtectedRateRejectsNegativeValues()
    {
        var parcel = new RateProbe();
        parcel.ChangeRate(4m);
        parcel.ChangeRate(-1m);
        Assert.Equal(4m, parcel.RatePerKg);
        parcel.ChangeRate(0m);
        Assert.Equal(0m, parcel.RatePerKg);
    }
    private class RateProbe : Parcel
    {
        public RateProbe() : base("P", 1m) { }
        public void ChangeRate(decimal rate) { RatePerKg = rate; }
    }

}
