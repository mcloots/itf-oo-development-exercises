using Xunit;
using Ch03ToolLoan;

namespace Ch03ToolLoan.Tests;

public class ExerciseTests
{
    [Fact]
    public void LoanStateTransitions()
    {
        var loan = new ToolLoan("DRILL-01");
        Assert.Equal("DRILL-01", loan.GetToolCode());
        Assert.False(loan.GetIsBorrowed());
        Assert.Equal("", loan.GetBorrower());
        Assert.False(loan.ReturnTool());
        Assert.False(loan.Borrow("   "));
        Assert.Equal("", loan.GetBorrower());
        Assert.True(loan.Borrow("Mila"));
        Assert.True(loan.GetIsBorrowed());
        Assert.False(loan.Borrow("Noor"));
        Assert.Equal("Mila", loan.GetBorrower());
        Assert.True(loan.GetIsBorrowed());
        Assert.True(loan.ReturnTool());
        Assert.Equal("", loan.GetBorrower());
        Assert.False(loan.GetIsBorrowed());
        Assert.True(loan.Borrow("Noor"));
        Assert.Equal("Noor", loan.GetBorrower());
        Assert.Equal("UNKNOWN", new ToolLoan("").GetToolCode());
    }

}
