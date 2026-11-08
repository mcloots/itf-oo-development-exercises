using Xunit;
using Ch04WorkshopRegistration;

namespace Ch04WorkshopRegistration.Tests;

public class ExerciseTests
{
    [Fact]
    public void CapacityAndRegistrationRules()
    {
        var workshop = new Workshop("W1", "C#", 2);
        Assert.Equal("W1", workshop.Code);
        Assert.Equal("C#", workshop.Title);
        Assert.Equal("No participants.", workshop.GetReport());
        var first = new Participant("P1", "Mina");
        Assert.True(workshop.Register(first));
        Assert.False(workshop.Register(new Participant("P1", "Duplicate")));
        Assert.False(workshop.Register(null));
        Assert.True(workshop.Register(new Participant("P2", "Noah")));
        Assert.False(workshop.Register(new Participant("P3", "Full")));
        Assert.Equal(2, workshop.ParticipantCount);
        workshop.Capacity = 1;
        Assert.Equal(2, workshop.Capacity);
        workshop.Capacity = 2;
        Assert.Equal(2, workshop.Capacity);
        Assert.Same(first, workshop.FindParticipant("P1"));
        Assert.Null(workshop.FindParticipant("missing"));
        first.Name = "Noor";
        Assert.Equal(new[] { "P1 | Noor", "P2 | Noah" }, workshop.GetReport().Replace("\r", "").TrimEnd().Split('\n'));
        Assert.True(workshop.Cancel("P1"));
        Assert.False(workshop.Cancel("P1"));
        Assert.Equal(1, workshop.ParticipantCount);
        Assert.True(workshop.Register(new Participant("P3", "New")));
        workshop.Capacity = 3;
        Assert.True(workshop.Register(first));
    }
    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public void InvalidCapacityDefaultsOrKeepsPrevious(int capacity)
    {
        var workshop = new Workshop("W", "Title", capacity);
        Assert.Equal(1, workshop.Capacity);
        workshop.Capacity = 3;
        workshop.Capacity = capacity;
        Assert.Equal(3, workshop.Capacity);
    }

}
