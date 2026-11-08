using Xunit;
using Ch05QueryResults;

namespace Ch05QueryResults.Tests;

public class ExerciseTests
{
    [Fact]
    public void MaterializedMembershipAndSharedObjects()
    {
        var inventory = new EquipmentInventory();
        Assert.Empty(inventory.GetAvailable(25m));
        Assert.Empty(inventory.GetAvailableNames(25m));
        Assert.Empty(inventory.GetCodes());
        Assert.Null(inventory.FindByCode("unknown"));
        var camera = new Equipment("E1", "Camera", 20m, true);
        var tripod = new Equipment("E2", "Tripod", 5m, true);
        Assert.True(inventory.AddItem(camera));
        Assert.True(inventory.AddItem(tripod));
        Assert.True(inventory.AddItem(new Equipment("E3", "Projector", 30m, false)));
        Assert.False(inventory.AddItem(null));
        Assert.False(inventory.AddItem(new Equipment("E1", "Duplicate", 0m, true)));
        var objects = inventory.GetAvailable(20m);
        var names = inventory.GetAvailableNames(20m);
        Assert.Equal(new[] { tripod, camera }, objects);
        Assert.Equal(new[] { "Tripod", "Camera" }, names);
        Assert.Same(camera, inventory.FindByCode("E1"));
        camera.DailyPrice = 40m;
        camera.Name = "Studio camera";
        Assert.Equal(2, objects.Count);
        Assert.Single(inventory.GetAvailable(25m));
        Assert.Equal("Studio camera", objects[1].Name);
        Assert.Equal(new[] { "Tripod", "Camera" }, names);
        objects.Clear();
        inventory.GetCodes().Clear();
        Assert.Equal(3, inventory.Count);
        Assert.Equal(new[] { "E1", "E2", "E3" }, inventory.GetCodes());
        tripod.IsAvailable = false;
        Assert.Empty(inventory.GetAvailable(25m));
    }
    [Fact]
    public void NegativePriceIgnored()
    {
        var item = new Equipment("E1", "Camera", -1m, true);
        Assert.Equal(0m, item.DailyPrice);
        item.DailyPrice = 5m;
        item.DailyPrice = -1m;
        Assert.Equal(5m, item.DailyPrice);
    }

}
