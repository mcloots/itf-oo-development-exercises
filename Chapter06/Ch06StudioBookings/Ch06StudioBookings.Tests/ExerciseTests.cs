using Xunit;
using Ch06StudioBookings;

namespace Ch06StudioBookings.Tests;

public class ExerciseTests
{
    [Fact]
    public void BookingKeepsStudioReference()
    {
        var studio = new Studio("Blue Room", 18m, true);
        var booking = new StudioBooking(studio, 3);
        Assert.IsAssignableFrom<Room>(studio);
        Assert.Equal("Blue Room", studio.Name);
        Assert.Equal(18m, studio.HourlyRate);
        Assert.True(studio.HasPiano);
        Assert.Equal("Piano available", studio.GetEquipmentDescription());
        Assert.Same(studio, booking.Studio);
        Assert.Equal(3, booking.Hours);
        Assert.Equal(54m, booking.GetTotalCost());
        Assert.Equal("No piano", new Studio("Other", 18m, false).GetEquipmentDescription());
    }
    [Theory]
    [InlineData(18, 0)]
    [InlineData(18, -1)]
    [InlineData(-1, 3)]
    [InlineData(0, 3)]
    public void NonpositiveHoursAndRate(int rate, int hours)
    {
        var studio = new Studio("Room", rate, false);
        var booking = new StudioBooking(studio, hours);
        Assert.Equal(Math.Max(0, hours), booking.Hours);
        Assert.Equal(0m, booking.GetTotalCost());
        Assert.Equal(0m, studio.GetCost(hours));
    }

}
