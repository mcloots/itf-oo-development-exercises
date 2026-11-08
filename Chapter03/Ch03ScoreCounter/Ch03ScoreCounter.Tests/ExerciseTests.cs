using Xunit;
using Ch03ScoreCounter;

namespace Ch03ScoreCounter.Tests;

public class ExerciseTests
{
    [Fact]
    public void ReferencesShareStateAndSeparateObjectsDoNot()
    {
        var blue = new ScoreCounter("Blue");
        var red = new ScoreCounter("Red");
        Assert.Equal(0, blue.GetScore());
        var display = blue;
        blue.AddPoints(10);
        display.AddPoints(5);
        red.AddPoints(7);
        display.SetScore(-1);
        Assert.Equal("Blue", blue.GetTeamName());
        Assert.Equal(15, blue.GetScore());
        Assert.Equal(7, red.GetScore());
        display.Reset();
        Assert.Equal(0, blue.GetScore());
        Assert.Equal(7, red.GetScore());
        blue.SetScore(15);
        var independent = new ScoreCounter("Blue");
        independent.Reset();
        Assert.Equal(15, blue.GetScore());
    }
    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public void NonpositivePointsIgnored(int points)
    {
        var counter = new ScoreCounter("Blue");
        counter.SetScore(5);
        counter.AddPoints(points);
        Assert.Equal(5, counter.GetScore());
        counter.SetScore(0);
        Assert.Equal(0, counter.GetScore());
    }

}
