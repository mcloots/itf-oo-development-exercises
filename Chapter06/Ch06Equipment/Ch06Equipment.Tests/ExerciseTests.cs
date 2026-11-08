using Xunit;
using Ch06Equipment;

namespace Ch06Equipment.Tests;

public class ExerciseTests
{
    [Theory]
    [InlineData(-1)]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(3)]
    public void RentalCosts(int days)
    {
        Assert.Equal(5m * Math.Max(0, days), new Equipment("E").GetRentalCost(days));
        Assert.Equal(12m * Math.Max(0, days), new Camera("C", 24).GetRentalCost(days));
        Assert.Equal(20m * Math.Max(0, days), new Projector("P", 3500).GetRentalCost(days));
    }
    [Theory]
    [InlineData(-1, false)]
    [InlineData(23, false)]
    [InlineData(24, true)]
    [InlineData(25, true)]
    public void CameraThreshold(int pixels, bool poster)
    {
        var camera = new Camera("C", pixels);
        Assert.Equal(Math.Max(0, pixels), camera.Megapixels);
        Assert.Equal(poster, camera.CanPrintPoster());
    }
    [Theory]
    [InlineData(-1, false)]
    [InlineData(2999, false)]
    [InlineData(3000, true)]
    [InlineData(3500, true)]
    public void ProjectorThreshold(int lumens, bool hall)
    {
        var projector = new Projector("P", lumens);
        Assert.Equal(Math.Max(0, lumens), projector.Lumens);
        Assert.Equal(hall, projector.IsSuitableForHall());
    }
    [Fact]
    public void DescriptionsDispatchThroughParentReferences()
    {
        Equipment[] equipment = { new Camera("C1", 24), new Projector("P1", 3500), new Equipment("E1") };
        Assert.Equal(new[] { "Equipment C1, camera 24 MP", "Equipment P1, projector 3500 lm", "Equipment E1" }, equipment.Select(item => item.GetDescription()));
        Assert.Equal(new[] { 12m, 20m, 5m }, equipment.Select(item => item.DailyRate));
    }

}
