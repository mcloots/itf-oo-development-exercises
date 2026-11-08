using Xunit;
using Ch02WaterBill;
using App = Ch02WaterBill.Program;

namespace Ch02WaterBill.Tests;

public class ExerciseTests
{
    [Theory]
    [InlineData(0, 0)]
    [InlineData(450, 900)]
    [InlineData(1000, 2000)]
    [InlineData(1001, 2003)]
    [InlineData(1200, 2600)]
    [InlineData(2350, 6050)]
    public void ProgressiveUsageCost(int hundredths, int cents)
    {
        Assert.Equal(cents / 100m, App.CalculateUsageCost(hundredths / 100m));
    }

}
