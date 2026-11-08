using Xunit;
using Ch02MuseumAdmission;
using App = Ch02MuseumAdmission.Program;

namespace Ch02MuseumAdmission.Tests;

public class ExerciseTests
{
    [Theory]
    [InlineData(0, 0)]
    [InlineData(5, 0)]
    [InlineData(6, 6)]
    [InlineData(17, 6)]
    [InlineData(18, 12)]
    [InlineData(64, 12)]
    [InlineData(65, 8)]
    [InlineData(100, 8)]
    public void AdmissionBoundaries(int age, int euros)
    {
        Assert.Equal((decimal)euros, App.GetAdmissionPrice(age));
    }
    [Theory]
    [InlineData(0)]
    [InlineData(5)]
    [InlineData(6)]
    [InlineData(17)]
    [InlineData(18)]
    [InlineData(64)]
    [InlineData(65)]
    public void TourSupplement(int age)
    {
        Assert.Equal(App.GetAdmissionPrice(age), App.CalculateVisitPrice(age, false));
        Assert.Equal(App.GetAdmissionPrice(age) + 4m, App.CalculateVisitPrice(age, true));
    }

}
