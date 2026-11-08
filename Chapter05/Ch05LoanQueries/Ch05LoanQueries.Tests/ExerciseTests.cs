using Xunit;
using Ch05LoanQueries;

namespace Ch05LoanQueries.Tests;

public class ExerciseTests
{
    [Fact]
    public void OverdueQueriesFollowMemberAndReturnedState()
    {
        var desk = new LoanDesk();
        Assert.Empty(desk.GetOverdueReport());
        Assert.Equal(0, desk.CountOverdue());
        Assert.False(desk.HasOverdueForMember("C1"));
        Assert.Null(desk.FindMostOverdueForMember("C1"));
        var mina = new Member("C1", "Mina");
        var noah = new Member("C2", "Noah");
        var first = new ToolLoan("L1", mina, "Drill", -3, false);
        Assert.True(desk.AddLoan(new ToolLoan("L3", mina, "Sander", -1, false)));
        Assert.True(desk.AddLoan(first));
        Assert.True(desk.AddLoan(new ToolLoan("L2", noah, "Saw", 2, false)));
        Assert.True(desk.AddLoan(new ToolLoan("L4", noah, "Plane", -5, true)));
        Assert.True(desk.AddLoan(new ToolLoan("L5", noah, "Hammer", 0, false)));
        Assert.False(desk.AddLoan(null));
        Assert.False(desk.AddLoan(new ToolLoan("L1", mina, "Duplicate", -9, false)));
        Assert.Equal(5, desk.Count);
        Assert.Equal(new[] { "L1: Mina / Drill", "L3: Mina / Sander" }, desk.GetOverdueReport());
        Assert.Equal(2, desk.CountOverdue());
        Assert.True(desk.HasOverdueForMember("C1"));
        Assert.False(desk.HasOverdueForMember("C2"));
        Assert.False(desk.HasOverdueForMember("unknown"));
        Assert.Null(desk.FindMostOverdueForMember("unknown"));
        Assert.Null(desk.FindByCode("unknown"));
        Assert.Same(first, desk.FindByCode("L1"));
        Assert.Same(first, desk.FindMostOverdueForMember("C1"));
        Assert.Same(mina, first.Member);
        mina.Name = "Noor";
        Assert.Equal("L1: Noor / Drill", desk.GetOverdueReport()[0]);
        first.IsReturned = true;
        Assert.Equal(new[] { "L3: Noor / Sander" }, desk.GetOverdueReport());
        Assert.Equal(1, desk.CountOverdue());
    }

}
