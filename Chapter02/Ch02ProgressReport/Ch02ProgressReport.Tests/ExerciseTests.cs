using Xunit;
using Ch02ProgressReport;
using App = Ch02ProgressReport.Program;

namespace Ch02ProgressReport.Tests;

public class ExerciseTests
{
    [Theory]
    [InlineData(3, 8, 3750)]
    [InlineData(0, 8, 0)]
    [InlineData(8, 8, 10000)]
    [InlineData(1, 4, 2500)]
    [InlineData(7, 20, 3500)]
    public void UsesDecimalDivision(int completed, int planned, int hundredths)
    {
        Assert.Equal(hundredths / 100m, App.CalculateCompletionPercentage(completed, planned));
    }

}
