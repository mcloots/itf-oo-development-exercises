using Xunit;
using Ch04RoomTemperatures;

namespace Ch04RoomTemperatures.Tests;

public class ExerciseTests
{
    [Theory]
    [InlineData(150, 150)]
    [InlineData(250, 250)]
    [InlineData(235, 235)]
    [InlineData(149, 200)]
    [InlineData(251, 200)]
    public void TemperatureValidation(int tenths, int expectedTenths)
    {
        var room = new RoomThermostat("R1", "Studio", tenths / 10m);
        Assert.Equal(expectedTenths / 10m, room.TargetTemperature);
        room.TargetTemperature = 22m;
        room.TargetTemperature = 30m;
        Assert.Equal(22m, room.TargetTemperature);
    }
    [Fact]
    public void SharedReferenceChangesLabel()
    {
        var room = new RoomThermostat("R1", "Studio", 20m);
        var alias = room;
        alias.Label = "North";
        Assert.Equal("North", room.Label);
        Assert.Equal("R1", room.RoomCode);
        Assert.Contains("North", room.GetDescription());
    }

}
