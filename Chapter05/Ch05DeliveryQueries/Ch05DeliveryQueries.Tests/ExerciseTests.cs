using Xunit;
using Ch05DeliveryQueries;

namespace Ch05DeliveryQueries.Tests;

public class ExerciseTests
{
    [Fact]
    public void PendingQueriesUseInclusiveAndStrictLimits()
    {
        var planner = new DeliveryPlanner();
        Assert.Equal(0, planner.CountPendingWithin(5m));
        Assert.False(planner.HasPendingBeyond(0m));
        Assert.Null(planner.GetNextPending());
        Assert.Empty(planner.GetPendingDestinationsWithin(5m));
        var east = new Delivery("D1", "East", 5m, false);
        var west = new Delivery("D2", "West", 2m, false);
        var far = new Delivery("D3", "Far", 12m, false);
        Assert.True(planner.AddDelivery(east));
        Assert.True(planner.AddDelivery(west));
        Assert.True(planner.AddDelivery(far));
        Assert.True(planner.AddDelivery(new Delivery("D4", "Done", 1m, true)));
        Assert.False(planner.AddDelivery(null));
        Assert.False(planner.AddDelivery(new Delivery("D1", "Duplicate", 0m, false)));
        Assert.Equal(4, planner.Count);
        Assert.Equal(2, planner.CountPendingWithin(5m));
        Assert.True(planner.HasPendingBeyond(10m));
        Assert.False(planner.HasPendingBeyond(12m));
        Assert.Equal(new[] { "West", "East" }, planner.GetPendingDestinationsWithin(5m));
        Assert.Same(west, planner.GetNextPending());
        Assert.Same(east, planner.FindByCode("D1"));
        Assert.Null(planner.FindByCode("missing"));
        west.IsDispatched = true;
        Assert.Same(east, planner.GetNextPending());
        east.IsDispatched = true;
        far.IsDispatched = true;
        Assert.Null(planner.GetNextPending());
        Assert.Equal(0, planner.CountPendingWithin(100m));
        Assert.False(planner.HasPendingBeyond(0m));
        Assert.Empty(planner.GetPendingDestinationsWithin(100m));
    }
    [Fact]
    public void NegativeDistanceIgnored()
    {
        var delivery = new Delivery("D", "North", -1m, false);
        Assert.Equal(0m, delivery.DistanceKm);
        delivery.DistanceKm = 5m;
        delivery.DistanceKm = -1m;
        Assert.Equal(5m, delivery.DistanceKm);
    }

}
